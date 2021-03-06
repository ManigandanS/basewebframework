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
    public partial class SPSStatePaymentInfoDataObject : BaseNHibernateDataObject<SPSStatePaymentInfoEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_ID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_ID);
		public static readonly Property PROPERTY_MOBILENUMBER = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_MOBILENUMBER);
		public static readonly Property PROPERTY_CHANNELID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CHANNELID);
		public static readonly Property PROPERTY_CLIENTID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CLIENTID);
		public static readonly Property PROPERTY_MESSAGE = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_MESSAGE);
		public static readonly Property PROPERTY_ISINTERCEPT = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_ISINTERCEPT);
		public static readonly Property PROPERTY_CREATEDATE = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CREATEDATE);
		public static readonly Property PROPERTY_CLIENTGROUPID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CLIENTGROUPID);
		public static readonly Property PROPERTY_CPID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CPID);
		public static readonly Property PROPERTY_MID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_MID);
		public static readonly Property PROPERTY_PORT = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_PORT);
		public static readonly Property PROPERTY_YWID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_YWID);
		public static readonly Property PROPERTY_LINKID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_LINKID);
		public static readonly Property PROPERTY_DEST = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_DEST);
		public static readonly Property PROPERTY_PRICE = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_PRICE);
		public static readonly Property PROPERTY_IP = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_IP);
		public static readonly Property PROPERTY_SUCESSSTOSEND = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_SUCESSSTOSEND);
		public static readonly Property PROPERTY_EXTENDFIELD1 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD1);
		public static readonly Property PROPERTY_EXTENDFIELD2 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD2);
		public static readonly Property PROPERTY_EXTENDFIELD3 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD3);
		public static readonly Property PROPERTY_EXTENDFIELD4 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD4);
		public static readonly Property PROPERTY_EXTENDFIELD5 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD5);
		public static readonly Property PROPERTY_EXTENDFIELD6 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD6);
		public static readonly Property PROPERTY_EXTENDFIELD7 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD7);
		public static readonly Property PROPERTY_EXTENDFIELD8 = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_EXTENDFIELD8);
		public static readonly Property PROPERTY_MOBILEOPERATORS = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_MOBILEOPERATORS);
		public static readonly Property PROPERTY_REQUESTCONTENT = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_REQUESTCONTENT);
		public static readonly Property PROPERTY_CITY = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CITY);
		public static readonly Property PROPERTY_PROVINCE = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_PROVINCE);
		public static readonly Property PROPERTY_ISTESTDATA = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_ISTESTDATA);
		public static readonly Property PROPERTY_CHANNLECLIENTID = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_CHANNLECLIENTID);
		public static readonly Property PROPERTY_ISSYCNDATA = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_ISSYCNDATA);
		public static readonly Property PROPERTY_SSYCNDATAURL = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_SSYCNDATAURL);
		public static readonly Property PROPERTY_SYCNRETRYTIMES = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_SYCNRETRYTIMES);
		public static readonly Property PROPERTY_ISREPORT = Property.ForName(SPSStatePaymentInfoEntity.PROPERTY_NAME_ISREPORT);
      
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
                case "ClientGroupID":
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
                case "MobileOperators":
                    return typeof (string);
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
                case "IsReport":
                    return typeof (bool);
          }
			return typeof(string);
        }
		
		
		
		
		
    }
}
