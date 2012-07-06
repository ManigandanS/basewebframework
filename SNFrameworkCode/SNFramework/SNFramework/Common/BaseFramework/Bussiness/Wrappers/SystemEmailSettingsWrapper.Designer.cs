// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
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
    public partial class SystemEmailSettingsWrapper    : BaseSpringNHibernateWrapper<SystemEmailSettingsEntity, ISystemEmailSettingsServiceProxy, SystemEmailSettingsWrapper,int>
    {
        #region Member

		internal static readonly ISystemEmailSettingsServiceProxy businessProxy = ((Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)(ContextRegistry.GetContext().GetObject("BaseFrameworkServiceProxyContainerIocID", typeof(Legendigital.Framework.Common.BaseFramework.Bussiness.ServiceProxys.Tables.Container.BaseFrameworkServiceProxyContainer)))).SystemEmailSettingsServiceProxyInstance;
		
		
		internal SystemEmailSettingsEntity Entity
        {
            get { return this.entity; }
        }
		
        #endregion

        #region Construtor
		public SystemEmailSettingsWrapper() : base(new SystemEmailSettingsEntity())
        {
            
        }

        internal SystemEmailSettingsWrapper(SystemEmailSettingsEntity entityObj)
            : base(entityObj)
        {
        }
		#endregion

        #region Process Column Name
        private static string ProcessColumnName(string columnName)
        {
            switch (columnName)
            {
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

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemEmailSettingsEntity";
		public static readonly string PROPERTY_NAME_EMAILSETTINGID = "EmailSettingID";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_DESCRIPRSION = "Descriprsion";
		public static readonly string PROPERTY_NAME_HOST = "Host";
		public static readonly string PROPERTY_NAME_PORT = "Port";
		public static readonly string PROPERTY_NAME_SSL = "Ssl";
		public static readonly string PROPERTY_NAME_FROMEMAIL = "FromEmail";
		public static readonly string PROPERTY_NAME_FROMNAME = "FromName";
		public static readonly string PROPERTY_NAME_LOGINEMAIL = "LoginEmail";
		public static readonly string PROPERTY_NAME_LOGINPASSWORD = "LoginPassword";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_ISDEFAULT = "IsDefault";
		public static readonly string PROPERTY_NAME_ORDERINDEX = "OrderIndex";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
      	
	
	
		 
		
		
		
		


		#region Public Property
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int EmailSettingID
		{
			get
			{
				return entity.EmailSettingID;
			}
			set
			{
				entity.EmailSettingID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
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
		[DataMember]
		public string Code
		{
			get
			{
				return entity.Code;
			}
			set
			{
				entity.Code = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string Descriprsion
		{
			get
			{
				return entity.Descriprsion;
			}
			set
			{
				entity.Descriprsion = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string Host
		{
			get
			{
				return entity.Host;
			}
			set
			{
				entity.Host = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string Port
		{
			get
			{
				return entity.Port;
			}
			set
			{
				entity.Port = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public bool? Ssl
		{
			get
			{
				return entity.Ssl;
			}
			set
			{
				entity.Ssl = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string FromEmail
		{
			get
			{
				return entity.FromEmail;
			}
			set
			{
				entity.FromEmail = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string FromName
		{
			get
			{
				return entity.FromName;
			}
			set
			{
				entity.FromName = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string LoginEmail
		{
			get
			{
				return entity.LoginEmail;
			}
			set
			{
				entity.LoginEmail = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string LoginPassword
		{
			get
			{
				return entity.LoginPassword;
			}
			set
			{
				entity.LoginPassword = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
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
		[DataMember]
		public bool? IsDefault
		{
			get
			{
				return entity.IsDefault;
			}
			set
			{
				entity.IsDefault = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? OrderIndex
		{
			get
			{
				return entity.OrderIndex;
			}
			set
			{
				entity.OrderIndex = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
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
		[DataMember]
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
		[DataMember]
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
		[DataMember]
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
		[DataMember]
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
		
		
      	
   
		#endregion


        #region "FKQuery"



        #endregion








        #region Static Common Data Operation
		
		internal static List<SystemEmailSettingsWrapper> ConvertToWrapperList(List<SystemEmailSettingsEntity> entitylist)
        {
            List<SystemEmailSettingsWrapper> list = new List<SystemEmailSettingsWrapper>();
            foreach (SystemEmailSettingsEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SystemEmailSettingsWrapper> ConvertToWrapperList(IList<SystemEmailSettingsEntity> entitylist)
        {
            List<SystemEmailSettingsWrapper> list = new List<SystemEmailSettingsWrapper>();
            foreach (SystemEmailSettingsEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SystemEmailSettingsEntity> ConvertToEntityList(List<SystemEmailSettingsWrapper> wrapperlist)
        {
            List<SystemEmailSettingsEntity> list = new List<SystemEmailSettingsEntity>();
            foreach (SystemEmailSettingsWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SystemEmailSettingsWrapper ConvertEntityToWrapper(SystemEmailSettingsEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.EmailSettingID == 0)
                return null;

            return new SystemEmailSettingsWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

