// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Spring.Context.Support;
using Common.Logging;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using SPS.Entity.Tables;
using SPS.Bussiness.ServiceProxys.Tables.Container;
using SPS.Bussiness.ServiceProxys.Tables;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;

namespace SPS.Bussiness.Wrappers
{
    public partial class SPAdAssignedHistortyWrapper    //: BaseSpringNHibernateWrapper<SPAdAssignedHistortyEntity, ISPAdAssignedHistortyServiceProxy, SPAdAssignedHistortyWrapper,int>
    {
        #region Member

		internal static readonly ISPAdAssignedHistortyServiceProxy businessProxy = ((SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPAdAssignedHistortyServiceProxyInstance;
		
		
		internal SPAdAssignedHistortyEntity Entity
        {
            get { return this.entity; }
        }
		
        #endregion

        #region Construtor
		public SPAdAssignedHistortyWrapper() : base(new SPAdAssignedHistortyEntity())
        {
            
        }

        internal SPAdAssignedHistortyWrapper(SPAdAssignedHistortyEntity entityObj)
            : base(entityObj)
        {
        }
		#endregion

        #region Process Column Name
        private static string ProcessColumnName(string columnName)
        {
            switch (columnName)
            {
		        case "SPAdPackID_Id":
					return PROPERTY_SPADPACKID_ID;
		        case "SPAdPackID_SPAdID":
					return PROPERTY_SPADPACKID_SPADID;
		        case "SPAdPackID_Name":
					return PROPERTY_SPADPACKID_NAME;
		        case "SPAdPackID_Code":
					return PROPERTY_SPADPACKID_CODE;
		        case "SPAdPackID_Description":
					return PROPERTY_SPADPACKID_DESCRIPTION;
		        case "SPAdPackID_AdPrice":
					return PROPERTY_SPADPACKID_ADPRICE;
		        case "SPClientID_Id":
					return PROPERTY_SPCLIENTID_ID;
		        case "SPClientID_Name":
					return PROPERTY_SPCLIENTID_NAME;
		        case "SPClientID_Description":
					return PROPERTY_SPCLIENTID_DESCRIPTION;
		        case "SPClientID_UserID":
					return PROPERTY_SPCLIENTID_USERID;
		        case "SPClientID_IsDefaultClient":
					return PROPERTY_SPCLIENTID_ISDEFAULTCLIENT;
		        case "SPClientID_SyncData":
					return PROPERTY_SPCLIENTID_SYNCDATA;
		        case "SPClientID_SycnNotInterceptCount":
					return PROPERTY_SPCLIENTID_SYCNNOTINTERCEPTCOUNT;
		        case "SPClientID_SyncDataSetting":
					return PROPERTY_SPCLIENTID_SYNCDATASETTING;
		        case "SPClientID_Alias":
					return PROPERTY_SPCLIENTID_ALIAS;
		        case "SPClientID_IsEnable":
					return PROPERTY_SPCLIENTID_ISENABLE;
		        case "SPClientID_InterceptRate":
					return PROPERTY_SPCLIENTID_INTERCEPTRATE;
		        case "SPClientID_DefaultPrice":
					return PROPERTY_SPCLIENTID_DEFAULTPRICE;
		        case "SPClientID_DefaultShowRecordDays":
					return PROPERTY_SPCLIENTID_DEFAULTSHOWRECORDDAYS;
		        case "SPClientID_ChannelStatus":
					return PROPERTY_SPCLIENTID_CHANNELSTATUS;
		        case "SPClientID_CreateBy":
					return PROPERTY_SPCLIENTID_CREATEBY;
		        case "SPClientID_CreateAt":
					return PROPERTY_SPCLIENTID_CREATEAT;
		        case "SPClientID_LastModifyBy":
					return PROPERTY_SPCLIENTID_LASTMODIFYBY;
		        case "SPClientID_LastModifyAt":
					return PROPERTY_SPCLIENTID_LASTMODIFYAT;
		        case "SPClientID_LastModifyComment":
					return PROPERTY_SPCLIENTID_LASTMODIFYCOMMENT;
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

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPAdAssignedHistortyEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_SPADID = "SPAdID";
		public static readonly string PROPERTY_NAME_SPADPACKID = "SPAdPackID";
		public static readonly string PROPERTY_NAME_SPCLIENTID = "SPClientID";
		public static readonly string PROPERTY_NAME_CLIENTPRICE = "ClientPrice";
		public static readonly string PROPERTY_NAME_STARTDATE = "StartDate";
		public static readonly string PROPERTY_NAME_ENDDATE = "EndDate";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
		#region sPAdPackID字段外键查询字段
        public const string PROPERTY_SPADPACKID_ALIAS_NAME = "SPAdPackID_SPAdAssignedHistortyEntity_Alias";
		public const string PROPERTY_SPADPACKID_ID = "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Id";
		public const string PROPERTY_SPADPACKID_SPADID = "SPAdPackID_SPAdAssignedHistortyEntity_Alias.SPAdID";
		public const string PROPERTY_SPADPACKID_NAME = "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Name";
		public const string PROPERTY_SPADPACKID_CODE = "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Code";
		public const string PROPERTY_SPADPACKID_DESCRIPTION = "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Description";
		public const string PROPERTY_SPADPACKID_ADPRICE = "SPAdPackID_SPAdAssignedHistortyEntity_Alias.AdPrice";
		#endregion
		#region sPClientID字段外键查询字段
        public const string PROPERTY_SPCLIENTID_ALIAS_NAME = "SPClientID_SPAdAssignedHistortyEntity_Alias";
		public const string PROPERTY_SPCLIENTID_ID = "SPClientID_SPAdAssignedHistortyEntity_Alias.Id";
		public const string PROPERTY_SPCLIENTID_NAME = "SPClientID_SPAdAssignedHistortyEntity_Alias.Name";
		public const string PROPERTY_SPCLIENTID_DESCRIPTION = "SPClientID_SPAdAssignedHistortyEntity_Alias.Description";
		public const string PROPERTY_SPCLIENTID_USERID = "SPClientID_SPAdAssignedHistortyEntity_Alias.UserID";
		public const string PROPERTY_SPCLIENTID_ISDEFAULTCLIENT = "SPClientID_SPAdAssignedHistortyEntity_Alias.IsDefaultClient";
		public const string PROPERTY_SPCLIENTID_SYNCDATA = "SPClientID_SPAdAssignedHistortyEntity_Alias.SyncData";
		public const string PROPERTY_SPCLIENTID_SYCNNOTINTERCEPTCOUNT = "SPClientID_SPAdAssignedHistortyEntity_Alias.SycnNotInterceptCount";
		public const string PROPERTY_SPCLIENTID_SYNCDATASETTING = "SPClientID_SPAdAssignedHistortyEntity_Alias.SyncDataSetting";
		public const string PROPERTY_SPCLIENTID_ALIAS = "SPClientID_SPAdAssignedHistortyEntity_Alias.Alias";
		public const string PROPERTY_SPCLIENTID_ISENABLE = "SPClientID_SPAdAssignedHistortyEntity_Alias.IsEnable";
		public const string PROPERTY_SPCLIENTID_INTERCEPTRATE = "SPClientID_SPAdAssignedHistortyEntity_Alias.InterceptRate";
		public const string PROPERTY_SPCLIENTID_DEFAULTPRICE = "SPClientID_SPAdAssignedHistortyEntity_Alias.DefaultPrice";
		public const string PROPERTY_SPCLIENTID_DEFAULTSHOWRECORDDAYS = "SPClientID_SPAdAssignedHistortyEntity_Alias.DefaultShowRecordDays";
		public const string PROPERTY_SPCLIENTID_CHANNELSTATUS = "SPClientID_SPAdAssignedHistortyEntity_Alias.ChannelStatus";
		public const string PROPERTY_SPCLIENTID_CREATEBY = "SPClientID_SPAdAssignedHistortyEntity_Alias.CreateBy";
		public const string PROPERTY_SPCLIENTID_CREATEAT = "SPClientID_SPAdAssignedHistortyEntity_Alias.CreateAt";
		public const string PROPERTY_SPCLIENTID_LASTMODIFYBY = "SPClientID_SPAdAssignedHistortyEntity_Alias.LastModifyBy";
		public const string PROPERTY_SPCLIENTID_LASTMODIFYAT = "SPClientID_SPAdAssignedHistortyEntity_Alias.LastModifyAt";
		public const string PROPERTY_SPCLIENTID_LASTMODIFYCOMMENT = "SPClientID_SPAdAssignedHistortyEntity_Alias.LastModifyComment";
		#endregion
      	
	
	
		 
		
		
		
		


		#region Public Property
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
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
		[DataMember]
		public int? SPAdID
		{
			get
			{
				return entity.SPAdID;
			}
			set
			{
				entity.SPAdID = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public SPAdPackWrapper SPAdPackID
		{
			get
			{
				return SPAdPackWrapper.ConvertEntityToWrapper(entity.SPAdPackID) ;
			}
			set
			{
				entity.SPAdPackID = ((value == null) ? null : value.Entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public SPSClientWrapper SPClientID
		{
			get
			{
				return SPSClientWrapper.ConvertEntityToWrapper(entity.SPClientID) ;
			}
			set
			{
				entity.SPClientID = ((value == null) ? null : value.Entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public decimal? ClientPrice
		{
			get
			{
				return entity.ClientPrice;
			}
			set
			{
				entity.ClientPrice = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public DateTime? StartDate
		{
			get
			{
				return entity.StartDate;
			}
			set
			{
				entity.StartDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public DateTime? EndDate
		{
			get
			{
				return entity.EndDate;
			}
			set
			{
				entity.EndDate = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int CreateBy
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
		public DateTime CreateAt
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
		
		
		#region sPAdPackID字段外键查询字段
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPADPACKID_ID)]
        public int? SPAdPackID_Id
        {
            get
            {
                if (this. SPAdPackID == null)
                    return null;
                return  SPAdPackID.Id;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPADPACKID_SPADID)]
        public SPAdvertisementWrapper SPAdPackID_SPAdID
        {
            get
            {
                if (this. SPAdPackID == null)
                    return null;
                return  SPAdPackID.SPAdID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPADPACKID_NAME)]
        public string SPAdPackID_Name
        {
            get
            {
                if (this. SPAdPackID == null)
                    return null;
                return  SPAdPackID.Name;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPADPACKID_CODE)]
        public string SPAdPackID_Code
        {
            get
            {
                if (this. SPAdPackID == null)
                    return null;
                return  SPAdPackID.Code;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPADPACKID_DESCRIPTION)]
        public string SPAdPackID_Description
        {
            get
            {
                if (this. SPAdPackID == null)
                    return null;
                return  SPAdPackID.Description;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPADPACKID_ADPRICE)]
        public decimal? SPAdPackID_AdPrice
        {
            get
            {
                if (this. SPAdPackID == null)
                    return null;
                return  SPAdPackID.AdPrice;
            }
        }
		#endregion
		#region sPClientID字段外键查询字段
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_ID)]
        public int? SPClientID_Id
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.Id;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_NAME)]
        public string SPClientID_Name
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.Name;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_DESCRIPTION)]
        public string SPClientID_Description
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.Description;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_USERID)]
        public int? SPClientID_UserID
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.UserID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_ISDEFAULTCLIENT)]
        public bool? SPClientID_IsDefaultClient
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.IsDefaultClient;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_SYNCDATA)]
        public bool? SPClientID_SyncData
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.SyncData;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_SYCNNOTINTERCEPTCOUNT)]
        public int? SPClientID_SycnNotInterceptCount
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.SycnNotInterceptCount;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_SYNCDATASETTING)]
        public SPSDataSycnSettingWrapper SPClientID_SyncDataSetting
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.SyncDataSetting;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_ALIAS)]
        public string SPClientID_Alias
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.Alias;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_ISENABLE)]
        public bool? SPClientID_IsEnable
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.IsEnable;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_INTERCEPTRATE)]
        public decimal? SPClientID_InterceptRate
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.InterceptRate;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_DEFAULTPRICE)]
        public decimal? SPClientID_DefaultPrice
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.DefaultPrice;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_DEFAULTSHOWRECORDDAYS)]
        public int? SPClientID_DefaultShowRecordDays
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.DefaultShowRecordDays;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_CHANNELSTATUS)]
        public string SPClientID_ChannelStatus
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.ChannelStatus;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_CREATEBY)]
        public int? SPClientID_CreateBy
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.CreateBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_CREATEAT)]
        public DateTime? SPClientID_CreateAt
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.CreateAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_LASTMODIFYBY)]
        public int? SPClientID_LastModifyBy
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.LastModifyBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_LASTMODIFYAT)]
        public DateTime? SPClientID_LastModifyAt
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.LastModifyAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCLIENTID_LASTMODIFYCOMMENT)]
        public string SPClientID_LastModifyComment
        {
            get
            {
                if (this. SPClientID == null)
                    return null;
                return  SPClientID.LastModifyComment;
            }
        }
		#endregion
      	
   
		#endregion


        #region "FKQuery"
		
        public static List<SPAdAssignedHistortyWrapper> FindAllByOrderByAndFilterAndSPAdPackID(string orderByColumnName, bool isDesc,   SPAdPackWrapper sPAdPackID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndSPAdPackID(orderByColumnName, isDesc,   sPAdPackID.Entity, pageQueryParams));
        }

        public static List<SPAdAssignedHistortyWrapper> FindAllBySPAdPackID(SPAdPackWrapper sPAdPackID)
        {
            return ConvertToWrapperList(businessProxy.FindAllBySPAdPackID(sPAdPackID.Entity));
        }
		
		
        public static List<SPAdAssignedHistortyWrapper> FindAllByOrderByAndFilterAndSPClientID(string orderByColumnName, bool isDesc,   SPSClientWrapper sPClientID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndSPClientID(orderByColumnName, isDesc,   sPClientID.Entity, pageQueryParams));
        }

        public static List<SPAdAssignedHistortyWrapper> FindAllBySPClientID(SPSClientWrapper sPClientID)
        {
            return ConvertToWrapperList(businessProxy.FindAllBySPClientID(sPClientID.Entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SPAdAssignedHistortyWrapper> ConvertToWrapperList(List<SPAdAssignedHistortyEntity> entitylist)
        {
            List<SPAdAssignedHistortyWrapper> list = new List<SPAdAssignedHistortyWrapper>();
            foreach (SPAdAssignedHistortyEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPAdAssignedHistortyWrapper> ConvertToWrapperList(IList<SPAdAssignedHistortyEntity> entitylist)
        {
            List<SPAdAssignedHistortyWrapper> list = new List<SPAdAssignedHistortyWrapper>();
            foreach (SPAdAssignedHistortyEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPAdAssignedHistortyEntity> ConvertToEntityList(List<SPAdAssignedHistortyWrapper> wrapperlist)
        {
            List<SPAdAssignedHistortyEntity> list = new List<SPAdAssignedHistortyEntity>();
            foreach (SPAdAssignedHistortyWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPAdAssignedHistortyWrapper ConvertEntityToWrapper(SPAdAssignedHistortyEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPAdAssignedHistortyWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

