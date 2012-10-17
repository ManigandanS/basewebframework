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
    public partial class SPChannelSycnParamsDataObject : BaseNHibernateDataObject<SPChannelSycnParamsEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_ID = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_ID);
		public static readonly Property PROPERTY_NAME = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_NAME);
		public static readonly Property PROPERTY_DESCRIPTION = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_DESCRIPTION);
		public static readonly Property PROPERTY_ISENABLE = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_ISENABLE);
		public static readonly Property PROPERTY_CHANNELID = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_CHANNELID);
		#region channelID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPChannelSycnParamsEntity> InClude_ChannelID_Query(NHibernateDynamicQueryGenerator<SPChannelSycnParamsEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPChannelSycnParamsEntity.PROPERTY_NAME_CHANNELID, PROPERTY_CHANNELID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CHANNELID_ALIAS_NAME = "ChannelID_SPChannelSycnParamsEntity_Alias";
		public static readonly Property PROPERTY_CHANNELID_ID = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Id");
		public static readonly Property PROPERTY_CHANNELID_NAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Name");
		public static readonly Property PROPERTY_CHANNELID_CODE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Code");
		public static readonly Property PROPERTY_CHANNELID_DATAOKMESSAGE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataOkMessage");
		public static readonly Property PROPERTY_CHANNELID_DATAFAILEDMESSAGE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataFailedMessage");
		public static readonly Property PROPERTY_CHANNELID_DESCRIPTION = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Description");
		public static readonly Property PROPERTY_CHANNELID_DATAADAPTERTYPE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataAdapterType");
		public static readonly Property PROPERTY_CHANNELID_DATAADAPTERURL = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DataAdapterUrl");
		public static readonly Property PROPERTY_CHANNELID_CHANNELTYPE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelType");
		public static readonly Property PROPERTY_CHANNELID_IVRFEETIMETYPE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IVRFeeTimeType");
		public static readonly Property PROPERTY_CHANNELID_IVRTIMEFORMAT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IVRTimeFormat");
		public static readonly Property PROPERTY_CHANNELID_ISSTATEREPORT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsStateReport");
		public static readonly Property PROPERTY_CHANNELID_STATEREPORTTYPE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StateReportType");
		public static readonly Property PROPERTY_CHANNELID_REPORTOKMESSAGE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ReportOkMessage");
		public static readonly Property PROPERTY_CHANNELID_REPORTFAILEDMESSAGE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ReportFailedMessage");
		public static readonly Property PROPERTY_CHANNELID_STATEREPORTPARAMNAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StateReportParamName");
		public static readonly Property PROPERTY_CHANNELID_STATEREPORTPARAMVALUE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StateReportParamValue");
		public static readonly Property PROPERTY_CHANNELID_REQUESTTYPEPARAMNAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamName");
		public static readonly Property PROPERTY_CHANNELID_REQUESTTYPEPARAMSTATEREPORTVALUE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamStateReportValue");
		public static readonly Property PROPERTY_CHANNELID_REQUESTTYPEPARAMDATAREPORTVALUE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamDataReportValue");
		public static readonly Property PROPERTY_CHANNELID_HASFILTERS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".HasFilters");
		public static readonly Property PROPERTY_CHANNELID_ISMONITORREQUEST = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsMonitorRequest");
		public static readonly Property PROPERTY_CHANNELID_ISLOGREQUEST = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsLogRequest");
		public static readonly Property PROPERTY_CHANNELID_ISPARAMSCONVERT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsParamsConvert");
		public static readonly Property PROPERTY_CHANNELID_ISAUTOLINKID = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsAutoLinkID");
		public static readonly Property PROPERTY_CHANNELID_AUTOLINKIDFIELDS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".AutoLinkIDFields");
		public static readonly Property PROPERTY_CHANNELID_LOGREQUESTTYPE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LogRequestType");
		public static readonly Property PROPERTY_CHANNELID_PRICE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Price");
		public static readonly Property PROPERTY_CHANNELID_DEFAULTRATE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".DefaultRate");
		public static readonly Property PROPERTY_CHANNELID_CHANNELDETAILINFO = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelDetailInfo");
		public static readonly Property PROPERTY_CHANNELID_UPPERID = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".UpperID");
		public static readonly Property PROPERTY_CHANNELID_CHANNELSTATUS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelStatus");
		public static readonly Property PROPERTY_CHANNELID_ISDISABLE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsDisable");
		public static readonly Property PROPERTY_CHANNELID_CREATEBY = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".CreateBy");
		public static readonly Property PROPERTY_CHANNELID_CREATEAT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".CreateAt");
		public static readonly Property PROPERTY_CHANNELID_LASTMODIFYBY = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LastModifyBy");
		public static readonly Property PROPERTY_CHANNELID_LASTMODIFYAT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LastModifyAt");
		public static readonly Property PROPERTY_CHANNELID_LASTMODIFYCOMMENT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".LastModifyComment");
		#endregion
		public static readonly Property PROPERTY_MAPPINGPARAMS = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_MAPPINGPARAMS);
		public static readonly Property PROPERTY_TITLE = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_TITLE);
		public static readonly Property PROPERTY_PARAMSVALUE = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_PARAMSVALUE);
		public static readonly Property PROPERTY_PARAMSTYPE = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_PARAMSTYPE);
		public static readonly Property PROPERTY_CREATEBY = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_CREATEBY);
		public static readonly Property PROPERTY_CREATEAT = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_CREATEAT);
		public static readonly Property PROPERTY_LASTMODIFYBY = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_LASTMODIFYBY);
		public static readonly Property PROPERTY_LASTMODIFYAT = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_LASTMODIFYAT);
		public static readonly Property PROPERTY_LASTMODIFYCOMMENT = Property.ForName(SPChannelSycnParamsEntity.PROPERTY_NAME_LASTMODIFYCOMMENT);
      
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
                case "IsEnable":
                    return typeof (bool);
                case "ChannelID":
                    return typeof (int);
                case "MappingParams":
                    return typeof (string);
                case "Title":
                    return typeof (string);
                case "ParamsValue":
                    return typeof (string);
                case "ParamsType":
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
		
				public List<SPChannelSycnParamsEntity> GetList_By_SPChannelEntity(SPChannelEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPChannelSycnParamsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPChannelSycnParamsEntity> GetPageList_By_SPChannelEntity(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, SPChannelEntity fkentity, out int recordCount)
        {
            NHibernateDynamicQueryGenerator<SPChannelSycnParamsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            dynamicQueryGenerator.SetFirstResult((pageIndex - 1) * pageSize);

            dynamicQueryGenerator.SetMaxResults(pageSize);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, out recordCount);
        }		
		

		
		
		
    }
}
