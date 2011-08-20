// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using SPS.Entity.Tables;
using SPS.Bussiness.ServiceProxys.Tables.Container;
using SPS.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;

namespace SPS.Bussiness.Wrappers
{
    public partial class SPRecordExtendInfoWrapper
    {
        #region Member

		internal static readonly ISPRecordExtendInfoServiceProxy businessProxy = ((SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPRecordExtendInfoServiceProxyInstance;
	 
	 
        internal SPRecordExtendInfoEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SPRecordExtendInfoWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SPRecordExtendInfoWrapper() : this(new SPRecordExtendInfoEntity())
        {
            
        }

        internal SPRecordExtendInfoWrapper(SPRecordExtendInfoEntity entityObj)
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

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPRecordExtendInfoEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_RECORDID = "RecordID";
		public static readonly string PROPERTY_NAME_IP = "Ip";
		public static readonly string PROPERTY_NAME_SSYCNDATAURL = "SSycnDataUrl";
		public static readonly string PROPERTY_NAME_REQUESTCONTENT = "RequestContent";
		public static readonly string PROPERTY_NAME_EXTENDFIELD1 = "ExtendField1";
		public static readonly string PROPERTY_NAME_EXTENDFIELD2 = "ExtendField2";
		public static readonly string PROPERTY_NAME_EXTENDFIELD3 = "ExtendField3";
		public static readonly string PROPERTY_NAME_EXTENDFIELD4 = "ExtendField4";
		public static readonly string PROPERTY_NAME_EXTENDFIELD5 = "ExtendField5";
		public static readonly string PROPERTY_NAME_EXTENDFIELD6 = "ExtendField6";
		public static readonly string PROPERTY_NAME_EXTENDFIELD8 = "ExtendField8";
		public static readonly string PROPERTY_NAME_EXTENDFIELD7 = "ExtendField7";
		public static readonly string PROPERTY_NAME_EXTENDFIELD9 = "ExtendField9";
		public static readonly string PROPERTY_NAME_EXTENDFIELD10 = "ExtendField10";
		public static readonly string PROPERTY_NAME_STATE = "State";
		
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
		public SPRecordWrapper RecordID
		{
			get
			{
				return SPRecordWrapper.ConvertEntityToWrapper(entity.RecordID) ;
			}
			set
			{
				entity.RecordID = ((value == null) ? null : value.entity);
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
		public string SSycnDataUrl
		{
			get
			{
				return entity.SSycnDataUrl;
			}
			set
			{
				entity.SSycnDataUrl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string RequestContent
		{
			get
			{
				return entity.RequestContent;
			}
			set
			{
				entity.RequestContent = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField1
		{
			get
			{
				return entity.ExtendField1;
			}
			set
			{
				entity.ExtendField1 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField2
		{
			get
			{
				return entity.ExtendField2;
			}
			set
			{
				entity.ExtendField2 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField3
		{
			get
			{
				return entity.ExtendField3;
			}
			set
			{
				entity.ExtendField3 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField4
		{
			get
			{
				return entity.ExtendField4;
			}
			set
			{
				entity.ExtendField4 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField5
		{
			get
			{
				return entity.ExtendField5;
			}
			set
			{
				entity.ExtendField5 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField6
		{
			get
			{
				return entity.ExtendField6;
			}
			set
			{
				entity.ExtendField6 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField8
		{
			get
			{
				return entity.ExtendField8;
			}
			set
			{
				entity.ExtendField8 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField7
		{
			get
			{
				return entity.ExtendField7;
			}
			set
			{
				entity.ExtendField7 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField9
		{
			get
			{
				return entity.ExtendField9;
			}
			set
			{
				entity.ExtendField9 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string ExtendField10
		{
			get
			{
				return entity.ExtendField10;
			}
			set
			{
				entity.ExtendField10 = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>		
		public string State
		{
			get
			{
				return entity.State;
			}
			set
			{
				entity.State = value;
			}
		}
		#endregion 





        #region "FKQuery"
		
        public static List<SPRecordExtendInfoWrapper> FindAllByOrderByAndFilterAndRecordID(string orderByColumnName, bool isDesc,   SPRecordWrapper recordID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndRecordID(orderByColumnName, isDesc,   recordID.entity, pageQueryParams));
        }

        public static List<SPRecordExtendInfoWrapper> FindAllByRecordID(SPRecordWrapper recordID)
        {
            return ConvertToWrapperList(businessProxy.FindAllByRecordID(recordID.entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SPRecordExtendInfoWrapper> ConvertToWrapperList(List<SPRecordExtendInfoEntity> entitylist)
        {
            List<SPRecordExtendInfoWrapper> list = new List<SPRecordExtendInfoWrapper>();
            foreach (SPRecordExtendInfoEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPRecordExtendInfoWrapper> ConvertToWrapperList(IList<SPRecordExtendInfoEntity> entitylist)
        {
            List<SPRecordExtendInfoWrapper> list = new List<SPRecordExtendInfoWrapper>();
            foreach (SPRecordExtendInfoEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPRecordExtendInfoEntity> ConvertToEntityList(List<SPRecordExtendInfoWrapper> wrapperlist)
        {
            List<SPRecordExtendInfoEntity> list = new List<SPRecordExtendInfoEntity>();
            foreach (SPRecordExtendInfoWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPRecordExtendInfoWrapper ConvertEntityToWrapper(SPRecordExtendInfoEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPRecordExtendInfoWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

