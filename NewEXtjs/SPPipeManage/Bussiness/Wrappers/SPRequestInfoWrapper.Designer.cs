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
    public partial class SPRequestInfoWrapper
    {
        #region Member

		internal static readonly ISPRequestInfoServiceProxy businessProxy = ((LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(LD.SPPipeManage.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPRequestInfoServiceProxyInstance;
		//internal static readonly ISPRequestInfoServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SPRequestInfoServiceProxyInstance;

        internal SPRequestInfoEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPRequestInfoWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPRequestInfoWrapper() : this(new SPRequestInfoEntity())
        {
            
        }

        internal SPRequestInfoWrapper(SPRequestInfoEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Entity.Tables.SPRequestInfoEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_IP = "Ip";
		public static readonly string PROPERTY_NAME_REQUESTINFO = "RequestInfo";
		public static readonly string PROPERTY_NAME_REQUESTDATE = "RequestDate";
		public static readonly string PROPERTY_NAME_ISTOPAYMENT = "IsToPayment";
		public static readonly string PROPERTY_NAME_REQUESTURL = "RequestUrl";
		public static readonly string PROPERTY_NAME_DATAID = "DataID";
		
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
		public string Ip
		{
			get
			{
				return entity.Ip;
			}
			set
			{
				entity.Ip = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string RequestInfo
		{
			get
			{
				return entity.RequestInfo;
			}
			set
			{
				entity.RequestInfo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? RequestDate
		{
			get
			{
				return entity.RequestDate;
			}
			set
			{
				entity.RequestDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool? IsToPayment
		{
			get
			{
				return entity.IsToPayment;
			}
			set
			{
				entity.IsToPayment = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string RequestUrl
		{
			get
			{
				return entity.RequestUrl;
			}
			set
			{
				entity.RequestUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int? DataID
		{
			get
			{
				return entity.DataID;
			}
			set
			{
				entity.DataID = value;
			}
		}
		#endregion 





        #region "FKQuery"



        #endregion

        #region Static Common Data Operation
		
		internal static List<SPRequestInfoWrapper> ConvertToWrapperList(List<SPRequestInfoEntity> entitylist)
        {
            List<SPRequestInfoWrapper> list = new List<SPRequestInfoWrapper>();
            foreach (SPRequestInfoEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPRequestInfoWrapper> ConvertToWrapperList(IList<SPRequestInfoEntity> entitylist)
        {
            List<SPRequestInfoWrapper> list = new List<SPRequestInfoWrapper>();
            foreach (SPRequestInfoEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPRequestInfoEntity> ConvertToEntityList(List<SPRequestInfoWrapper> wrapperlist)
        {
            List<SPRequestInfoEntity> list = new List<SPRequestInfoEntity>();
            foreach (SPRequestInfoWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPRequestInfoWrapper ConvertEntityToWrapper(SPRequestInfoEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPRequestInfoWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

