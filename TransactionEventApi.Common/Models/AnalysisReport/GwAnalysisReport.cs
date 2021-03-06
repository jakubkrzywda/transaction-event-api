﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Diagnostics.CodeAnalysis;

namespace Glasswall.Administration.K8.TransactionEventApi.Common.Models.AnalysisReport
{


    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://glasswall.com/namespace", IsNullable = false)]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfo
    {

        private GWallInfoDocumentStatistics documentStatisticsField;

        /// <remarks/>
        public GWallInfoDocumentStatistics DocumentStatistics
        {
            get
            {
                return this.documentStatisticsField;
            }
            set
            {
                this.documentStatisticsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatistics
    {

        private GWallInfoDocumentStatisticsDocumentSummary documentSummaryField;

        private GWallInfoDocumentStatisticsCamera[] contentManagementPolicyField;

        private GWallInfoDocumentStatisticsContentGroups contentGroupsField;

        private GWallInfoDocumentStatisticsExtractedItems extractedItemsField;

        /// <remarks/>
        public GWallInfoDocumentStatisticsDocumentSummary DocumentSummary
        {
            get
            {
                return this.documentSummaryField;
            }
            set
            {
                this.documentSummaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Camera", IsNullable = false)]
        public GWallInfoDocumentStatisticsCamera[] ContentManagementPolicy
        {
            get
            {
                return this.contentManagementPolicyField;
            }
            set
            {
                this.contentManagementPolicyField = value;
            }
        }

        /// <remarks/>
        public GWallInfoDocumentStatisticsContentGroups ContentGroups
        {
            get
            {
                return this.contentGroupsField;
            }
            set
            {
                this.contentGroupsField = value;
            }
        }

        /// <remarks/>
        public GWallInfoDocumentStatisticsExtractedItems ExtractedItems
        {
            get
            {
                return this.extractedItemsField;
            }
            set
            {
                this.extractedItemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsDocumentSummary
    {

        private uint totalSizeInBytesField;

        private string fileTypeField;

        private string versionField;

        /// <remarks/>
        public uint TotalSizeInBytes
        {
            get
            {
                return this.totalSizeInBytesField;
            }
            set
            {
                this.totalSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public string FileType
        {
            get
            {
                return this.fileTypeField;
            }
            set
            {
                this.fileTypeField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsCamera
    {

        private GWallInfoDocumentStatisticsCameraContentSwitch[] contentSwitchField;

        private string cameraNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentSwitch")]
        public GWallInfoDocumentStatisticsCameraContentSwitch[] ContentSwitch
        {
            get
            {
                return this.contentSwitchField;
            }
            set
            {
                this.contentSwitchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cameraName
        {
            get
            {
                return this.cameraNameField;
            }
            set
            {
                this.cameraNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsCameraContentSwitch
    {

        private string contentNameField;

        private string contentValueField;

        /// <remarks/>
        public string ContentName
        {
            get
            {
                return this.contentNameField;
            }
            set
            {
                this.contentNameField = value;
            }
        }

        /// <remarks/>
        public string ContentValue
        {
            get
            {
                return this.contentValueField;
            }
            set
            {
                this.contentValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroups
    {

        private GWallInfoDocumentStatisticsContentGroupsContentGroup[] contentGroupField;

        private byte groupCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentGroup")]
        public GWallInfoDocumentStatisticsContentGroupsContentGroup[] ContentGroup
        {
            get
            {
                return this.contentGroupField;
            }
            set
            {
                this.contentGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte groupCount
        {
            get
            {
                return this.groupCountField;
            }
            set
            {
                this.groupCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroup
    {

        private string briefDescriptionField;

        private GWallInfoDocumentStatisticsContentGroupsContentGroupContentItems contentItemsField;

        private GWallInfoDocumentStatisticsContentGroupsContentGroupSanitisationItems sanitisationItemsField;

        private GWallInfoDocumentStatisticsContentGroupsContentGroupRemedyItems remedyItemsField;

        private GWallInfoDocumentStatisticsContentGroupsContentGroupIssueItems issueItemsField;

        /// <remarks/>
        public string BriefDescription
        {
            get
            {
                return this.briefDescriptionField;
            }
            set
            {
                this.briefDescriptionField = value;
            }
        }

        /// <remarks/>
        public GWallInfoDocumentStatisticsContentGroupsContentGroupContentItems ContentItems
        {
            get
            {
                return this.contentItemsField;
            }
            set
            {
                this.contentItemsField = value;
            }
        }

        /// <remarks/>
        public GWallInfoDocumentStatisticsContentGroupsContentGroupSanitisationItems SanitisationItems
        {
            get
            {
                return this.sanitisationItemsField;
            }
            set
            {
                this.sanitisationItemsField = value;
            }
        }

        /// <remarks/>
        public GWallInfoDocumentStatisticsContentGroupsContentGroupRemedyItems RemedyItems
        {
            get
            {
                return this.remedyItemsField;
            }
            set
            {
                this.remedyItemsField = value;
            }
        }

        /// <remarks/>
        public GWallInfoDocumentStatisticsContentGroupsContentGroupIssueItems IssueItems
        {
            get
            {
                return this.issueItemsField;
            }
            set
            {
                this.issueItemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupContentItems
    {

        private GWallInfoDocumentStatisticsContentGroupsContentGroupContentItemsContentItem[] contentItemField;

        private byte itemCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentItem")]
        public GWallInfoDocumentStatisticsContentGroupsContentGroupContentItemsContentItem[] ContentItem
        {
            get
            {
                return this.contentItemField;
            }
            set
            {
                this.contentItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupContentItemsContentItem
    {

        private string technicalDescriptionField;

        private ushort instanceCountField;

        private uint totalSizeInBytesField;

        private uint averageSizeInBytesField;

        private uint minSizeInBytesField;

        private uint maxSizeInBytesField;

        /// <remarks/>
        public string TechnicalDescription
        {
            get
            {
                return this.technicalDescriptionField;
            }
            set
            {
                this.technicalDescriptionField = value;
            }
        }

        /// <remarks/>
        public ushort InstanceCount
        {
            get
            {
                return this.instanceCountField;
            }
            set
            {
                this.instanceCountField = value;
            }
        }

        /// <remarks/>
        public uint TotalSizeInBytes
        {
            get
            {
                return this.totalSizeInBytesField;
            }
            set
            {
                this.totalSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public uint AverageSizeInBytes
        {
            get
            {
                return this.averageSizeInBytesField;
            }
            set
            {
                this.averageSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public uint MinSizeInBytes
        {
            get
            {
                return this.minSizeInBytesField;
            }
            set
            {
                this.minSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public uint MaxSizeInBytes
        {
            get
            {
                return this.maxSizeInBytesField;
            }
            set
            {
                this.maxSizeInBytesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupSanitisationItems
    {

        private GWallInfoDocumentStatisticsContentGroupsContentGroupSanitisationItemsSanitisationItem[] sanitisationItemField;

        private byte itemCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SanitisationItem")]
        public GWallInfoDocumentStatisticsContentGroupsContentGroupSanitisationItemsSanitisationItem[] SanitisationItem
        {
            get
            {
                return this.sanitisationItemField;
            }
            set
            {
                this.sanitisationItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupSanitisationItemsSanitisationItem
    {

        private string technicalDescriptionField;

        private uint sanitisationIdField;

        private byte instanceCountField;

        private ushort totalSizeInBytesField;

        private ushort averageSizeInBytesField;

        private ushort minSizeInBytesField;

        private ushort maxSizeInBytesField;

        /// <remarks/>
        public string TechnicalDescription
        {
            get
            {
                return this.technicalDescriptionField;
            }
            set
            {
                this.technicalDescriptionField = value;
            }
        }

        /// <remarks/>
        public uint SanitisationId
        {
            get
            {
                return this.sanitisationIdField;
            }
            set
            {
                this.sanitisationIdField = value;
            }
        }

        /// <remarks/>
        public byte InstanceCount
        {
            get
            {
                return this.instanceCountField;
            }
            set
            {
                this.instanceCountField = value;
            }
        }

        /// <remarks/>
        public ushort TotalSizeInBytes
        {
            get
            {
                return this.totalSizeInBytesField;
            }
            set
            {
                this.totalSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public ushort AverageSizeInBytes
        {
            get
            {
                return this.averageSizeInBytesField;
            }
            set
            {
                this.averageSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public ushort MinSizeInBytes
        {
            get
            {
                return this.minSizeInBytesField;
            }
            set
            {
                this.minSizeInBytesField = value;
            }
        }

        /// <remarks/>
        public ushort MaxSizeInBytes
        {
            get
            {
                return this.maxSizeInBytesField;
            }
            set
            {
                this.maxSizeInBytesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupRemedyItems
    {

        private GWallInfoDocumentStatisticsContentGroupsContentGroupRemedyItemsRemedyItem[] remedyItemField;

        private byte itemCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RemedyItem")]
        public GWallInfoDocumentStatisticsContentGroupsContentGroupRemedyItemsRemedyItem[] RemedyItem
        {
            get
            {
                return this.remedyItemField;
            }
            set
            {
                this.remedyItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupRemedyItemsRemedyItem
    {

        private string technicalDescriptionField;

        private ushort instanceCountField;

        /// <remarks/>
        public string TechnicalDescription
        {
            get
            {
                return this.technicalDescriptionField;
            }
            set
            {
                this.technicalDescriptionField = value;
            }
        }

        /// <remarks/>
        public ushort InstanceCount
        {
            get
            {
                return this.instanceCountField;
            }
            set
            {
                this.instanceCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupIssueItems
    {

        private GWallInfoDocumentStatisticsContentGroupsContentGroupIssueItemsIssueItem[] issueItemField;

        private byte itemCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IssueItem")]
        public GWallInfoDocumentStatisticsContentGroupsContentGroupIssueItemsIssueItem[] IssueItem
        {
            get
            {
                return this.issueItemField;
            }
            set
            {
                this.issueItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsContentGroupsContentGroupIssueItemsIssueItem
    {

        private string technicalDescriptionField;

        private uint issueIdField;

        private byte instanceCountField;

        private string riskLevelField;

        /// <remarks/>
        public string TechnicalDescription
        {
            get
            {
                return this.technicalDescriptionField;
            }
            set
            {
                this.technicalDescriptionField = value;
            }
        }

        /// <remarks/>
        public uint IssueId
        {
            get
            {
                return this.issueIdField;
            }
            set
            {
                this.issueIdField = value;
            }
        }

        /// <remarks/>
        public byte InstanceCount
        {
            get
            {
                return this.instanceCountField;
            }
            set
            {
                this.instanceCountField = value;
            }
        }

        /// <remarks/>
        public string RiskLevel
        {
            get
            {
                return this.riskLevelField;
            }
            set
            {
                this.riskLevelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://glasswall.com/namespace")]
    [ExcludeFromCodeCoverage]
    public partial class GWallInfoDocumentStatisticsExtractedItems
    {

        private byte itemCountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte itemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
    }


}
