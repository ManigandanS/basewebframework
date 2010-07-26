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
    public partial class SPSendClientParamsWrapper
    {
        #region Member

		internal static readonly ISPSendClientParamsServiceProxy businessProxy = ((LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPSendClientParamsServiceProxyInstance;
		//internal static readonly ISPSendClientParamsServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SPSendClientParamsServiceProxyInstance;

        internal SPSendClientParamsEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPSendClientParamsWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPSendClientParamsWrapper() : this(new SPSendClientParamsEntity())
        {
            
        }

        internal SPSendClientParamsWrapper(SPSendClientParamsEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPSendClientParamsEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_ISREQUIRED = "IsRequired";
		public static readonly string PROPERTY_NAME_CLIENTID = "ClientID";
		public static readonly string PROPERTY_NAME_MAPPINGPARAMS = "MappingParams";
		public static readonly string PROPERTY_NAME_TITLE = "Title";
		
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
		public bool? IsEnable
		{
			get
			{
				return entity.IsEnable;
			}
			set
			{
				entity.IsEnable = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsRequired
		{
			get
			{
				return entity.IsRequired;
			}
			set
			{
				entity.IsRequired = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SPClientWrapper ClientID
		{
			get
			{
				return SPClientWrapper.ConvertEntityToWrapper(entity.ClientID) ;
			}
			set
			{
				entity.ClientID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string MappingParams
		{
			get
			{
				return entity.MappingParams;
			}
			set
			{
				entity.MappingParams = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Title
		{
			get
			{
				return entity.Title;
			}
			set
			{
				entity.Title = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SPSendClientParamsWrapper> FindAllByOrderByAndFilterAndClientID(string orderByColumnName, bool isDesc, int pageIndex, int pageSize, SPClientWrapper clientID, out int recordCount)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndClientID(orderByColumnName, isDesc, pageIndex, pageSize, clientID.entity, out recordCount));
        }

        public static List<SPSendClientParamsWrapper> FindAllByClientID(SPClientWrapper clientID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByClientID(clientID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SPSendClientParamsWrapper> ConvertToWrapperList(List<SPSendClientParamsEntity> entitylist)
        {
            List<SPSendClientParamsWrapper> list = new List<SPSendClientParamsWrapper>();
            foreach (SPSendClientParamsEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPSendClientParamsWrapper> ConvertToWrapperList(IList<SPSendClientParamsEntity> entitylist)
        {
            List<SPSendClientParamsWrapper> list = new List<SPSendClientParamsWrapper>();
            foreach (SPSendClientParamsEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPSendClientParamsEntity> ConvertToEntityList(List<SPSendClientParamsWrapper> wrapperlist)
        {
            List<SPSendClientParamsEntity> list = new List<SPSendClientParamsEntity>();
            foreach (SPSendClientParamsWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPSendClientParamsWrapper ConvertEntityToWrapper(SPSendClientParamsEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPSendClientParamsWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

