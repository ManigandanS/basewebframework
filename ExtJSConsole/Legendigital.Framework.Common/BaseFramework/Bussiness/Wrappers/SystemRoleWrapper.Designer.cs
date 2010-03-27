// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container;
using Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables;

namespace Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers
{
    public partial class SystemRoleWrapper
    {
        #region Member

		internal static readonly ISystemRoleServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemRoleServiceProxyInstance;
		//internal static readonly ISystemRoleServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SystemRoleServiceProxyInstance;

        internal SystemRoleEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemRoleWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemRoleWrapper() : this(new SystemRoleEntity())
        {
            
        }

        internal SystemRoleWrapper(SystemRoleEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.RoleID == 0)
                    return true;

                return false;
            }
            return entity.Equals(obj);
        }

        public override int GetHashCode()
        {
            return entity.GetHashCode();
        }
		#endregion
		
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemRoleEntity";
		public static readonly string PROPERTY_NAME_ROLEID = "RoleID";
		public static readonly string PROPERTY_NAME_ROLENAME = "RoleName";
		public static readonly string PROPERTY_NAME_ROLEDESCRIPTION = "RoleDescription";
		public static readonly string PROPERTY_NAME_ROLEISSYSTEMROLE = "RoleIsSystemRole";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 
		/// </summary>		
		public int RoleID
		{
			get
			{
				return entity.RoleID;
			}
			set
			{
				entity.RoleID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string RoleName
		{
			get
			{
				return entity.RoleName;
			}
			set
			{
				entity.RoleName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string RoleDescription
		{
			get
			{
				return entity.RoleDescription;
			}
			set
			{
				entity.RoleDescription = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? RoleIsSystemRole
		{
			get
			{
				return entity.RoleIsSystemRole;
			}
			set
			{
				entity.RoleIsSystemRole = value;
			}
		}
		#endregion 







        #region Static Common Data Operation
		
		internal static List<SystemRoleWrapper> ConvertToWrapperList(List<SystemRoleEntity> entitylist)
        {
            List<SystemRoleWrapper> list = new List<SystemRoleWrapper>();
            foreach (SystemRoleEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemRoleWrapper> ConvertToWrapperList(IList<SystemRoleEntity> entitylist)
        {
            List<SystemRoleWrapper> list = new List<SystemRoleWrapper>();
            foreach (SystemRoleEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemRoleEntity> ConvertToEntityList(List<SystemRoleWrapper> wrapperlist)
        {
            List<SystemRoleEntity> list = new List<SystemRoleEntity>();
            foreach (SystemRoleWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemRoleWrapper ConvertEntityToWrapper(SystemRoleEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.RoleID == 0)
                return null;

            return new SystemRoleWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

