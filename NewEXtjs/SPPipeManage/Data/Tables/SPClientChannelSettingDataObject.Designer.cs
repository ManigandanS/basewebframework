// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using LD.SPPipeManage.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace LD.SPPipeManage.Data.Tables
{
    public partial class SPClientChannelSettingDataObject : BaseNHibernateDataObject<SPClientChannelSettingEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_ID = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_ID);
		public static readonly Property PROPERTY_NAME = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_NAME);
		public static readonly Property PROPERTY_DESCRIPTION = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_DESCRIPTION);
		public static readonly Property PROPERTY_CHANNELID = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_CHANNELID);
		#region channelID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> InClude_ChannelID_Query(NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPClientChannelSettingEntity.PROPERTY_NAME_CHANNELID, PROPERTY_CHANNELID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CHANNELID_ALIAS_NAME = "ChannelID_SPClientChannelSettingEntity_Alias";
		public static readonly Property PROPERTY_CHANNELID_ID = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Id");
		public static readonly Property PROPERTY_CHANNELID_NAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Name");
		public static readonly Property PROPERTY_CHANNELID_DESCRIPTION = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Description");
		public static readonly Property PROPERTY_CHANNELID_AREA = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Area");
		public static readonly Property PROPERTY_CHANNELID_OPERATOR = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Operator");
		public static readonly Property PROPERTY_CHANNELID_CHANNELCODE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelCode");
		public static readonly Property PROPERTY_CHANNELID_FUZZYCOMMAND = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".FuzzyCommand");
		public static readonly Property PROPERTY_CHANNELID_ACCURATECOMMAND = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".AccurateCommand");
		public static readonly Property PROPERTY_CHANNELID_PORT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Port");
		public static readonly Property PROPERTY_CHANNELID_CHANNELTYPE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelType");
		public static readonly Property PROPERTY_CHANNELID_PRICE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Price");
		public static readonly Property PROPERTY_CHANNELID_RATE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Rate");
		public static readonly Property PROPERTY_CHANNELID_STATUS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".Status");
		public static readonly Property PROPERTY_CHANNELID_CREATETIME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".CreateTime");
		public static readonly Property PROPERTY_CHANNELID_CREATEBY = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".CreateBy");
		public static readonly Property PROPERTY_CHANNELID_OKMESSAGE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".OkMessage");
		public static readonly Property PROPERTY_CHANNELID_FAILEDMESSAGE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".FailedMessage");
		public static readonly Property PROPERTY_CHANNELID_UPERID = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".UperID");
		public static readonly Property PROPERTY_CHANNELID_CHANNELCODEPARAMSNAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelCodeParamsName");
		public static readonly Property PROPERTY_CHANNELID_ISALLOWNULLLINKID = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsAllowNullLinkID");
		public static readonly Property PROPERTY_CHANNELID_RECSTATREPORT = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RecStatReport");
		public static readonly Property PROPERTY_CHANNELID_STATPARAMSNAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StatParamsName");
		public static readonly Property PROPERTY_CHANNELID_STATPARAMSVALUES = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StatParamsValues");
		public static readonly Property PROPERTY_CHANNELID_HASREQUESTTYPEPARAMS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".HasRequestTypeParams");
		public static readonly Property PROPERTY_CHANNELID_REQUESTTYPEPARAMNAME = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeParamName");
		public static readonly Property PROPERTY_CHANNELID_REQUESTTYPEVALUES = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".RequestTypeValues");
		public static readonly Property PROPERTY_CHANNELID_HASFILTERS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".HasFilters");
		public static readonly Property PROPERTY_CHANNELID_CHANNELINFO = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChannelInfo");
		public static readonly Property PROPERTY_CHANNELID_STATSENDONCE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".StatSendOnce");
		public static readonly Property PROPERTY_CHANNELID_ISMONITORINGREQUEST = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsMonitoringRequest");
		#endregion
		public static readonly Property PROPERTY_CLINETID = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_CLINETID);
		#region clinetID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> InClude_ClinetID_Query(NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPClientChannelSettingEntity.PROPERTY_NAME_CLINETID, PROPERTY_CLINETID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CLINETID_ALIAS_NAME = "ClinetID_SPClientChannelSettingEntity_Alias";
		public static readonly Property PROPERTY_CLINETID_ID = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".Id");
		public static readonly Property PROPERTY_CLINETID_NAME = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".Name");
		public static readonly Property PROPERTY_CLINETID_DESCRIPTION = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".Description");
		public static readonly Property PROPERTY_CLINETID_RECIEVEDATAURL = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".RecieveDataUrl");
		public static readonly Property PROPERTY_CLINETID_USERID = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".UserID");
		public static readonly Property PROPERTY_CLINETID_SYNCDATA = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".SyncData");
		public static readonly Property PROPERTY_CLINETID_OKMESSAGE = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".OkMessage");
		public static readonly Property PROPERTY_CLINETID_FAILEDMESSAGE = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".FailedMessage");
		public static readonly Property PROPERTY_CLINETID_SYNCTYPE = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".SyncType");
		public static readonly Property PROPERTY_CLINETID_SPCLIENTGROUPID = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".SPClientGroupID");
		public static readonly Property PROPERTY_CLINETID_ISDEFAULTCLIENT = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".IsDefaultClient");
		public static readonly Property PROPERTY_CLINETID_ALIAS = Property.ForName(PROPERTY_CLINETID_ALIAS_NAME + ".Alias");
		#endregion
		public static readonly Property PROPERTY_INTERCEPTRATE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_INTERCEPTRATE);
		public static readonly Property PROPERTY_UPRATE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_UPRATE);
		public static readonly Property PROPERTY_DOWNRATE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_DOWNRATE);
		public static readonly Property PROPERTY_COMMANDTYPE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_COMMANDTYPE);
		public static readonly Property PROPERTY_COMMANDCODE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_COMMANDCODE);
		public static readonly Property PROPERTY_DISABLE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_DISABLE);
		public static readonly Property PROPERTY_COMMANDCOLUMN = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_COMMANDCOLUMN);
		public static readonly Property PROPERTY_INTERCEPTRATETYPE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_INTERCEPTRATETYPE);
		public static readonly Property PROPERTY_SYNCDATA = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_SYNCDATA);
		public static readonly Property PROPERTY_SYNCDATAURL = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_SYNCDATAURL);
		public static readonly Property PROPERTY_OKMESSAGE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_OKMESSAGE);
		public static readonly Property PROPERTY_FAILEDMESSAGE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_FAILEDMESSAGE);
		public static readonly Property PROPERTY_SYNCTYPE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_SYNCTYPE);
		public static readonly Property PROPERTY_ORDERINDEX = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_ORDERINDEX);
		public static readonly Property PROPERTY_CHANNELCODE = Property.ForName(SPClientChannelSettingEntity.PROPERTY_NAME_CHANNELCODE);
      
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
                case "ChannelID":
                    return typeof (int);
                case "ClinetID":
                    return typeof (int);
                case "InterceptRate":
                    return typeof (int);
                case "UpRate":
                    return typeof (int);
                case "DownRate":
                    return typeof (int);
                case "CommandType":
                    return typeof (string);
                case "CommandCode":
                    return typeof (string);
                case "Disable":
                    return typeof (bool);
                case "CommandColumn":
                    return typeof (string);
                case "InterceptRateType":
                    return typeof (string);
                case "SyncData":
                    return typeof (bool);
                case "SyncDataUrl":
                    return typeof (string);
                case "OkMessage":
                    return typeof (string);
                case "FailedMessage":
                    return typeof (string);
                case "SyncType":
                    return typeof (string);
                case "OrderIndex":
                    return typeof (int);
                case "ChannelCode":
                    return typeof (string);
          }
			return typeof(string);
        }
		
		public List<SPClientChannelSettingEntity> GetList_By_ChannelID_SPChannelEntity(SPChannelEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPClientChannelSettingEntity> GetPageList_By_ChannelID_SPChannelEntity(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, SPChannelEntity fkentity, out int recordCount)
        {
            NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            dynamicQueryGenerator.SetFirstResult((pageIndex - 1) * pageSize);

            dynamicQueryGenerator.SetMaxResults(pageSize);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, out recordCount);
        }		
		
		public List<SPClientChannelSettingEntity> GetList_By_ClinetID_SPClientEntity(SPClientEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CLINETID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPClientChannelSettingEntity> GetPageList_By_ClinetID_SPClientEntity(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, SPClientEntity fkentity, out int recordCount)
        {
            NHibernateDynamicQueryGenerator<SPClientChannelSettingEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CLINETID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            dynamicQueryGenerator.SetFirstResult((pageIndex - 1) * pageSize);

            dynamicQueryGenerator.SetMaxResults(pageSize);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, out recordCount);
        }		
		

		
		
    }
}
