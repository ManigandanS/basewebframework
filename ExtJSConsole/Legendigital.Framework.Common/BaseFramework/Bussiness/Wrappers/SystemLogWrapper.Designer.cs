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
    public partial class SystemLogWrapper
    {
        #region Member

		internal static readonly ISystemLogServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemLogServiceProxyInstance;
		//internal static readonly ISystemLogServiceProxy businessProxy = ((ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID"))).SystemLogServiceProxyInstance;

        internal SystemLogEntity entity;
		
		private static ILog logger = null;

        public static ILog Logger
        {
            get
            {
                if (logger == null)
                    logger = LogManager.GetLogger(typeof(SystemLogWrapper));
                return logger;
            }
        }

        #endregion

        #region Construtor
        public SystemLogWrapper() : this(new SystemLogEntity())
        {
            
        }

        internal SystemLogWrapper(SystemLogEntity entityObj)
        {
            entity = entityObj;
        }
		#endregion
		
		#region Equals 和 HashCode 方法覆盖
		public override bool Equals(object obj)
        {
            if (obj == null && entity!=null)
            {
                if (entity.LogID == 0)
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemLogEntity";
		public static readonly string PROPERTY_NAME_LOGID = "LogID";
		public static readonly string PROPERTY_NAME_LOGLEVEL = "LogLevel";
		public static readonly string PROPERTY_NAME_LOGTYPE = "LogType";
		public static readonly string PROPERTY_NAME_LOGDATE = "LogDate";
		public static readonly string PROPERTY_NAME_LOGSOURCE = "LogSource";
		public static readonly string PROPERTY_NAME_LOGUSER = "LogUser";
		public static readonly string PROPERTY_NAME_LOGDESCRPTION = "LogDescrption";
		public static readonly string PROPERTY_NAME_LOGREQUESTINFO = "LogRequestInfo";
		public static readonly string PROPERTY_NAME_LOGRELATEMOUDLEID = "LogRelateMoudleID";
		public static readonly string PROPERTY_NAME_LOGRELATEMOUDLEDATAID = "LogRelateMoudleDataID";
		public static readonly string PROPERTY_NAME_LOGRELATEUSERID = "LogRelateUserID";
		public static readonly string PROPERTY_NAME_LOGRELATEDATETIME = "LogRelateDateTime";
		
        #endregion


		#region Public Property
		/// <summary>
		/// 主键
		/// </summary>		
		public int LogID
		{
			get
			{
				return entity.LogID;
			}
			set
			{
				entity.LogID = value;
			}
		}
		/// <summary>
		/// 日志级别
		/// </summary>		
		public string LogLevel
		{
			get
			{
				return entity.LogLevel;
			}
			set
			{
				entity.LogLevel = value;
			}
		}
		/// <summary>
		/// 日志类型
		/// </summary>		
		public string LogType
		{
			get
			{
				return entity.LogType;
			}
			set
			{
				entity.LogType = value;
			}
		}
		/// <summary>
		/// 日志日期
		/// </summary>		
		public DateTime LogDate
		{
			get
			{
				return entity.LogDate;
			}
			set
			{
				entity.LogDate = value;
			}
		}
		/// <summary>
		/// 日志来源
		/// </summary>		
		public string LogSource
		{
			get
			{
				return entity.LogSource;
			}
			set
			{
				entity.LogSource = value;
			}
		}
		/// <summary>
		/// 日志用户
		/// </summary>		
		public string LogUser
		{
			get
			{
				return entity.LogUser;
			}
			set
			{
				entity.LogUser = value;
			}
		}
		/// <summary>
		/// 日志内容
		/// </summary>		
		public string LogDescrption
		{
			get
			{
				return entity.LogDescrption;
			}
			set
			{
				entity.LogDescrption = value;
			}
		}
		/// <summary>
		/// 日志请求信息
		/// </summary>		
		public string LogRequestInfo
		{
			get
			{
				return entity.LogRequestInfo;
			}
			set
			{
				entity.LogRequestInfo = value;
			}
		}
		/// <summary>
		/// 日志相关模块
		/// </summary>		
		public int? LogRelateMoudleID
		{
			get
			{
				return entity.LogRelateMoudleID;
			}
			set
			{
				entity.LogRelateMoudleID = value;
			}
		}
		/// <summary>
		/// 日志相关模块数据ID
		/// </summary>		
		public int? LogRelateMoudleDataID
		{
			get
			{
				return entity.LogRelateMoudleDataID;
			}
			set
			{
				entity.LogRelateMoudleDataID = value;
			}
		}
		/// <summary>
		/// 日志相关用户ID
		/// </summary>		
		public int? LogRelateUserID
		{
			get
			{
				return entity.LogRelateUserID;
			}
			set
			{
				entity.LogRelateUserID = value;
			}
		}
		/// <summary>
		/// 日志相关时间
		/// </summary>		
		public DateTime? LogRelateDateTime
		{
			get
			{
				return entity.LogRelateDateTime;
			}
			set
			{
				entity.LogRelateDateTime = value;
			}
		}
		#endregion 







        #region Static Common Data Operation
		
		internal static List<SystemLogWrapper> ConvertToWrapperList(List<SystemLogEntity> entitylist)
        {
            List<SystemLogWrapper> list = new List<SystemLogWrapper>();
            foreach (SystemLogEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemLogWrapper> ConvertToWrapperList(IList<SystemLogEntity> entitylist)
        {
            List<SystemLogWrapper> list = new List<SystemLogWrapper>();
            foreach (SystemLogEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemLogEntity> ConvertToEntityList(List<SystemLogWrapper> wrapperlist)
        {
            List<SystemLogEntity> list = new List<SystemLogEntity>();
            foreach (SystemLogWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemLogWrapper ConvertEntityToWrapper(SystemLogEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.LogID == 0)
                return null;

            return new SystemLogWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

