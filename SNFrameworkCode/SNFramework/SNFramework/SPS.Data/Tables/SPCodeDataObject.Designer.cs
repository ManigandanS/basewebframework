// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPCodeDataObject.Designer.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery.Propertys;
using SPS.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace SPS.Data.Tables
{
    public partial class SPCodeDataObject : BaseNHibernateDataObject<SPCodeEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_ID));		
		public static readonly StringProperty PROPERTY_NAME = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_NAME));		
		public static readonly StringProperty PROPERTY_DESCRIPTION = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_DESCRIPTION));		
		public static readonly StringProperty PROPERTY_CODE = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_CODE));		
		public static readonly StringProperty PROPERTY_CODETYPE = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_CODETYPE));		
		public static readonly EntityProperty<SPChannelEntity> PROPERTY_CHANNELID = new EntityProperty<SPChannelEntity>(Property.ForName(SPCodeEntity.PROPERTY_NAME_CHANNELID));
		#region channelID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPCodeEntity> InClude_ChannelID_Query(NHibernateDynamicQueryGenerator<SPCodeEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPCodeEntity.PROPERTY_NAME_CHANNELID, PROPERTY_CHANNELID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CHANNELID_ALIAS_NAME = "ChannelID_SPCodeEntity_Alias";
		public static readonly IntProperty PROPERTY_CHANNELID_ID = new IntProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Id"));
		public static readonly StringProperty PROPERTY_CHANNELID_NAME = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_CHANNELID_CODE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Code"));
		public static readonly StringProperty PROPERTY_CHANNELID_DATAOKMESSAGE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataOkMessage"));
		public static readonly StringProperty PROPERTY_CHANNELID_DATAFAILEDMESSAGE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataFailedMessage"));
		public static readonly StringProperty PROPERTY_CHANNELID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Description"));
		public static readonly StringProperty PROPERTY_CHANNELID_DATAADAPTERTYPE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataAdapterType"));
		public static readonly StringProperty PROPERTY_CHANNELID_DATAADAPTERURL = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataAdapterUrl"));
		public static readonly StringProperty PROPERTY_CHANNELID_CHANNELTYPE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelType"));
		public static readonly StringProperty PROPERTY_CHANNELID_IVRFEETIMETYPE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IVRFeeTimeType"));
		public static readonly StringProperty PROPERTY_CHANNELID_IVRTIMEFORMAT = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IVRTimeFormat"));
		public static readonly BoolProperty PROPERTY_CHANNELID_ISSTATEREPORT = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsStateReport"));
		public static readonly StringProperty PROPERTY_CHANNELID_STATEREPORTTYPE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StateReportType"));
		public static readonly StringProperty PROPERTY_CHANNELID_REPORTOKMESSAGE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ReportOkMessage"));
		public static readonly StringProperty PROPERTY_CHANNELID_REPORTFAILEDMESSAGE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ReportFailedMessage"));
		public static readonly StringProperty PROPERTY_CHANNELID_STATEREPORTPARAMNAME = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StateReportParamName"));
		public static readonly StringProperty PROPERTY_CHANNELID_STATEREPORTPARAMVALUE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StateReportParamValue"));
		public static readonly StringProperty PROPERTY_CHANNELID_REQUESTTYPEPARAMNAME = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamName"));
		public static readonly StringProperty PROPERTY_CHANNELID_REQUESTTYPEPARAMSTATEREPORTVALUE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamStateReportValue"));
		public static readonly StringProperty PROPERTY_CHANNELID_REQUESTTYPEPARAMDATAREPORTVALUE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamDataReportValue"));
		public static readonly BoolProperty PROPERTY_CHANNELID_HASFILTERS = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".HasFilters"));
		public static readonly BoolProperty PROPERTY_CHANNELID_ISMONITORREQUEST = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsMonitorRequest"));
		public static readonly BoolProperty PROPERTY_CHANNELID_ISLOGREQUEST = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsLogRequest"));
		public static readonly BoolProperty PROPERTY_CHANNELID_ISPARAMSCONVERT = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsParamsConvert"));
		public static readonly BoolProperty PROPERTY_CHANNELID_ISAUTOLINKID = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsAutoLinkID"));
		public static readonly StringProperty PROPERTY_CHANNELID_AUTOLINKIDFIELDS = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".AutoLinkIDFields"));
		public static readonly StringProperty PROPERTY_CHANNELID_LOGREQUESTTYPE = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LogRequestType"));
		public static readonly DecimalProperty PROPERTY_CHANNELID_PRICE = new DecimalProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Price"));
		public static readonly DecimalProperty PROPERTY_CHANNELID_DEFAULTRATE = new DecimalProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DefaultRate"));
		public static readonly StringProperty PROPERTY_CHANNELID_CHANNELDETAILINFO = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelDetailInfo"));
		public static readonly EntityProperty<SPUpperEntity> PROPERTY_CHANNELID_UPPERID = new EntityProperty<SPUpperEntity>(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".UpperID"));
		public static readonly StringProperty PROPERTY_CHANNELID_CHANNELSTATUS = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelStatus"));
		public static readonly BoolProperty PROPERTY_CHANNELID_ISDISABLE = new BoolProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsDisable"));
		public static readonly IntProperty PROPERTY_CHANNELID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_CHANNELID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_CHANNELID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_CHANNELID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_CHANNELID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly StringProperty PROPERTY_MO = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_MO));		
		public static readonly StringProperty PROPERTY_MOTYPE = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_MOTYPE));		
		public static readonly IntProperty PROPERTY_MOLENGTH = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_MOLENGTH));		
		public static readonly IntProperty PROPERTY_ORDERINDEX = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_ORDERINDEX));		
		public static readonly StringProperty PROPERTY_SPCODE = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_SPCODE));		
		public static readonly StringProperty PROPERTY_SPCODETYPE = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_SPCODETYPE));		
		public static readonly IntProperty PROPERTY_SPCODELENGTH = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_SPCODELENGTH));		
		public static readonly BoolProperty PROPERTY_HASFILTERS = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_HASFILTERS));		
		public static readonly BoolProperty PROPERTY_HASPARAMSCONVERT = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_HASPARAMSCONVERT));		
		public static readonly BoolProperty PROPERTY_ISDIABLE = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_ISDIABLE));		
		public static readonly DecimalProperty PROPERTY_PRICE = new DecimalProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_PRICE));		
		public static readonly StringProperty PROPERTY_OPERATIONTYPE = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_OPERATIONTYPE));		
		public static readonly BoolProperty PROPERTY_HASDAYTOTALLIMIT = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_HASDAYTOTALLIMIT));		
		public static readonly IntProperty PROPERTY_DAYTOTALLIMITCOUNT = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_DAYTOTALLIMITCOUNT));		
		public static readonly BoolProperty PROPERTY_HASPHONELIMIT = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_HASPHONELIMIT));		
		public static readonly BoolProperty PROPERTY_HASDAYMONTHLIMIT = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_HASDAYMONTHLIMIT));		
		public static readonly IntProperty PROPERTY_PHONELIMITDAYCOUNT = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_PHONELIMITDAYCOUNT));		
		public static readonly IntProperty PROPERTY_PHONELIMITMONTHCOUNT = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_PHONELIMITMONTHCOUNT));		
		public static readonly IntProperty PROPERTY_PHONELIMITTYPE = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_PHONELIMITTYPE));		
		public static readonly BoolProperty PROPERTY_LIMITPROVINCE = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_LIMITPROVINCE));		
		public static readonly StringProperty PROPERTY_LIMITPROVINCEAREA = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_LIMITPROVINCEAREA));		
		public static readonly EntityProperty<SPCodeEntity> PROPERTY_PARENTID = new EntityProperty<SPCodeEntity>(Property.ForName(SPCodeEntity.PROPERTY_NAME_PARENTID));
		public static readonly BoolProperty PROPERTY_ISMATCHCASE = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_ISMATCHCASE));		
		public static readonly BoolProperty PROPERTY_ISDAYTIMELIMIT = new BoolProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_ISDAYTIMELIMIT));		
		public static readonly DateTimeProperty PROPERTY_DAYTIMELIMITRANGESTART = new DateTimeProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_DAYTIMELIMITRANGESTART));		
		public static readonly DateTimeProperty PROPERTY_DAYTIMELIMITRANGEEND = new DateTimeProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_DAYTIMELIMITRANGEEND));		
		public static readonly StringProperty PROPERTY_CHANNELSTATUS = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_CHANNELSTATUS));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SPCodeEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      












		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "Id" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "Id":
                    return typeof (int);
                case "Name":
                    return typeof (string);
                case "Description":
                    return typeof (string);
                case "Code":
                    return typeof (string);
                case "CodeType":
                    return typeof (string);
                case "ChannelID":
                    return typeof (int);
                case "Mo":
                    return typeof (string);
                case "MOType":
                    return typeof (string);
                case "MOLength":
                    return typeof (int);
                case "OrderIndex":
                    return typeof (int);
                case "SPCode":
                    return typeof (string);
                case "SPCodeType":
                    return typeof (string);
                case "SPCodeLength":
                    return typeof (int);
                case "HasFilters":
                    return typeof (bool);
                case "HasParamsConvert":
                    return typeof (bool);
                case "IsDiable":
                    return typeof (bool);
                case "Price":
                    return typeof (decimal);
                case "OperationType":
                    return typeof (string);
                case "HasDayTotalLimit":
                    return typeof (bool);
                case "DayTotalLimitCount":
                    return typeof (int);
                case "HasPhoneLimit":
                    return typeof (bool);
                case "HasDayMonthLimit":
                    return typeof (bool);
                case "PhoneLimitDayCount":
                    return typeof (int);
                case "PhoneLimitMonthCount":
                    return typeof (int);
                case "PhoneLimitType":
                    return typeof (int);
                case "LimitProvince":
                    return typeof (bool);
                case "LimitProvinceArea":
                    return typeof (string);
                case "ParentID":
                    return typeof (int);
                case "IsMatchCase":
                    return typeof (bool);
                case "IsDayTimeLimit":
                    return typeof (bool);
                case "DayTimeLimitRangeStart":
                    return typeof (DateTime);
                case "DayTimeLimitRangeEnd":
                    return typeof (DateTime);
                case "ChannelStatus":
                    return typeof (string);
                case "CreateBy":
                    return typeof (int);
                case "CreateAt":
                    return typeof (DateTime);
                case "LastModifyBy":
                    return typeof (int);
                case "LastModifyAt":
                    return typeof (DateTime);
                case "LastModifyComment":
                    return typeof (string);
          }
			return typeof(string);
        }

		#region 获取外键字段类型
		
		public override Type GetFieldTypeByFieldName(string fieldName, string parent_alias)
        {
            switch (parent_alias)
            {
	            case "ChannelID_SPCodeEntity_Alias":
					switch (fieldName)
					{
                		case "ChannelID_SPCodeEntity_Alias.Id":
							return typeof (int);
                		case "ChannelID_SPCodeEntity_Alias.Name":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.Code":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.DataOkMessage":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.DataFailedMessage":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.Description":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.DataAdapterType":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.DataAdapterUrl":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.ChannelType":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.IVRFeeTimeType":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.IVRTimeFormat":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.IsStateReport":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.StateReportType":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.ReportOkMessage":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.ReportFailedMessage":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.StateReportParamName":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.StateReportParamValue":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.RequestTypeParamName":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.RequestTypeParamStateReportValue":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.RequestTypeParamDataReportValue":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.HasFilters":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.IsMonitorRequest":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.IsLogRequest":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.IsParamsConvert":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.IsAutoLinkID":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.AutoLinkIDFields":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.LogRequestType":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.Price":
							return typeof (decimal);
                		case "ChannelID_SPCodeEntity_Alias.DefaultRate":
							return typeof (decimal);
                		case "ChannelID_SPCodeEntity_Alias.ChannelDetailInfo":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.UpperID":
							return typeof (int);
                		case "ChannelID_SPCodeEntity_Alias.ChannelStatus":
							return typeof (string);
                		case "ChannelID_SPCodeEntity_Alias.IsDisable":
							return typeof (bool);
                		case "ChannelID_SPCodeEntity_Alias.CreateBy":
							return typeof (int);
                		case "ChannelID_SPCodeEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "ChannelID_SPCodeEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "ChannelID_SPCodeEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "ChannelID_SPCodeEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
 
                default:
                    break;
            }

            return typeof(string);
        }
		
		#endregion

        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SPCodeEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "ChannelID_SPCodeEntity_Alias":
                    queryGenerator.AddAlians(SPCodeEntity.PROPERTY_NAME_CHANNELID, PROPERTY_CHANNELID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
        }
		
		
		
		public List<SPCodeEntity> GetList_By_ChannelID_SPChannelEntity(SPChannelEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPCodeEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPCodeEntity> GetPageList_By_ChannelID_SPChannelEntity(string orderByColumnName, bool isDesc, SPChannelEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPCodeEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
