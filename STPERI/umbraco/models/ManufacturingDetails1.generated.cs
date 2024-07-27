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
	/// <summary>ManufacturingDetails1</summary>
	[PublishedModel("manufacturingDetails1")]
	public partial class ManufacturingDetails1 : PublishedContentModel, IHeaderProperties, ITrainingdetailsProperty
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const string ModelTypeAlias = "manufacturingDetails1";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ManufacturingDetails1, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ManufacturingDetails1(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// ApplyForm
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("applyForm")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ApplyForm => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "applyForm");

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
		/// Author
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("author")]
		public virtual string Author => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetAuthor(this, _publishedValueFallback);

		///<summary>
		/// Category
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("category")]
		public virtual string Category => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetCategory(this, _publishedValueFallback);

		///<summary>
		/// FirstImageGallery
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstImageGallery")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstImageGallery => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetFirstImageGallery(this, _publishedValueFallback);

		///<summary>
		/// ForthImageGallery
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("forthImageGallery")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ForthImageGallery => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetForthImageGallery(this, _publishedValueFallback);

		///<summary>
		/// GalleryTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("galleryTitle")]
		public virtual string GalleryTitle => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetGalleryTitle(this, _publishedValueFallback);

		///<summary>
		/// OfferFirstDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offerFirstDescription")]
		public virtual string OfferFirstDescription => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetOfferFirstDescription(this, _publishedValueFallback);

		///<summary>
		/// OfferForthDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offerForthDescription")]
		public virtual string OfferForthDescription => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetOfferForthDescription(this, _publishedValueFallback);

		///<summary>
		/// OfferSecondDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offerSecondDescription")]
		public virtual string OfferSecondDescription => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetOfferSecondDescription(this, _publishedValueFallback);

		///<summary>
		/// OfferThirdDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offerThirdDescription")]
		public virtual string OfferThirdDescription => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetOfferThirdDescription(this, _publishedValueFallback);

		///<summary>
		/// OfferTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("offerTitle")]
		public virtual string OfferTitle => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetOfferTitle(this, _publishedValueFallback);

		///<summary>
		/// Price
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("price")]
		public virtual string Price => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetPrice(this, _publishedValueFallback);

		///<summary>
		/// SecondImageGallery
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondImageGallery")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondImageGallery => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetSecondImageGallery(this, _publishedValueFallback);

		///<summary>
		/// Startdate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("startdate")]
		public virtual string Startdate => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetStartdate(this, _publishedValueFallback);

		///<summary>
		/// ThirdImageGallery
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thirdImageGallery")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ThirdImageGallery => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetThirdImageGallery(this, _publishedValueFallback);

		///<summary>
		/// Traininglevel
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("traininglevel")]
		public virtual string Traininglevel => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetTraininglevel(this, _publishedValueFallback);

		///<summary>
		/// TrainingTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("trainingTitle")]
		public virtual string TrainingTitle => global::Umbraco.Cms.Web.Common.PublishedModels.TrainingdetailsProperty.GetTrainingTitle(this, _publishedValueFallback);
	}
}
