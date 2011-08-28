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
    public partial class SPSClientDataObject : BaseNHibernateDataObject<SPSClientEntity>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_ID));		
		public static readonly StringProperty PROPERTY_NAME = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_NAME));		
		public static readonly StringProperty PROPERTY_DESCRIPTION = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_DESCRIPTION));		
		public static readonly IntProperty PROPERTY_USERID = new IntProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_USERID));		
		public static readonly BoolProperty PROPERTY_SYNCDATA = new BoolProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYNCDATA));		
		public static readonly BoolProperty PROPERTY_SYCNRESENDFAILEDDATA = new BoolProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYCNRESENDFAILEDDATA));		
		public static readonly StringProperty PROPERTY_SYCNRETRYTIMES = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYCNRETRYTIMES));		
		public static readonly StringProperty PROPERTY_SYNCTYPE = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYNCTYPE));		
		public static readonly StringProperty PROPERTY_SYCNDATAURL = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYCNDATAURL));		
		public static readonly StringProperty PROPERTY_SYCNOKMESSAGE = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYCNOKMESSAGE));		
		public static readonly StringProperty PROPERTY_SYCNFAILEDMESSAGE = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_SYCNFAILEDMESSAGE));		
		public static readonly StringProperty PROPERTY_ALIAS = new StringProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_ALIAS));		
		public static readonly DecimalProperty PROPERTY_INTERCEPTRATE = new DecimalProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_INTERCEPTRATE));		
		public static readonly DecimalProperty PROPERTY_DEFAULTPRICE = new DecimalProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_DEFAULTPRICE));		
		public static readonly IntProperty PROPERTY_DEFAULTSHOWRECORDDAYS = new IntProperty(Property.ForName(SPSClientEntity.PROPERTY_NAME_DEFAULTSHOWRECORDDAYS));		
      
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
                case "UserID":
                    return typeof (int);
                case "SyncData":
                    return typeof (bool);
                case "SycnResendFailedData":
                    return typeof (bool);
                case "SycnRetryTimes":
                    return typeof (string);
                case "SyncType":
                    return typeof (string);
                case "SycnDataUrl":
                    return typeof (string);
                case "SycnOkMessage":
                    return typeof (string);
                case "SycnFailedMessage":
                    return typeof (string);
                case "Alias":
                    return typeof (string);
                case "InterceptRate":
                    return typeof (decimal);
                case "DefaultPrice":
                    return typeof (decimal);
                case "DefaultShowRecordDays":
                    return typeof (int);
          }
			return typeof(string);
        }
		

		
		
    }
}
