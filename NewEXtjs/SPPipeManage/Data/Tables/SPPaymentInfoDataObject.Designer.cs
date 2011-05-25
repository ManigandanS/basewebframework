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
    public partial class SPPaymentInfoDataObject : BaseNHibernateDataObject<SPPaymentInfoEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_ID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_ID);
		public static readonly Property PROPERTY_MOBILENUMBER = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_MOBILENUMBER);
		public static readonly Property PROPERTY_CHANNELID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CHANNELID);
		#region channelID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> InClude_ChannelID_Query(NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPPaymentInfoEntity.PROPERTY_NAME_CHANNELID, PROPERTY_CHANNELID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CHANNELID_ALIAS_NAME = "ChannelID_SPPaymentInfoEntity_Alias";
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
		public static readonly Property PROPERTY_CHANNELID_ISDISABLE = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".IsDisable");
		public static readonly Property PROPERTY_CHANNELID_REPORTIDPARAMS = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ReportIDParams");
		public static readonly Property PROPERTY_CHANNELID_CHANNEDATA = Property.ForName(PROPERTY_CHANNELID_ALIAS_NAME + ".ChanneData");
		#endregion
		public static readonly Property PROPERTY_CLIENTID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CLIENTID);
		#region clientID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> InClude_ClientID_Query(NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPPaymentInfoEntity.PROPERTY_NAME_CLIENTID, PROPERTY_CLIENTID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CLIENTID_ALIAS_NAME = "ClientID_SPPaymentInfoEntity_Alias";
		public static readonly Property PROPERTY_CLIENTID_ID = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Id");
		public static readonly Property PROPERTY_CLIENTID_NAME = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Name");
		public static readonly Property PROPERTY_CLIENTID_DESCRIPTION = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Description");
		public static readonly Property PROPERTY_CLIENTID_RECIEVEDATAURL = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".RecieveDataUrl");
		public static readonly Property PROPERTY_CLIENTID_USERID = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".UserID");
		public static readonly Property PROPERTY_CLIENTID_SYNCDATA = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SyncData");
		public static readonly Property PROPERTY_CLIENTID_OKMESSAGE = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".OkMessage");
		public static readonly Property PROPERTY_CLIENTID_FAILEDMESSAGE = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".FailedMessage");
		public static readonly Property PROPERTY_CLIENTID_SYNCTYPE = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SyncType");
		public static readonly Property PROPERTY_CLIENTID_SPCLIENTGROUPID = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".SPClientGroupID");
		public static readonly Property PROPERTY_CLIENTID_ISDEFAULTCLIENT = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".IsDefaultClient");
		public static readonly Property PROPERTY_CLIENTID_ALIAS = Property.ForName(PROPERTY_CLIENTID_ALIAS_NAME + ".Alias");
		#endregion
		public static readonly Property PROPERTY_MESSAGE = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_MESSAGE);
		public static readonly Property PROPERTY_ISINTERCEPT = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_ISINTERCEPT);
		public static readonly Property PROPERTY_CREATEDATE = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CREATEDATE);
		public static readonly Property PROPERTY_REQUESTID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_REQUESTID);
		public static readonly Property PROPERTY_CPID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CPID);
		public static readonly Property PROPERTY_MID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_MID);
		public static readonly Property PROPERTY_PORT = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_PORT);
		public static readonly Property PROPERTY_YWID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_YWID);
		public static readonly Property PROPERTY_LINKID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_LINKID);
		public static readonly Property PROPERTY_DEST = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_DEST);
		public static readonly Property PROPERTY_PRICE = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_PRICE);
		public static readonly Property PROPERTY_IP = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_IP);
		public static readonly Property PROPERTY_SUCESSSTOSEND = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_SUCESSSTOSEND);
		public static readonly Property PROPERTY_EXTENDFIELD1 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD1);
		public static readonly Property PROPERTY_EXTENDFIELD2 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD2);
		public static readonly Property PROPERTY_EXTENDFIELD3 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD3);
		public static readonly Property PROPERTY_EXTENDFIELD4 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD4);
		public static readonly Property PROPERTY_EXTENDFIELD5 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD5);
		public static readonly Property PROPERTY_EXTENDFIELD6 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD6);
		public static readonly Property PROPERTY_EXTENDFIELD7 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD7);
		public static readonly Property PROPERTY_EXTENDFIELD8 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD8);
		public static readonly Property PROPERTY_EXTENDFIELD9 = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD9);
		public static readonly Property PROPERTY_ISREPORT = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_ISREPORT);
		public static readonly Property PROPERTY_REQUESTCONTENT = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_REQUESTCONTENT);
		public static readonly Property PROPERTY_CITY = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CITY);
		public static readonly Property PROPERTY_PROVINCE = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_PROVINCE);
		public static readonly Property PROPERTY_ISTESTDATA = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_ISTESTDATA);
		public static readonly Property PROPERTY_CHANNLECLIENTID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CHANNLECLIENTID);
		public static readonly Property PROPERTY_ISSYCNDATA = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_ISSYCNDATA);
		public static readonly Property PROPERTY_SSYCNDATAURL = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_SSYCNDATAURL);
		public static readonly Property PROPERTY_SYCNRETRYTIMES = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_SYCNRETRYTIMES);
      
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
                case "MobileNumber":
                    return typeof (string);
                case "ChannelID":
                    return typeof (int);
                case "ClientID":
                    return typeof (int);
                case "Message":
                    return typeof (string);
                case "IsIntercept":
                    return typeof (bool);
                case "CreateDate":
                    return typeof (DateTime);
                case "RequestID":
                    return typeof (int);
                case "Cpid":
                    return typeof (string);
                case "Mid":
                    return typeof (string);
                case "Port":
                    return typeof (string);
                case "Ywid":
                    return typeof (string);
                case "Linkid":
                    return typeof (string);
                case "Dest":
                    return typeof (string);
                case "Price":
                    return typeof (string);
                case "Ip":
                    return typeof (string);
                case "SucesssToSend":
                    return typeof (bool);
                case "ExtendField1":
                    return typeof (string);
                case "ExtendField2":
                    return typeof (string);
                case "ExtendField3":
                    return typeof (string);
                case "ExtendField4":
                    return typeof (string);
                case "ExtendField5":
                    return typeof (string);
                case "ExtendField6":
                    return typeof (string);
                case "ExtendField7":
                    return typeof (string);
                case "ExtendField8":
                    return typeof (string);
                case "ExtendField9":
                    return typeof (string);
                case "IsReport":
                    return typeof (bool);
                case "RequestContent":
                    return typeof (string);
                case "City":
                    return typeof (string);
                case "Province":
                    return typeof (string);
                case "IsTestData":
                    return typeof (bool);
                case "ChannleClientID":
                    return typeof (int);
                case "IsSycnData":
                    return typeof (bool);
                case "SSycnDataUrl":
                    return typeof (string);
                case "SycnRetryTimes":
                    return typeof (int);
          }
			return typeof(string);
        }
		
				public List<SPPaymentInfoEntity> GetList_By_SPChannelEntity(SPChannelEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPPaymentInfoEntity> GetPageList_By_SPChannelEntity(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, SPChannelEntity fkentity, out int recordCount)
        {
            NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CHANNELID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            dynamicQueryGenerator.SetFirstResult((pageIndex - 1) * pageSize);

            dynamicQueryGenerator.SetMaxResults(pageSize);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, out recordCount);
        }		
		
		public List<SPPaymentInfoEntity> GetList_By_SPClientEntity(SPClientEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CLIENTID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPPaymentInfoEntity> GetPageList_By_SPClientEntity(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, SPClientEntity fkentity, out int recordCount)
        {
            NHibernateDynamicQueryGenerator<SPPaymentInfoEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CLIENTID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            dynamicQueryGenerator.SetFirstResult((pageIndex - 1) * pageSize);

            dynamicQueryGenerator.SetMaxResults(pageSize);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, out recordCount);
        }		
		

		
		
		
    }
}
