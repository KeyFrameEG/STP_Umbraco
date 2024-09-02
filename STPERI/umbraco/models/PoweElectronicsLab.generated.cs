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
	/// <summary>PoweElectronicsLab</summary>
	[PublishedModel("poweElectronicsLab")]
	public partial class PoweElectronicsLab : PublishedContentModel, ICentralLabsDetailsProperties, IHeaderProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const string ModelTypeAlias = "poweElectronicsLab";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<PoweElectronicsLab, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public PoweElectronicsLab(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
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
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ApplyForm => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetApplyForm(this, _publishedValueFallback);

		///<summary>
		/// CentralLabsDetailsDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("centralLabsDetailsDescription")]
		public virtual string CentralLabsDetailsDescription => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetCentralLabsDetailsDescription(this, _publishedValueFallback);

		///<summary>
		/// Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("description")]
		public virtual string Description => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetDescription(this, _publishedValueFallback);

		///<summary>
		/// FirstDescriptionLabDetails
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstDescriptionLabDetails")]
		public virtual string FirstDescriptionLabDetails => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetFirstDescriptionLabDetails(this, _publishedValueFallback);

		///<summary>
		/// LabContent
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("labContent")]
		public virtual string LabContent => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetLabContent(this, _publishedValueFallback);

		///<summary>
		/// LabContentFirstImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("labContentFirstImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LabContentFirstImage => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetLabContentFirstImage(this, _publishedValueFallback);

		///<summary>
		/// LabContentForthImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("labContentForthImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LabContentForthImage => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetLabContentForthImage(this, _publishedValueFallback);

		///<summary>
		/// LabContentSecondImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("labContentSecondImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LabContentSecondImage => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetLabContentSecondImage(this, _publishedValueFallback);

		///<summary>
		/// LabContentThirdImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("labContentThirdImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LabContentThirdImage => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetLabContentThirdImage(this, _publishedValueFallback);

		///<summary>
		/// Main Content CentralLabsDetails
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainContentCentralLabsDetails")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MainContentCentralLabsDetails => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetMainContentCentralLabsDetails(this, _publishedValueFallback);

		///<summary>
		/// Main Content OurTeam
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainContentOurTeam")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel MainContentOurTeam => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetMainContentOurTeam(this, _publishedValueFallback);

		///<summary>
		/// SecondDescriptionLabDetails
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondDescriptionLabDetails")]
		public virtual string SecondDescriptionLabDetails => global::Umbraco.Cms.Web.Common.PublishedModels.CentralLabsDetailsProperties.GetSecondDescriptionLabDetails(this, _publishedValueFallback);

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
	}
}
