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
	// Mixin Content Type with alias "newspaperdetailsProperties"
	/// <summary>Newspaperdetails Properties</summary>
	public partial interface INewspaperdetailsProperties : IPublishedElement
	{
		/// <summary>DescriptionHeader</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string DescriptionHeader { get; }

		/// <summary>ElyoumElsabeaImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops ElyoumElsabeaImage { get; }

		/// <summary>FirstSectionImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops FirstSectionImage { get; }

		/// <summary>SecondSectionImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops SecondSectionImage { get; }

		/// <summary>SectionDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SectionDescription { get; }

		/// <summary>SectionTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string SectionTitle { get; }

		/// <summary>TitleHeaderNewsPaper</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string TitleHeaderNewsPaper { get; }

		/// <summary>TopicFirstDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string TopicFirstDescription { get; }

		/// <summary>TopicSecondDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string TopicSecondDescription { get; }

		/// <summary>TopicTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string TopicTitle { get; }
	}

	/// <summary>Newspaperdetails Properties</summary>
	[PublishedModel("newspaperdetailsProperties")]
	public partial class NewspaperdetailsProperties : PublishedElementModel, INewspaperdetailsProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const string ModelTypeAlias = "newspaperdetailsProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<NewspaperdetailsProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public NewspaperdetailsProperties(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// DescriptionHeader
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("descriptionHeader")]
		public virtual string DescriptionHeader => GetDescriptionHeader(this, _publishedValueFallback);

		/// <summary>Static getter for DescriptionHeader</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetDescriptionHeader(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "descriptionHeader");

		///<summary>
		/// ElyoumElsabeaImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("elyoumElsabeaImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ElyoumElsabeaImage => GetElyoumElsabeaImage(this, _publishedValueFallback);

		/// <summary>Static getter for ElyoumElsabeaImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetElyoumElsabeaImage(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "elyoumElsabeaImage");

		///<summary>
		/// FirstSectionImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("firstSectionImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops FirstSectionImage => GetFirstSectionImage(this, _publishedValueFallback);

		/// <summary>Static getter for FirstSectionImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetFirstSectionImage(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "firstSectionImage");

		///<summary>
		/// SecondSectionImage
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("secondSectionImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops SecondSectionImage => GetSecondSectionImage(this, _publishedValueFallback);

		/// <summary>Static getter for SecondSectionImage</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetSecondSectionImage(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "secondSectionImage");

		///<summary>
		/// SectionDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sectionDescription")]
		public virtual string SectionDescription => GetSectionDescription(this, _publishedValueFallback);

		/// <summary>Static getter for SectionDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSectionDescription(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "sectionDescription");

		///<summary>
		/// SectionTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sectionTitle")]
		public virtual string SectionTitle => GetSectionTitle(this, _publishedValueFallback);

		/// <summary>Static getter for SectionTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetSectionTitle(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "sectionTitle");

		///<summary>
		/// TitleHeaderNewsPaper
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titleHeaderNewsPaper")]
		public virtual string TitleHeaderNewsPaper => GetTitleHeaderNewsPaper(this, _publishedValueFallback);

		/// <summary>Static getter for TitleHeaderNewsPaper</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetTitleHeaderNewsPaper(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "titleHeaderNewsPaper");

		///<summary>
		/// TopicFirstDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicFirstDescription")]
		public virtual string TopicFirstDescription => GetTopicFirstDescription(this, _publishedValueFallback);

		/// <summary>Static getter for TopicFirstDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetTopicFirstDescription(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "topicFirstDescription");

		///<summary>
		/// TopicSecondDescription
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicSecondDescription")]
		public virtual string TopicSecondDescription => GetTopicSecondDescription(this, _publishedValueFallback);

		/// <summary>Static getter for TopicSecondDescription</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetTopicSecondDescription(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "topicSecondDescription");

		///<summary>
		/// TopicTitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("topicTitle")]
		public virtual string TopicTitle => GetTopicTitle(this, _publishedValueFallback);

		/// <summary>Static getter for TopicTitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.3.2+696a711")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetTopicTitle(INewspaperdetailsProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "topicTitle");
	}
}
