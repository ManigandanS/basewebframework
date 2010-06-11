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
		#endregion
		public static readonly Property PROPERTY_MESSAGE = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_MESSAGE);
		public static readonly Property PROPERTY_ISINTERCEPT = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_ISINTERCEPT);
		public static readonly Property PROPERTY_CREATEDATE = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CREATEDATE);
		public static readonly Property PROPERTY_REQUESTID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_REQUESTID);
		public static readonly Property PROPERTY_CPID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_CPID);
		public static readonly Property PROPERTY_MID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_MID);
		public static readonly Property PROPERTY_PORT = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_PORT);
		public static readonly Property PROPERTY_YWID = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_YWID);
		public static readonly Property PROPERTY_IP = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_IP);
		public static readonly Property PROPERTY_SUCESSSTOSEND = Property.ForName(SPPaymentInfoEntity.PROPERTY_NAME_SUCESSSTOSEND);
      
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
                case "Ip":
                    return typeof (string);
                case "SucesssToSend":
                    return typeof (bool);
          }
			return typeof(string);
        }
    }
}
