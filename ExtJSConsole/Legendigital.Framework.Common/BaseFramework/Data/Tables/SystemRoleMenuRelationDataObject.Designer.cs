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
    public partial class SystemRoleMenuRelationDataObject : BaseNHibernateDataObject<SystemRoleMenuRelationEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_MENUROLEID = Property.ForName(SystemRoleMenuRelationEntity.PROPERTY_NAME_MENUROLEID);
		public static readonly Property PROPERTY_MENUID = Property.ForName(SystemRoleMenuRelationEntity.PROPERTY_NAME_MENUID);
		#region menuID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> InClude_MenuID_Query(NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemRoleMenuRelationEntity.PROPERTY_NAME_MENUID, PROPERTY_MENUID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_MENUID_ALIAS_NAME = "MenuID_SystemRoleMenuRelationEntity_Alias";
		public static readonly Property PROPERTY_MENUID_MENUID = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuID");
		public static readonly Property PROPERTY_MENUID_MENUNAME = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuName");
		public static readonly Property PROPERTY_MENUID_MENUDESCRIPTION = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuDescription");
		public static readonly Property PROPERTY_MENUID_MENUURL = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuUrl");
		public static readonly Property PROPERTY_MENUID_MENUURLTARGET = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuUrlTarget");
		public static readonly Property PROPERTY_MENUID_MENUICONURL = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIconUrl");
		public static readonly Property PROPERTY_MENUID_MENUISCATEGORY = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIsCategory");
		public static readonly Property PROPERTY_MENUID_PARENTMENUID = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".ParentMenuID");
		public static readonly Property PROPERTY_MENUID_MENUORDER = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuOrder");
		public static readonly Property PROPERTY_MENUID_MENUTYPE = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuType");
		public static readonly Property PROPERTY_MENUID_MENUISSYSTEMMENU = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIsSystemMenu");
		public static readonly Property PROPERTY_MENUID_MENUISENABLE = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".MenuIsEnable");
		public static readonly Property PROPERTY_MENUID_APPLICATIONID = Property.ForName(PROPERTY_MENUID_ALIAS_NAME + ".ApplicationID");
		#endregion
		public static readonly Property PROPERTY_ROLEID = Property.ForName(SystemRoleMenuRelationEntity.PROPERTY_NAME_ROLEID);
		#region roleID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> InClude_RoleID_Query(NHibernateDynamicQueryGenerator<SystemRoleMenuRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemRoleMenuRelationEntity.PROPERTY_NAME_ROLEID, PROPERTY_ROLEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_ROLEID_ALIAS_NAME = "RoleID_SystemRoleMenuRelationEntity_Alias";
		public static readonly Property PROPERTY_ROLEID_ROLEID = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleID");
		public static readonly Property PROPERTY_ROLEID_ROLENAME = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleName");
		public static readonly Property PROPERTY_ROLEID_ROLEDESCRIPTION = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleDescription");
		public static readonly Property PROPERTY_ROLEID_ROLEISSYSTEMROLE = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleIsSystemRole");
		#endregion
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "MenuRoleID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "MenuRoleID":
                    return typeof (int);
                case "MenuID":
                    return typeof (int);
                case "RoleID":
                    return typeof (int);
          }
			return typeof(string);
        }
    }
}
