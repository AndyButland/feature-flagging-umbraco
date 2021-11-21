//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "visibilityControls"
	/// <summary>Visibility Controls</summary>
	public partial interface IVisibilityControls : IPublishedContent
	{
		/// <summary>Hide From XML Sitemap</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		bool HideFromXmlsitemap { get; }

		/// <summary>Umbraco Navi Hide</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		bool UmbracoNaviHide { get; }
	}

	/// <summary>Visibility Controls</summary>
	[PublishedModel("visibilityControls")]
	public partial class VisibilityControls : PublishedContentModel, IVisibilityControls
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		public new const string ModelTypeAlias = "visibilityControls";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<VisibilityControls, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public VisibilityControls(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Hide From XML Sitemap: Tick this if you want to hide this page from the XML sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		[ImplementPropertyType("hideFromXMLSitemap")]
		public virtual bool HideFromXmlsitemap => GetHideFromXmlsitemap(this, _publishedValueFallback);

		/// <summary>Static getter for Hide From XML Sitemap</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		public static bool GetHideFromXmlsitemap(IVisibilityControls that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "hideFromXMLSitemap");

		///<summary>
		/// Umbraco Navi Hide: Tick this box if you want to hide this page from the navigation and from search results
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool UmbracoNaviHide => GetUmbracoNaviHide(this, _publishedValueFallback);

		/// <summary>Static getter for Umbraco Navi Hide</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.1.0+b0a4a92f578580e6045a0cf58a4ba5ff65fc4187")]
		public static bool GetUmbracoNaviHide(IVisibilityControls that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "umbracoNaviHide");
	}
}
