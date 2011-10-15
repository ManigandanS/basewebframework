// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;

namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
    public partial class SystemPrivilegeParameterWrapper   
    {
        #region Member

		internal static readonly ISystemPrivilegeParameterServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemPrivilegeParameterServiceProxyInstance;
		
		
		internal SystemPrivilegeParameterEntity Entity
        {
            get { return this.entity; }
        }
		
        #endregion

        #region Construtor
		public SystemPrivilegeParameterWrapper() : base(new SystemPrivilegeParameterEntity())
        {
            
        }

        internal SystemPrivilegeParameterWrapper(SystemPrivilegeParameterEntity entityObj)
            : base(entityObj)
        {
        }
		#endregion

        #region Process Column Name
        private static string ProcessColumnName(string columnName)
        {
            switch (columnName)
            {
		        case "RoleID_RoleID":
					return PROPERTY_ROLEID_ROLEID;
		        case "RoleID_RoleName":
					return PROPERTY_ROLEID_ROLENAME;
		        case "RoleID_RoleCode":
					return PROPERTY_ROLEID_ROLECODE;
		        case "RoleID_RoleDescription":
					return PROPERTY_ROLEID_ROLEDESCRIPTION;
		        case "RoleID_RoleIsSystemRole":
					return PROPERTY_ROLEID_ROLEISSYSTEMROLE;
		        case "RoleID_RoleType":
					return PROPERTY_ROLEID_ROLETYPE;
		        case "RoleID_CreateBy":
					return PROPERTY_ROLEID_CREATEBY;
		        case "RoleID_CreateAt":
					return PROPERTY_ROLEID_CREATEAT;
		        case "RoleID_LastModifyBy":
					return PROPERTY_ROLEID_LASTMODIFYBY;
		        case "RoleID_LastModifyAt":
					return PROPERTY_ROLEID_LASTMODIFYAT;
		        case "RoleID_LastModifyComment":
					return PROPERTY_ROLEID_LASTMODIFYCOMMENT;
		        case "PrivilegeID_PrivilegeID":
					return PROPERTY_PRIVILEGEID_PRIVILEGEID;
		        case "PrivilegeID_OperationID":
					return PROPERTY_PRIVILEGEID_OPERATIONID;
		        case "PrivilegeID_ResourcesID":
					return PROPERTY_PRIVILEGEID_RESOURCESID;
		        case "PrivilegeID_PrivilegeCnName":
					return PROPERTY_PRIVILEGEID_PRIVILEGECNNAME;
		        case "PrivilegeID_PrivilegeEnName":
					return PROPERTY_PRIVILEGEID_PRIVILEGEENNAME;
		        case "PrivilegeID_DefaultValue":
					return PROPERTY_PRIVILEGEID_DEFAULTVALUE;
		        case "PrivilegeID_Description":
					return PROPERTY_PRIVILEGEID_DESCRIPTION;
		        case "PrivilegeID_PrivilegeOrder":
					return PROPERTY_PRIVILEGEID_PRIVILEGEORDER;
		        case "PrivilegeID_PrivilegeType":
					return PROPERTY_PRIVILEGEID_PRIVILEGETYPE;
		        case "PrivilegeID_CreateBy":
					return PROPERTY_PRIVILEGEID_CREATEBY;
		        case "PrivilegeID_CreateAt":
					return PROPERTY_PRIVILEGEID_CREATEAT;
		        case "PrivilegeID_LastModifyBy":
					return PROPERTY_PRIVILEGEID_LASTMODIFYBY;
		        case "PrivilegeID_LastModifyAt":
					return PROPERTY_PRIVILEGEID_LASTMODIFYAT;
		        case "PrivilegeID_LastModifyComment":
					return PROPERTY_PRIVILEGEID_LASTMODIFYCOMMENT;
              default:
                    return columnName;
            }
        }

        private static void ProcessQueryFilters(List<QueryFilter> filters)
        {
            foreach (QueryFilter queryFilter in filters)
            {
                queryFilter.FilterFieldName = ProcessColumnName(queryFilter.FilterFieldName);
            }
        }
		#endregion
		
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemPrivilegeParameterEntity";
		public static readonly string PROPERTY_NAME_PRIVILEGEPARAMETERID = "PrivilegeParameterID";
		public static readonly string PROPERTY_NAME_ROLEID = "RoleID";
		public static readonly string PROPERTY_NAME_PRIVILEGEID = "PrivilegeID";
		public static readonly string PROPERTY_NAME_BIZPARAMETER = "BizParameter";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
		#region roleID字段外键查询字段
        public const string PROPERTY_ROLEID_ALIAS_NAME = "RoleID_SystemPrivilegeParameterEntity_Alias";
		public const string PROPERTY_ROLEID_ROLEID = "RoleID_SystemPrivilegeParameterEntity_Alias.RoleID";
		public const string PROPERTY_ROLEID_ROLENAME = "RoleID_SystemPrivilegeParameterEntity_Alias.RoleName";
		public const string PROPERTY_ROLEID_ROLECODE = "RoleID_SystemPrivilegeParameterEntity_Alias.RoleCode";
		public const string PROPERTY_ROLEID_ROLEDESCRIPTION = "RoleID_SystemPrivilegeParameterEntity_Alias.RoleDescription";
		public const string PROPERTY_ROLEID_ROLEISSYSTEMROLE = "RoleID_SystemPrivilegeParameterEntity_Alias.RoleIsSystemRole";
		public const string PROPERTY_ROLEID_ROLETYPE = "RoleID_SystemPrivilegeParameterEntity_Alias.RoleType";
		public const string PROPERTY_ROLEID_CREATEBY = "RoleID_SystemPrivilegeParameterEntity_Alias.CreateBy";
		public const string PROPERTY_ROLEID_CREATEAT = "RoleID_SystemPrivilegeParameterEntity_Alias.CreateAt";
		public const string PROPERTY_ROLEID_LASTMODIFYBY = "RoleID_SystemPrivilegeParameterEntity_Alias.LastModifyBy";
		public const string PROPERTY_ROLEID_LASTMODIFYAT = "RoleID_SystemPrivilegeParameterEntity_Alias.LastModifyAt";
		public const string PROPERTY_ROLEID_LASTMODIFYCOMMENT = "RoleID_SystemPrivilegeParameterEntity_Alias.LastModifyComment";
		#endregion
		#region privilegeID字段外键查询字段
        public const string PROPERTY_PRIVILEGEID_ALIAS_NAME = "PrivilegeID_SystemPrivilegeParameterEntity_Alias";
		public const string PROPERTY_PRIVILEGEID_PRIVILEGEID = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeID";
		public const string PROPERTY_PRIVILEGEID_OPERATIONID = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.OperationID";
		public const string PROPERTY_PRIVILEGEID_RESOURCESID = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.ResourcesID";
		public const string PROPERTY_PRIVILEGEID_PRIVILEGECNNAME = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeCnName";
		public const string PROPERTY_PRIVILEGEID_PRIVILEGEENNAME = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeEnName";
		public const string PROPERTY_PRIVILEGEID_DEFAULTVALUE = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.DefaultValue";
		public const string PROPERTY_PRIVILEGEID_DESCRIPTION = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.Description";
		public const string PROPERTY_PRIVILEGEID_PRIVILEGEORDER = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeOrder";
		public const string PROPERTY_PRIVILEGEID_PRIVILEGETYPE = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.PrivilegeType";
		public const string PROPERTY_PRIVILEGEID_CREATEBY = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.CreateBy";
		public const string PROPERTY_PRIVILEGEID_CREATEAT = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.CreateAt";
		public const string PROPERTY_PRIVILEGEID_LASTMODIFYBY = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.LastModifyBy";
		public const string PROPERTY_PRIVILEGEID_LASTMODIFYAT = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.LastModifyAt";
		public const string PROPERTY_PRIVILEGEID_LASTMODIFYCOMMENT = "PrivilegeID_SystemPrivilegeParameterEntity_Alias.LastModifyComment";
		#endregion
      	
	
	
		 
		
		
		
		


		#region Public Property
		/// <summary>
		/// ??
		/// </summary>		
		public int PrivilegeParameterID
		{
			get
			{
				return entity.PrivilegeParameterID;
			}
			set
			{
				entity.PrivilegeParameterID = value;
			}
		}
		/// <summary>
		/// ??ID
		/// </summary>		
		public SystemRoleWrapper RoleID
		{
			get
			{
				return SystemRoleWrapper.ConvertEntityToWrapper(entity.RoleID) ;
			}
			set
			{
				entity.RoleID = ((value == null) ? null : value.Entity);
			}
		}
		/// <summary>
		/// ??ID
		/// </summary>		
		public SystemPrivilegeWrapper PrivilegeID
		{
			get
			{
				return SystemPrivilegeWrapper.ConvertEntityToWrapper(entity.PrivilegeID) ;
			}
			set
			{
				entity.PrivilegeID = ((value == null) ? null : value.Entity);
			}
		}
		/// <summary>
		/// ??
		/// </summary>		
		public string BizParameter
		{
			get
			{
				return entity.BizParameter;
			}
			set
			{
				entity.BizParameter = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? CreateBy
		{
			get
			{
				return entity.CreateBy;
			}
			set
			{
				entity.CreateBy = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? CreateAt
		{
			get
			{
				return entity.CreateAt;
			}
			set
			{
				entity.CreateAt = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? LastModifyBy
		{
			get
			{
				return entity.LastModifyBy;
			}
			set
			{
				entity.LastModifyBy = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? LastModifyAt
		{
			get
			{
				return entity.LastModifyAt;
			}
			set
			{
				entity.LastModifyAt = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string LastModifyComment
		{
			get
			{
				return entity.LastModifyComment;
			}
			set
			{
				entity.LastModifyComment = value;
			}
		}
		#endregion 


		#region Query Property
		
		
		#region roleID字段外键查询字段
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_ROLEID)]
        public int? RoleID_RoleID
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.RoleID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_ROLENAME)]
        public string RoleID_RoleName
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.RoleName;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_ROLECODE)]
        public string RoleID_RoleCode
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.RoleCode;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_ROLEDESCRIPTION)]
        public string RoleID_RoleDescription
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.RoleDescription;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_ROLEISSYSTEMROLE)]
        public bool? RoleID_RoleIsSystemRole
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.RoleIsSystemRole;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_ROLETYPE)]
        public string RoleID_RoleType
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.RoleType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_CREATEBY)]
        public int? RoleID_CreateBy
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.CreateBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_CREATEAT)]
        public DateTime? RoleID_CreateAt
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.CreateAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_LASTMODIFYBY)]
        public int? RoleID_LastModifyBy
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.LastModifyBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_LASTMODIFYAT)]
        public DateTime? RoleID_LastModifyAt
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.LastModifyAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_ROLEID_LASTMODIFYCOMMENT)]
        public string RoleID_LastModifyComment
        {
            get
            {
                if (this. RoleID == null)
                    return null;
                return  RoleID.LastModifyComment;
            }
        }
		#endregion
		#region privilegeID字段外键查询字段
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_PRIVILEGEID)]
        public int? PrivilegeID_PrivilegeID
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.PrivilegeID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_OPERATIONID)]
        public SystemOperationWrapper PrivilegeID_OperationID
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.OperationID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_RESOURCESID)]
        public SystemResourcesWrapper PrivilegeID_ResourcesID
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.ResourcesID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_PRIVILEGECNNAME)]
        public string PrivilegeID_PrivilegeCnName
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.PrivilegeCnName;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_PRIVILEGEENNAME)]
        public string PrivilegeID_PrivilegeEnName
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.PrivilegeEnName;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_DEFAULTVALUE)]
        public string PrivilegeID_DefaultValue
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.DefaultValue;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_DESCRIPTION)]
        public string PrivilegeID_Description
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.Description;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_PRIVILEGEORDER)]
        public int? PrivilegeID_PrivilegeOrder
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.PrivilegeOrder;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_PRIVILEGETYPE)]
        public string PrivilegeID_PrivilegeType
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.PrivilegeType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_CREATEBY)]
        public int? PrivilegeID_CreateBy
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.CreateBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_CREATEAT)]
        public DateTime? PrivilegeID_CreateAt
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.CreateAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_LASTMODIFYBY)]
        public int? PrivilegeID_LastModifyBy
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.LastModifyBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_LASTMODIFYAT)]
        public DateTime? PrivilegeID_LastModifyAt
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.LastModifyAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_PRIVILEGEID_LASTMODIFYCOMMENT)]
        public string PrivilegeID_LastModifyComment
        {
            get
            {
                if (this. PrivilegeID == null)
                    return null;
                return  PrivilegeID.LastModifyComment;
            }
        }
		#endregion
      	
   
		#endregion


        #region "FKQuery"
		
        public static List<SystemPrivilegeParameterWrapper> FindAllByOrderByAndFilterAndRoleID(string orderByColumnName, bool isDesc,   SystemRoleWrapper roleID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndRoleID(orderByColumnName, isDesc,   roleID.Entity, pageQueryParams));
        }

        public static List<SystemPrivilegeParameterWrapper> FindAllByRoleID(SystemRoleWrapper roleID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByRoleID(roleID.Entity));
        }
		
		
        public static List<SystemPrivilegeParameterWrapper> FindAllByOrderByAndFilterAndPrivilegeID(string orderByColumnName, bool isDesc,   SystemPrivilegeWrapper privilegeID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndPrivilegeID(orderByColumnName, isDesc,   privilegeID.Entity, pageQueryParams));
        }

        public static List<SystemPrivilegeParameterWrapper> FindAllByPrivilegeID(SystemPrivilegeWrapper privilegeID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByPrivilegeID(privilegeID.Entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemPrivilegeParameterWrapper> ConvertToWrapperList(List<SystemPrivilegeParameterEntity> entitylist)
        {
            List<SystemPrivilegeParameterWrapper> list = new List<SystemPrivilegeParameterWrapper>();
            foreach (SystemPrivilegeParameterEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemPrivilegeParameterWrapper> ConvertToWrapperList(IList<SystemPrivilegeParameterEntity> entitylist)
        {
            List<SystemPrivilegeParameterWrapper> list = new List<SystemPrivilegeParameterWrapper>();
            foreach (SystemPrivilegeParameterEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemPrivilegeParameterEntity> ConvertToEntityList(List<SystemPrivilegeParameterWrapper> wrapperlist)
        {
            List<SystemPrivilegeParameterEntity> list = new List<SystemPrivilegeParameterEntity>();
            foreach (SystemPrivilegeParameterWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemPrivilegeParameterWrapper ConvertEntityToWrapper(SystemPrivilegeParameterEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.PrivilegeParameterID == 0)
                return null;

            return new SystemPrivilegeParameterWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

