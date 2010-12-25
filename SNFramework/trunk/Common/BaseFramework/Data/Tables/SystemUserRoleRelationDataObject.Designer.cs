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
    public partial class SystemUserRoleRelationDataObject : BaseNHibernateDataObject<SystemUserRoleRelationEntity>
    {
				#region Expression Query Property (标准查询字段)
		public static readonly Property PROPERTY_USERROLEID = Property.ForName(SystemUserRoleRelationEntity.PROPERTY_NAME_USERROLEID);
		public static readonly Property PROPERTY_USERID = Property.ForName(SystemUserRoleRelationEntity.PROPERTY_NAME_USERID);
		#region userID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> InClude_UserID_Query(NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemUserRoleRelationEntity.PROPERTY_NAME_USERID, PROPERTY_USERID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_USERID_ALIAS_NAME = "UserID_SystemUserRoleRelationEntity_Alias";
		public static readonly Property PROPERTY_USERID_USERID = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserID");
		public static readonly Property PROPERTY_USERID_USERLOGINID = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserLoginID");
		public static readonly Property PROPERTY_USERID_USERNAME = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserName");
		public static readonly Property PROPERTY_USERID_USEREMAIL = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserEmail");
		public static readonly Property PROPERTY_USERID_USERPASSWORD = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserPassword");
		public static readonly Property PROPERTY_USERID_USERSTATUS = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserStatus");
		public static readonly Property PROPERTY_USERID_USERCREATEDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserCreateDate");
		public static readonly Property PROPERTY_USERID_USERTYPE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".UserType");
		public static readonly Property PROPERTY_USERID_DEPARTMENTID = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".DepartmentID");
		public static readonly Property PROPERTY_USERID_MOBILEPIN = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".MobilePIN");
		public static readonly Property PROPERTY_USERID_PASSWORDFORMAT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordFormat");
		public static readonly Property PROPERTY_USERID_PASSWORDQUESTION = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordQuestion");
		public static readonly Property PROPERTY_USERID_PASSWORDANSWER = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordAnswer");
		public static readonly Property PROPERTY_USERID_COMMENTS = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".Comments");
		public static readonly Property PROPERTY_USERID_ISAPPROVED = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsApproved");
		public static readonly Property PROPERTY_USERID_ISLOCKEDOUT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsLockedOut");
		public static readonly Property PROPERTY_USERID_LASTACTIVITYDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastActivityDate");
		public static readonly Property PROPERTY_USERID_LASTLOGINDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastLoginDate");
		public static readonly Property PROPERTY_USERID_LASTLOCKEDOUTDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastLockedOutDate");
		public static readonly Property PROPERTY_USERID_LASTPASSWORDCHANGEDATE = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LastPasswordChangeDate");
		public static readonly Property PROPERTY_USERID_FAILEDPWDATTEMPTCNT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAttemptCnt");
		public static readonly Property PROPERTY_USERID_FAILEDPWDATTEMPTWNDSTART = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAttemptWndStart");
		public static readonly Property PROPERTY_USERID_FAILEDPWDANSATTEMPTCNT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAnsAttemptCnt");
		public static readonly Property PROPERTY_USERID_FAILEDPWDANSATTEMPTWNDSTART = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".FailedPwdAnsAttemptWndStart");
		public static readonly Property PROPERTY_USERID_ISNEEDCHGPWD = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".IsNeedChgPwd");
		public static readonly Property PROPERTY_USERID_PASSWORDSALT = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".PasswordSalt");
		public static readonly Property PROPERTY_USERID_LOWEREDEMAIL = Property.ForName(PROPERTY_USERID_ALIAS_NAME + ".LoweredEmail");
		#endregion
		public static readonly Property PROPERTY_ROLEID = Property.ForName(SystemUserRoleRelationEntity.PROPERTY_NAME_ROLEID);
		#region roleID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> InClude_RoleID_Query(NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemUserRoleRelationEntity.PROPERTY_NAME_ROLEID, PROPERTY_ROLEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_ROLEID_ALIAS_NAME = "RoleID_SystemUserRoleRelationEntity_Alias";
		public static readonly Property PROPERTY_ROLEID_ROLEID = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleID");
		public static readonly Property PROPERTY_ROLEID_ROLENAME = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleName");
		public static readonly Property PROPERTY_ROLEID_ROLEDESCRIPTION = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleDescription");
		public static readonly Property PROPERTY_ROLEID_ROLEISSYSTEMROLE = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleIsSystemRole");
		public static readonly Property PROPERTY_ROLEID_ROLETYPE = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".RoleType");
		public static readonly Property PROPERTY_ROLEID_CREATEBY = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".CreateBy");
		public static readonly Property PROPERTY_ROLEID_CREATEDATE = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".CreateDate");
		public static readonly Property PROPERTY_ROLEID_LASTUPDATEBY = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".LastUpdateBy");
		public static readonly Property PROPERTY_ROLEID_LASTUPDATEDATE = Property.ForName(PROPERTY_ROLEID_ALIAS_NAME + ".LastUpdateDate");
		#endregion
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "UserRoleID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "UserRoleID":
                    return typeof (int);
                case "UserID":
                    return typeof (int);
                case "RoleID":
                    return typeof (int);
          }
			return typeof(string);
        }
		
		public List<SystemUserRoleRelationEntity> GetList_By_UserID_SystemUserEntity(SystemUserEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemUserRoleRelationEntity> GetPageList_By_UserID_SystemUserEntity(string orderByColumnName, bool isDesc, SystemUserEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_USERID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SystemUserRoleRelationEntity> GetList_By_RoleID_SystemRoleEntity(SystemRoleEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemUserRoleRelationEntity> GetPageList_By_RoleID_SystemRoleEntity(string orderByColumnName, bool isDesc, SystemRoleEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
