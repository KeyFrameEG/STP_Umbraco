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
	/// <summary>RCYKL Page</summary>
	[PublishedModel("rCYKLPage")]
	public partial class RCyklpage : PublishedContentModel, IHeaderProperties, IStartupProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const string ModelTypeAlias = "rCYKLPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<RCyklpage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public RCyklpage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
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
		/// AboutCompany
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("aboutCompany")]
		public virtual string AboutCompany => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetAboutCompany(this, _publishedValueFallback);

		///<summary>
		/// Ceo Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ceoImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops CeoImage => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetCeoImage(this, _publishedValueFallback);

		///<summary>
		/// Ceo Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ceoName")]
		public virtual string CeoName => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetCeoName(this, _publishedValueFallback);

		///<summary>
		/// Ceo Role
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ceoRole")]
		public virtual string CeoRole => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetCeoRole(this, _publishedValueFallback);

		///<summary>
		/// CompanyDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companyDescription")]
		public virtual string CompanyDescription => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetCompanyDescription(this, _publishedValueFallback);

		///<summary>
		/// CompanySecondDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("companySecondDescription")]
		public virtual string CompanySecondDescription => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetCompanySecondDescription(this, _publishedValueFallback);

		///<summary>
		/// FirstGoal
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstGoal")]
		public virtual string FirstGoal => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetFirstGoal(this, _publishedValueFallback);

		///<summary>
		/// FirstImageProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstImageProduct")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstImageProduct => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetFirstImageProduct(this, _publishedValueFallback);

		///<summary>
		/// FirstService
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstService")]
		public virtual string FirstService => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetFirstService(this, _publishedValueFallback);

		///<summary>
		/// FirstVision
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstVision")]
		public virtual string FirstVision => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetFirstVision(this, _publishedValueFallback);

		///<summary>
		/// Goals
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("goals")]
		public virtual string Goals => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetGoals(this, _publishedValueFallback);

		///<summary>
		/// Logo Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("logoImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops LogoImage => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetLogoImage(this, _publishedValueFallback);

		///<summary>
		/// Message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("message")]
		public virtual string Message => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetMessage(this, _publishedValueFallback);

		///<summary>
		/// MessageTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("messageTitle")]
		public virtual string MessageTitle => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetMessageTitle(this, _publishedValueFallback);

		///<summary>
		/// PreviousClients
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("previousClients")]
		public virtual string PreviousClients => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetPreviousClients(this, _publishedValueFallback);

		///<summary>
		/// PreviousClientsTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("previousClientsTitle")]
		public virtual string PreviousClientsTitle => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetPreviousClientsTitle(this, _publishedValueFallback);

		///<summary>
		/// Products
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("products")]
		public virtual string Products => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetProducts(this, _publishedValueFallback);

		///<summary>
		/// Rnkerapp
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rnkerapp")]
		public virtual string Rnkerapp => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetRnkerapp(this, _publishedValueFallback);

		///<summary>
		/// RnkerEmail
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("rnkerEmail")]
		public virtual string RnkerEmail => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetRnkerEmail(this, _publishedValueFallback);

		///<summary>
		/// SecondGoal
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondGoal")]
		public virtual string SecondGoal => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetSecondGoal(this, _publishedValueFallback);

		///<summary>
		/// SecondImageProduct
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondImageProduct")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondImageProduct => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetSecondImageProduct(this, _publishedValueFallback);

		///<summary>
		/// SecondService
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondService")]
		public virtual string SecondService => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetSecondService(this, _publishedValueFallback);

		///<summary>
		/// SecondVision
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondVision")]
		public virtual string SecondVision => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetSecondVision(this, _publishedValueFallback);

		///<summary>
		/// ServicesProvided
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("servicesProvided")]
		public virtual string ServicesProvided => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetServicesProvided(this, _publishedValueFallback);

		///<summary>
		/// ThirdService
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thirdService")]
		public virtual string ThirdService => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetThirdService(this, _publishedValueFallback);

		///<summary>
		/// Vision
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("vision")]
		public virtual string Vision => global::Umbraco.Cms.Web.Common.PublishedModels.StartupProperties.GetVision(this, _publishedValueFallback);
	}
}