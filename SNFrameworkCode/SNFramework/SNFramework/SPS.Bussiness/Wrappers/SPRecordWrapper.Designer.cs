// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using SPS.Entity.Tables;
using SPS.Bussiness.ServiceProxys.Tables.Container;
using SPS.Bussiness.ServiceProxys.Tables;

namespace SPS.Bussiness.Wrappers
{
    public partial class SPRecordWrapper
    {
        #region Member

		internal static readonly ISPRecordServiceProxy businessProxy = ((SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPRecordServiceProxyInstance;
		//internal static readonly ISPRecordServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SPRecordServiceProxyInstance;

        internal SPRecordEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPRecordWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPRecordWrapper() : this(new SPRecordEntity())
        {
            
        }

        internal SPRecordWrapper(SPRecordEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPRecordEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_LINKID = "LinkID";
		public static readonly string PROPERTY_NAME_MO = "Mo";
		public static readonly string PROPERTY_NAME_MOBILE = "Mobile";
		public static readonly string PROPERTY_NAME_SPNUMBER = "SpNumber";
		public static readonly string PROPERTY_NAME_PROVINCE = "Province";
		public static readonly string PROPERTY_NAME_CITY = "City";
		public static readonly string PROPERTY_NAME_OPERATORTYPE = "OperatorType";
		public static readonly string PROPERTY_NAME_CREATEDATE = "CreateDate";
		public static readonly string PROPERTY_NAME_ISREPORT = "IsReport";
		public static readonly string PROPERTY_NAME_ISINTERCEPT = "IsIntercept";
		public static readonly string PROPERTY_NAME_ISSYCNTOCLIENT = "IsSycnToClient";
		public static readonly string PROPERTY_NAME_ISSYCNSUCCESSED = "IsSycnSuccessed";
		public static readonly string PROPERTY_NAME_ISSTATOK = "IsStatOK";
		public static readonly string PROPERTY_NAME_SYCNRETRYTIMES = "SycnRetryTimes";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_CLIENTID = "ClientID";
		public static readonly string PROPERTY_NAME_CODEID = "CodeID";
		public static readonly string PROPERTY_NAME_CLIENTCODERELATIONID = "ClientCodeRelationID";
		public static readonly string PROPERTY_NAME_PRICE = "Price";
		public static readonly string PROPERTY_NAME_COUNT = "Count";
		
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
		public string LinkID
		{
			get
			{
				return entity.LinkID;
			}
			set
			{
				entity.LinkID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Mo
		{
			get
			{
				return entity.Mo;
			}
			set
			{
				entity.Mo = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Mobile
		{
			get
			{
				return entity.Mobile;
			}
			set
			{
				entity.Mobile = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string SpNumber
		{
			get
			{
				return entity.SpNumber;
			}
			set
			{
				entity.SpNumber = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string Province
		{
			get
			{
				return entity.Province;
			}
			set
			{
				entity.Province = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string City
		{
			get
			{
				return entity.City;
			}
			set
			{
				entity.City = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string OperatorType
		{
			get
			{
				return entity.OperatorType;
			}
			set
			{
				entity.OperatorType = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public DateTime CreateDate
		{
			get
			{
				return entity.CreateDate;
			}
			set
			{
				entity.CreateDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool IsReport
		{
			get
			{
				return entity.IsReport;
			}
			set
			{
				entity.IsReport = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool IsIntercept
		{
			get
			{
				return entity.IsIntercept;
			}
			set
			{
				entity.IsIntercept = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool IsSycnToClient
		{
			get
			{
				return entity.IsSycnToClient;
			}
			set
			{
				entity.IsSycnToClient = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool IsSycnSuccessed
		{
			get
			{
				return entity.IsSycnSuccessed;
			}
			set
			{
				entity.IsSycnSuccessed = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public bool IsStatOK
		{
			get
			{
				return entity.IsStatOK;
			}
			set
			{
				entity.IsStatOK = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int SycnRetryTimes
		{
			get
			{
				return entity.SycnRetryTimes;
			}
			set
			{
				entity.SycnRetryTimes = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SPChannelWrapper ChannelID
		{
			get
			{
				return SPChannelWrapper.ConvertEntityToWrapper(entity.ChannelID) ;
			}
			set
			{
				entity.ChannelID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SPSClientWrapper ClientID
		{
			get
			{
				return SPSClientWrapper.ConvertEntityToWrapper(entity.ClientID) ;
			}
			set
			{
				entity.ClientID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SPCodeWrapper CodeID
		{
			get
			{
				return SPCodeWrapper.ConvertEntityToWrapper(entity.CodeID) ;
			}
			set
			{
				entity.CodeID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public SPClientCodeRelationWrapper ClientCodeRelationID
		{
			get
			{
				return SPClientCodeRelationWrapper.ConvertEntityToWrapper(entity.ClientCodeRelationID) ;
			}
			set
			{
				entity.ClientCodeRelationID = ((value == null) ? null : value.entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public decimal? Price
		{
			get
			{
				return entity.Price;
			}
			set
			{
				entity.Price = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public int Count
		{
			get
			{
				return entity.Count;
			}
			set
			{
				entity.Count = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SPRecordWrapper> FindAllByOrderByAndFilterAndChannelID(string orderByColumnName, bool isDesc,int pageIndex, int pageSize,    SPChannelWrapper channelID,  out int recordCount)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndChannelID(orderByColumnName, isDesc,pageIndex, pageSize,   channelID.entity,out recordCount));
        }

        public static List<SPRecordWrapper> FindAllByChannelID(SPChannelWrapper channelID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByChannelID(channelID.entity));
        }
		
		
        public static List<SPRecordWrapper> FindAllByOrderByAndFilterAndClientID(string orderByColumnName, bool isDesc,int pageIndex, int pageSize,    SPSClientWrapper clientID,  out int recordCount)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndClientID(orderByColumnName, isDesc,pageIndex, pageSize,   clientID.entity,out recordCount));
        }

        public static List<SPRecordWrapper> FindAllByClientID(SPSClientWrapper clientID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByClientID(clientID.entity));
        }
		
		
        public static List<SPRecordWrapper> FindAllByOrderByAndFilterAndCodeID(string orderByColumnName, bool isDesc,int pageIndex, int pageSize,    SPCodeWrapper codeID,  out int recordCount)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndCodeID(orderByColumnName, isDesc,pageIndex, pageSize,   codeID.entity,out recordCount));
        }

        public static List<SPRecordWrapper> FindAllByCodeID(SPCodeWrapper codeID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByCodeID(codeID.entity));
        }
		
		
        public static List<SPRecordWrapper> FindAllByOrderByAndFilterAndClientCodeRelationID(string orderByColumnName, bool isDesc,int pageIndex, int pageSize,    SPClientCodeRelationWrapper clientCodeRelationID,  out int recordCount)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndClientCodeRelationID(orderByColumnName, isDesc,pageIndex, pageSize,   clientCodeRelationID.entity,out recordCount));
        }

        public static List<SPRecordWrapper> FindAllByClientCodeRelationID(SPClientCodeRelationWrapper clientCodeRelationID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByClientCodeRelationID(clientCodeRelationID.entity));
        }
		



        #endregion

        #region Static Common Data Operation
		
		internal static List<SPRecordWrapper> ConvertToWrapperList(List<SPRecordEntity> entitylist)
        {
            List<SPRecordWrapper> list = new List<SPRecordWrapper>();
            foreach (SPRecordEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPRecordWrapper> ConvertToWrapperList(IList<SPRecordEntity> entitylist)
        {
            List<SPRecordWrapper> list = new List<SPRecordWrapper>();
            foreach (SPRecordEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPRecordEntity> ConvertToEntityList(List<SPRecordWrapper> wrapperlist)
        {
            List<SPRecordEntity> list = new List<SPRecordEntity>();
            foreach (SPRecordWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPRecordWrapper ConvertEntityToWrapper(SPRecordEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPRecordWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

