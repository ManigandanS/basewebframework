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
    public partial class SPRequestInfoDataObject : BaseNHibernateDataObject<SPRequestInfoEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_ID = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_ID);
		public static readonly Property PROPERTY_IP = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_IP);
		public static readonly Property PROPERTY_REQUESTINFO = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_REQUESTINFO);
		public static readonly Property PROPERTY_REQUESTDATE = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_REQUESTDATE);
		public static readonly Property PROPERTY_ISTOPAYMENT = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_ISTOPAYMENT);
		public static readonly Property PROPERTY_REQUESTURL = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_REQUESTURL);
		public static readonly Property PROPERTY_DATAID = Property.ForName(SPRequestInfoEntity.PROPERTY_NAME_DATAID);
      
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
                case "Ip":
                    return typeof (string);
                case "RequestInfo":
                    return typeof (string);
                case "RequestDate":
                    return typeof (DateTime);
                case "IsToPayment":
                    return typeof (bool);
                case "RequestUrl":
                    return typeof (string);
                case "DataID":
                    return typeof (int);
          }
			return typeof(string);
        }
		
		
		
		
		
    }
}
