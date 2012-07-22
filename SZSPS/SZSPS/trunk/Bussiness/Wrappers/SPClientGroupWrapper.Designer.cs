// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using LD.SPPipeManage.Entity.Tables;
using LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container;
using LD.SPPipeManage.Bussiness.ServiceProxys.Tables;

namespace LD.SPPipeManage.Bussiness.Wrappers
{
    public partial class SPClientGroupWrapper
    {
        #region Member

		internal static readonly ISPClientGroupServiceProxy businessProxy = ((LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPClientGroupServiceProxyInstance;
		//internal static readonly ISPClientGroupServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SPClientGroupServiceProxyInstance;

        internal SPClientGroupEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPClientGroupWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPClientGroupWrapper() : this(new SPClientGroupEntity())
        {
            
        }

        internal SPClientGroupWrapper(SPClientGroupEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.Id == 0)
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

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPClientGroupEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_USERID = "UserID";
		public static readonly string PROPERTY_NAME_DEFAULTSYCNMOURL = "DefaultSycnMoUrl";
		public static readonly string PROPERTY_NAME_DEFAULTSYCNMRURL = "DefaultSycnMRUrl";
		public static readonly string PROPERTY_NAME_DEFAULTINTERCEPTRATE = "DefaultInterceptRate";
		public static readonly string PROPERTY_NAME_DEFAULTNOINTERCEPTCOUNT = "DefaultNoInterceptCount";
		public static readonly string PROPERTY_NAME_ASSIGNEDUSERID = "AssignedUserID";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 
		/// </summary>		
		public int Id
		{
			get
			{
				return entity.Id;
			}
			set
			{
				entity.Id = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Name
		{
			get
			{
				return entity.Name;
			}
			set
			{
				entity.Name = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Description
		{
			get
			{
				return entity.Description;
			}
			set
			{
				entity.Description = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? UserID
		{
			get
			{
				return entity.UserID;
			}
			set
			{
				entity.UserID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string DefaultSycnMoUrl
		{
			get
			{
				return entity.DefaultSycnMoUrl;
			}
			set
			{
				entity.DefaultSycnMoUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string DefaultSycnMRUrl
		{
			get
			{
				return entity.DefaultSycnMRUrl;
			}
			set
			{
				entity.DefaultSycnMRUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int DefaultInterceptRate
		{
			get
			{
				return entity.DefaultInterceptRate;
			}
			set
			{
				entity.DefaultInterceptRate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int DefaultNoInterceptCount
		{
			get
			{
				return entity.DefaultNoInterceptCount;
			}
			set
			{
				entity.DefaultNoInterceptCount = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? AssignedUserID
		{
			get
			{
				return entity.AssignedUserID;
			}
			set
			{
				entity.AssignedUserID = value;
			}
		}
		#endregion 





        #region "FKQuery"



        #endregion

        #region Static Common Data Operation
		
		internal static List<SPClientGroupWrapper> ConvertToWrapperList(List<SPClientGroupEntity> entitylist)
        {
            List<SPClientGroupWrapper> list = new List<SPClientGroupWrapper>();
            foreach (SPClientGroupEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPClientGroupWrapper> ConvertToWrapperList(IList<SPClientGroupEntity> entitylist)
        {
            List<SPClientGroupWrapper> list = new List<SPClientGroupWrapper>();
            foreach (SPClientGroupEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPClientGroupEntity> ConvertToEntityList(List<SPClientGroupWrapper> wrapperlist)
        {
            List<SPClientGroupEntity> list = new List<SPClientGroupEntity>();
            foreach (SPClientGroupWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPClientGroupWrapper ConvertEntityToWrapper(SPClientGroupEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPClientGroupWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

