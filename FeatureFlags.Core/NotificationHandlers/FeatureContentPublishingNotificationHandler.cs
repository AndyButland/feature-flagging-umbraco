﻿namespace FeatureFlags.Core.NotificationHandlers
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    using FeatureFlags.Core.Constants;
    using FeatureFlags.Core.Editors.FeatureFlagged;
    using FeatureFlags.Core.Extensions;

    using Microsoft.FeatureManagement;
    
    using Umbraco.Cms.Core.Events;
    using Umbraco.Cms.Core.Notifications;
    using Umbraco.Cms.Core.Services;
    using Umbraco.Extensions;

    public class FeatureContentPublishingNotificationHandler : INotificationAsyncHandler<ContentPublishingNotification>
    {
        private readonly IFeatureManager _featureManager;

        private readonly IDataTypeService _dataTypeService;

        public FeatureContentPublishingNotificationHandler(IFeatureManager featureManager, IDataTypeService dataTypeService)
        {
            _featureManager = featureManager;
            _dataTypeService = dataTypeService;
        }
        public async Task HandleAsync(ContentPublishingNotification notification, CancellationToken cancellationToken)
        {
            var enabledFeatures = await _featureManager.GetEnabledFeatures();

            foreach (var entity in notification.PublishedEntities)
            {
                foreach(var prop in entity.Properties.Where(p => p.PropertyType.PropertyEditorAlias == DataTypes.FeatureFlagged.Alias))
                {
                    var dataType = _dataTypeService.GetDataType(prop.PropertyType.DataTypeId);
                    var config = dataType.Configuration as FeatureFlaggedConfiguration;

                    var enabled = config.Requirement switch
                    {
                        RequirementType.Any => enabledFeatures.ContainsAny(config.Features),
                        RequirementType.All => enabledFeatures.ContainsAll(config.Features),
                        _ => throw new InvalidOperationException($"Configured requirement ({config.Requirement}) had no matching {nameof(RequirementType)} "),
                    };
                    if (!enabled)
                    {
                        prop.PropertyType.Mandatory = false;
                    }

                }
            }
        }
    }
}