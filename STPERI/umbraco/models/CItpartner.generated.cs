//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.3.2+696a711
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
	/// <summary>CITpartner</summary>
	[PublishedModel("cITpartner")]
	public partial class CItpartner : PublishedContentModel, IHeaderProperties, INewspaperdetailsProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const string ModelTypeAlias = "cITpartner";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<CItpartner, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public CItpartner(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// BannerImage: Enter the banner image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bannerImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops BannerImage => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetBannerImage(this, _publishedValueFallback);

		///<summary>
		/// gateway
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("gateway")]
		public virtual string Gateway => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetGateway(this, _publishedValueFallback);

		///<summary>
		/// SubscribedFormm
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("subscribedFormm")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SubscribedFormm => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetSubscribedFormm(this, _publishedValueFallback);

		///<summary>
		/// Subtitle: Enter you sup title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("subtitle")]
		public virtual string Subtitle => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetSubtitle(this, _publishedValueFallback);

		///<summary>
		/// Title: Enter a title for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Umbraco.Cms.Web.Common.PublishedModels.HeaderProperties.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// DescriptionHeader
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("descriptionHeader")]
		public virtual string DescriptionHeader => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetDescriptionHeader(this, _publishedValueFallback);

		///<summary>
		/// ElyoumElsabeaImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("elyoumElsabeaImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ElyoumElsabeaImage => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetElyoumElsabeaImage(this, _publishedValueFallback);

		///<summary>
		/// EventDate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eventDate")]
		public virtual string EventDate => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetEventDate(this, _publishedValueFallback);

		///<summary>
		/// EventLocation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("eventLocation")]
		public virtual string EventLocation => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetEventLocation(this, _publishedValueFallback);

		///<summary>
		/// FirstSectionImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstSectionImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstSectionImage => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetFirstSectionImage(this, _publishedValueFallback);

		///<summary>
		/// SecondSectionImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondSectionImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondSectionImage => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetSecondSectionImage(this, _publishedValueFallback);

		///<summary>
		/// SectionDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sectionDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString SectionDescription => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetSectionDescription(this, _publishedValueFallback);

		///<summary>
		/// SectionTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sectionTitle")]
		public virtual string SectionTitle => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetSectionTitle(this, _publishedValueFallback);

		///<summary>
		/// TitleHeaderNewsPaper
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleHeaderNewsPaper")]
		public virtual string TitleHeaderNewsPaper => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetTitleHeaderNewsPaper(this, _publishedValueFallback);

		///<summary>
		/// TopicFirstDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicFirstDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString TopicFirstDescription => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetTopicFirstDescription(this, _publishedValueFallback);

		///<summary>
		/// TopicSecondDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicSecondDescription")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString TopicSecondDescription => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetTopicSecondDescription(this, _publishedValueFallback);

		///<summary>
		/// TopicSecondTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicSecondTitle")]
		public virtual string TopicSecondTitle => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetTopicSecondTitle(this, _publishedValueFallback);

		///<summary>
		/// TopicTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicTitle")]
		public virtual string TopicTitle => global::Umbraco.Cms.Web.Common.PublishedModels.NewspaperdetailsProperties.GetTopicTitle(this, _publishedValueFallback);
	}
}
