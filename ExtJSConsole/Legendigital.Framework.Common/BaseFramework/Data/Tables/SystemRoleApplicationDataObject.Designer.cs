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
    public partial class SystemRoleApplicationDataObject : BaseNHibernateDataObject<SystemRoleApplicationEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_SYSTEMROLEAPPLICATIONID = Property.ForName(SystemRoleApplicationEntity.PROPERTY_NAME_SYSTEMROLEAPPLICATIONID);
		public static readonly Property PROPERTY_ROLEID = Property.ForName(SystemRoleApplicationEntity.PROPERTY_NAME_ROLEID);
		#region roleID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemRoleApplicationEntity> InClude_RoleID_Query(NHibernateDynamicQueryGenerator<SystemRoleApplicationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemRoleApplicationEntity.PROPERTY_NAME_ROLEID, PROPERTY_ROLEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_ROLEID_ALIAS_NAME = "RoleID_SystemRoleApplicationEntity_Alias";
		public static readonly Property PROPERTY_ROLEID_ROLEID = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleID");
		public static readonly Property PROPERTY_ROLEID_ROLENAME = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleName");
		public static readonly Property PROPERTY_ROLEID_ROLEDESCRIPTION = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleDescription");
		public static readonly Property PROPERTY_ROLEID_ROLEISSYSTEMROLE = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleIsSystemRole");
		#endregion
		public static readonly Property PROPERTY_APPLICATIONID = Property.ForName(SystemRoleApplicationEntity.PROPERTY_NAME_APPLICATIONID);
		#region applicationID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemRoleApplicationEntity> InClude_ApplicationID_Query(NHibernateDynamicQueryGenerator<SystemRoleApplicationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemRoleApplicationEntity.PROPERTY_NAME_APPLICATIONID, PROPERTY_APPLICATIONID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_APPLICATIONID_ALIAS_NAME = "ApplicationID_SystemRoleApplicationEntity_Alias";
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONID = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationID");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONNAME = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationName");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONDESCRIPTION = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationDescription");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONURL = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationUrl");
		public static readonly Property PROPERTY_APPLICATIONID_SYSTEMAPPLICATIONISSYSTEMAPPLICATION = Property.ForName(PROPERTY_APPLICATIONID_ALIAS_NAME + ".SystemApplicationIsSystemApplication");
		#endregion
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "SystemRoleApplicationID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "SystemRoleApplicationID":
                    return typeof (int);
                case "RoleID":
                    return typeof (int);
                case "ApplicationID":
                    return typeof (int);
          }
			return typeof(string);
        }
    }
}
