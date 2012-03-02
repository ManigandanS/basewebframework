// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace Legendigital.Framework.Common.BaseFramework.Data.Tables
{
    public partial class SystemMoudleDataObject : BaseNHibernateDataObject<SystemMoudleEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_MOUDLEID = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_MOUDLEID);
		public static readonly Property PROPERTY_MOUDLENAMECN = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_MOUDLENAMECN);
		public static readonly Property PROPERTY_MOUDLENAMEEN = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_MOUDLENAMEEN);
		public static readonly Property PROPERTY_MOUDLENAMEDB = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_MOUDLENAMEDB);
		public static readonly Property PROPERTY_MOUDLEDESCRIPTION = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_MOUDLEDESCRIPTION);
		public static readonly Property PROPERTY_APPLICATIONID = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_APPLICATIONID);
		#region applicationID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemMoudleEntity> InClude_ApplicationID_Query(NHibernateDynamicQueryGenerator<SystemMoudleEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemMoudleEntity.PROPERTY_NAME_APPLICATIONID, PROPERTY_APPLICATIONID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_APPLICATIONID_ALIAS_NAME = "ApplicationID_SystemMoudleEntity_Alias";
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONID = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationID");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONNAME = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationName");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONDESCRIPTION = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationDescription");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONURL = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationUrl");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationIsSystemApplication");
		#endregion
		public static readonly Property PROPERTY_MOUDLEISSYSTEMMOUDLE = Property.ForName(SystemMoudleEntity.PROPERTY_NAME_MOUDLEISSYSTEMMOUDLE);
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "MoudleID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "MoudleID":
                    return typeof (int);
                case "MoudleNameCn":
                    return typeof (string);
                case "MoudleNameEn":
                    return typeof (string);
                case "MoudleNameDb":
                    return typeof (string);
                case "MoudleDescription":
                    return typeof (string);
                case "ApplicationID":
                    return typeof (int);
                case "MoudleIsSystemMoudle":
                    return typeof (bool);
          }
			return typeof(string);
        }
    }
}
