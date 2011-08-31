// Generated by MyGeneration Version # (1.3.0.9)
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
    public partial class SPDayReportDataObject : BaseNHibernateDataObject<SPDayReportEntity>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SPDayReportEntity.PROPERTY_NAME_ID));		
		public static readonly DateTimeProperty PROPERTY_REPORTDATE = new DateTimeProperty(Property.ForName(SPDayReportEntity.PROPERTY_NAME_REPORTDATE));		
		public static readonly IntProperty PROPERTY_TOTALCOUNT = new IntProperty(Property.ForName(SPDayReportEntity.PROPERTY_NAME_TOTALCOUNT));		
		public static readonly IntProperty PROPERTY_INTERCEPTCOUNT = new IntProperty(Property.ForName(SPDayReportEntity.PROPERTY_NAME_INTERCEPTCOUNT));		
		public static readonly IntProperty PROPERTY_DOWNTOTALCOUNT = new IntProperty(Property.ForName(SPDayReportEntity.PROPERTY_NAME_DOWNTOTALCOUNT));		
		public static readonly IntProperty PROPERTY_DOWNSUCCESS = new IntProperty(Property.ForName(SPDayReportEntity.PROPERTY_NAME_DOWNSUCCESS));		
		public static readonly EntityProperty<SPSClientEntity> PROPERTY_CLIENTID = new EntityProperty<SPSClientEntity>(Property.ForName(SPDayReportEntity.PROPERTY_NAME_CLIENTID));
		#region clientID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPDayReportEntity> InClude_ClientID_Query(NHibernateDynamicQueryGenerator<SPDayReportEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPDayReportEntity.PROPERTY_NAME_CLIENTID, PROPERTY_CLIENTID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CLIENTID_ALIAS_NAME = "ClientID_SPDayReportEntity_Alias";
		public static readonly IntProperty PROPERTY_CLIENTID_ID = new IntProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Id"));
		public static readonly StringProperty PROPERTY_CLIENTID_NAME = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_CLIENTID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Description"));
		public static readonly IntProperty PROPERTY_CLIENTID_USERID = new IntProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".UserID"));
		public static readonly BoolProperty PROPERTY_CLIENTID_ISDEFAULTCLIENT = new BoolProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".IsDefaultClient"));
		public static readonly BoolProperty PROPERTY_CLIENTID_SYNCDATA = new BoolProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SyncData"));
		public static readonly BoolProperty PROPERTY_CLIENTID_SYCNRESENDFAILEDDATA = new BoolProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SycnResendFailedData"));
		public static readonly IntProperty PROPERTY_CLIENTID_SYCNRETRYTIMES = new IntProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SycnRetryTimes"));
		public static readonly StringProperty PROPERTY_CLIENTID_SYNCTYPE = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SyncType"));
		public static readonly StringProperty PROPERTY_CLIENTID_SYCNDATAURL = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SycnDataUrl"));
		public static readonly StringProperty PROPERTY_CLIENTID_SYCNOKMESSAGE = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SycnOkMessage"));
		public static readonly StringProperty PROPERTY_CLIENTID_SYCNFAILEDMESSAGE = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SycnFailedMessage"));
		public static readonly StringProperty PROPERTY_CLIENTID_ALIAS = new StringProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Alias"));
		public static readonly DecimalProperty PROPERTY_CLIENTID_INTERCEPTRATE = new DecimalProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".InterceptRate"));
		public static readonly DecimalProperty PROPERTY_CLIENTID_DEFAULTPRICE = new DecimalProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".DefaultPrice"));
		public static readonly IntProperty PROPERTY_CLIENTID_DEFAULTSHOWRECORDDAYS = new IntProperty(Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".DefaultShowRecordDays"));
		#endregion
		public static readonly EntityProperty<SPChannelEntity> PROPERTY_CHANNELID = new EntityProperty<SPChannelEntity>(Property.ForName(SPDayReportEntity.PROPERTY_NAME_CHANNELID));
		#region channelID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPDayReportEntity> InClude_ChannelID_Query(NHibernateDynamicQueryGenerator<SPDayReportEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPDayReportEntity.PROPERTY_NAME_CHANNELID, PROPERTY_CHANNELID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CHANNELID_ALIAS_NAME = "ChannelID_SPDayReportEntity_Alias";
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
		#endregion
		public static readonly EntityProperty<SPCodeEntity> PROPERTY_CODEID = new EntityProperty<SPCodeEntity>(Property.ForName(SPDayReportEntity.PROPERTY_NAME_CODEID));
		#region codeID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPDayReportEntity> InClude_CodeID_Query(NHibernateDynamicQueryGenerator<SPDayReportEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPDayReportEntity.PROPERTY_NAME_CODEID, PROPERTY_CODEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CODEID_ALIAS_NAME = "CodeID_SPDayReportEntity_Alias";
		public static readonly IntProperty PROPERTY_CODEID_ID = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Id"));
		public static readonly StringProperty PROPERTY_CODEID_NAME = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_CODEID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Description"));
		public static readonly StringProperty PROPERTY_CODEID_CODE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Code"));
		public static readonly IntProperty PROPERTY_CODEID_CHANNELID = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".ChannelID"));
		public static readonly StringProperty PROPERTY_CODEID_MO = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Mo"));
		public static readonly StringProperty PROPERTY_CODEID_MOTYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".MOType"));
		public static readonly IntProperty PROPERTY_CODEID_ORDERINDEX = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".OrderIndex"));
		public static readonly StringProperty PROPERTY_CODEID_SPCODE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPCode"));
		public static readonly StringProperty PROPERTY_CODEID_PROVINCE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Province"));
		public static readonly StringProperty PROPERTY_CODEID_DISABLECITY = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".DisableCity"));
		public static readonly BoolProperty PROPERTY_CODEID_ISDIABLE = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".IsDiable"));
		public static readonly StringProperty PROPERTY_CODEID_SPTYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPType"));
		public static readonly IntProperty PROPERTY_CODEID_CODELENGTH = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".CodeLength"));
		public static readonly IntProperty PROPERTY_CODEID_DAYLIMIT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".DayLimit"));
		public static readonly IntProperty PROPERTY_CODEID_MONTHLIMIT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".MonthLimit"));
		public static readonly DecimalProperty PROPERTY_CODEID_PRICE = new DecimalProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Price"));
		public static readonly StringProperty PROPERTY_CODEID_SENDTEXT = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SendText"));
		public static readonly BoolProperty PROPERTY_CODEID_HASFILTERS = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".HasFilters"));
		#endregion
		public static readonly EntityProperty<SPUpperEntity> PROPERTY_UPERID = new EntityProperty<SPUpperEntity>(Property.ForName(SPDayReportEntity.PROPERTY_NAME_UPERID));
		#region uperID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPDayReportEntity> InClude_UperID_Query(NHibernateDynamicQueryGenerator<SPDayReportEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPDayReportEntity.PROPERTY_NAME_UPERID, PROPERTY_UPERID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_UPERID_ALIAS_NAME = "UperID_SPDayReportEntity_Alias";
		public static readonly IntProperty PROPERTY_UPERID_ID = new IntProperty(Property.ForName(PROPERTY_UPERID_ALIAS_NAME + ".Id"));
		public static readonly StringProperty PROPERTY_UPERID_NAME = new StringProperty(Property.ForName(PROPERTY_UPERID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_UPERID_CODE = new StringProperty(Property.ForName(PROPERTY_UPERID_ALIAS_NAME + ".Code"));
		public static readonly StringProperty PROPERTY_UPERID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_UPERID_ALIAS_NAME + ".Description"));
		public static readonly DateTimeProperty PROPERTY_UPERID_CREATEDATE = new DateTimeProperty(Property.ForName(PROPERTY_UPERID_ALIAS_NAME + ".CreateDate"));
		#endregion
      
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
                case "ReportDate":
                    return typeof (DateTime);
                case "TotalCount":
                    return typeof (int);
                case "InterceptCount":
                    return typeof (int);
                case "DownTotalCount":
                    return typeof (int);
                case "DownSuccess":
                    return typeof (int);
                case "ClientID":
                    return typeof (int);
                case "ChannelID":
                    return typeof (int);
                case "CodeID":
                    return typeof (int);
                case "UperID":
                    return typeof (int);
          }
			return typeof(string);
        }
		
		public List<SPDayReportEntity> GetList_By_ClientID_SPSClientEntity(SPSClientEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CLIENTID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPDayReportEntity> GetPageList_By_ClientID_SPSClientEntity(string orderByColumnName, bool isDesc, SPSClientEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CLIENTID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SPDayReportEntity> GetList_By_ChannelID_SPChannelEntity(SPChannelEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPDayReportEntity> GetPageList_By_ChannelID_SPChannelEntity(string orderByColumnName, bool isDesc, SPChannelEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SPDayReportEntity> GetList_By_CodeID_SPCodeEntity(SPCodeEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CODEID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPDayReportEntity> GetPageList_By_CodeID_SPCodeEntity(string orderByColumnName, bool isDesc, SPCodeEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CODEID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SPDayReportEntity> GetList_By_UperID_SPUpperEntity(SPUpperEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_UPERID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPDayReportEntity> GetPageList_By_UperID_SPUpperEntity(string orderByColumnName, bool isDesc, SPUpperEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPDayReportEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_UPERID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
