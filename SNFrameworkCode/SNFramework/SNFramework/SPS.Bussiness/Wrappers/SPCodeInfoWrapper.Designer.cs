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
    public partial class SPCodeInfoWrapper    //: BaseSpringNHibernateWrapper<SPCodeInfoEntity, ISPCodeInfoServiceProxy, SPCodeInfoWrapper,int>
    {
        #region Member

		internal static readonly ISPCodeInfoServiceProxy businessProxy = ((SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)(ContextRegistry.GetContext().GetObject("ServiceProxyContainerIocID", typeof(SPS.Bussiness.ServiceProxys.Tables.Container.ServiceProxyContainer)))).SPCodeInfoServiceProxyInstance;
		
		
		internal SPCodeInfoEntity Entity
        {
            get { return this.entity; }
        }
		
        #endregion

        #region Construtor
		public SPCodeInfoWrapper() : base(new SPCodeInfoEntity())
        {
            
        }

        internal SPCodeInfoWrapper(SPCodeInfoEntity entityObj)
            : base(entityObj)
        {
        }
		#endregion

        #region Process Column Name
        private static string ProcessColumnName(string columnName)
        {
            switch (columnName)
            {
		        case "SPCodeID_Id":
					return PROPERTY_SPCODEID_ID;
		        case "SPCodeID_Name":
					return PROPERTY_SPCODEID_NAME;
		        case "SPCodeID_Description":
					return PROPERTY_SPCODEID_DESCRIPTION;
		        case "SPCodeID_Code":
					return PROPERTY_SPCODEID_CODE;
		        case "SPCodeID_CodeType":
					return PROPERTY_SPCODEID_CODETYPE;
		        case "SPCodeID_ChannelID":
					return PROPERTY_SPCODEID_CHANNELID;
		        case "SPCodeID_Mo":
					return PROPERTY_SPCODEID_MO;
		        case "SPCodeID_MOType":
					return PROPERTY_SPCODEID_MOTYPE;
		        case "SPCodeID_MOLength":
					return PROPERTY_SPCODEID_MOLENGTH;
		        case "SPCodeID_OrderIndex":
					return PROPERTY_SPCODEID_ORDERINDEX;
		        case "SPCodeID_SPCode":
					return PROPERTY_SPCODEID_SPCODE;
		        case "SPCodeID_SPCodeType":
					return PROPERTY_SPCODEID_SPCODETYPE;
		        case "SPCodeID_SPCodeLength":
					return PROPERTY_SPCODEID_SPCODELENGTH;
		        case "SPCodeID_HasFilters":
					return PROPERTY_SPCODEID_HASFILTERS;
		        case "SPCodeID_HasParamsConvert":
					return PROPERTY_SPCODEID_HASPARAMSCONVERT;
		        case "SPCodeID_IsDiable":
					return PROPERTY_SPCODEID_ISDIABLE;
		        case "SPCodeID_Price":
					return PROPERTY_SPCODEID_PRICE;
		        case "SPCodeID_OperationType":
					return PROPERTY_SPCODEID_OPERATIONTYPE;
		        case "SPCodeID_HasDayTotalLimit":
					return PROPERTY_SPCODEID_HASDAYTOTALLIMIT;
		        case "SPCodeID_DayTotalLimitCount":
					return PROPERTY_SPCODEID_DAYTOTALLIMITCOUNT;
		        case "SPCodeID_HasPhoneLimit":
					return PROPERTY_SPCODEID_HASPHONELIMIT;
		        case "SPCodeID_HasDayMonthLimit":
					return PROPERTY_SPCODEID_HASDAYMONTHLIMIT;
		        case "SPCodeID_PhoneLimitDayCount":
					return PROPERTY_SPCODEID_PHONELIMITDAYCOUNT;
		        case "SPCodeID_PhoneLimitMonthCount":
					return PROPERTY_SPCODEID_PHONELIMITMONTHCOUNT;
		        case "SPCodeID_PhoneLimitType":
					return PROPERTY_SPCODEID_PHONELIMITTYPE;
		        case "SPCodeID_LimitProvince":
					return PROPERTY_SPCODEID_LIMITPROVINCE;
		        case "SPCodeID_LimitProvinceArea":
					return PROPERTY_SPCODEID_LIMITPROVINCEAREA;
		        case "SPCodeID_ParentID":
					return PROPERTY_SPCODEID_PARENTID;
		        case "SPCodeID_IsMatchCase":
					return PROPERTY_SPCODEID_ISMATCHCASE;
		        case "SPCodeID_IsDayTimeLimit":
					return PROPERTY_SPCODEID_ISDAYTIMELIMIT;
		        case "SPCodeID_DayTimeLimitRangeStart":
					return PROPERTY_SPCODEID_DAYTIMELIMITRANGESTART;
		        case "SPCodeID_DayTimeLimitRangeEnd":
					return PROPERTY_SPCODEID_DAYTIMELIMITRANGEEND;
		        case "SPCodeID_ChannelStatus":
					return PROPERTY_SPCODEID_CHANNELSTATUS;
		        case "SPCodeID_CreateBy":
					return PROPERTY_SPCODEID_CREATEBY;
		        case "SPCodeID_CreateAt":
					return PROPERTY_SPCODEID_CREATEAT;
		        case "SPCodeID_LastModifyBy":
					return PROPERTY_SPCODEID_LASTMODIFYBY;
		        case "SPCodeID_LastModifyAt":
					return PROPERTY_SPCODEID_LASTMODIFYAT;
		        case "SPCodeID_LastModifyComment":
					return PROPERTY_SPCODEID_LASTMODIFYCOMMENT;
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

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPCodeInfoEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_SPCODEID = "SPCodeID";
		public static readonly string PROPERTY_NAME_PROVINCE = "Province";
		public static readonly string PROPERTY_NAME_DISABLECITY = "DisableCity";
		public static readonly string PROPERTY_NAME_DAYLIMIT = "DayLimit";
		public static readonly string PROPERTY_NAME_MONTHLIMIT = "MonthLimit";
		public static readonly string PROPERTY_NAME_SENDTEXT = "SendText";
		
        #endregion
	
 
		#region sPCodeID字段外键查询字段
        public const string PROPERTY_SPCODEID_ALIAS_NAME = "SPCodeID_SPCodeInfoEntity_Alias";
		public const string PROPERTY_SPCODEID_ID = "SPCodeID_SPCodeInfoEntity_Alias.Id";
		public const string PROPERTY_SPCODEID_NAME = "SPCodeID_SPCodeInfoEntity_Alias.Name";
		public const string PROPERTY_SPCODEID_DESCRIPTION = "SPCodeID_SPCodeInfoEntity_Alias.Description";
		public const string PROPERTY_SPCODEID_CODE = "SPCodeID_SPCodeInfoEntity_Alias.Code";
		public const string PROPERTY_SPCODEID_CODETYPE = "SPCodeID_SPCodeInfoEntity_Alias.CodeType";
		public const string PROPERTY_SPCODEID_CHANNELID = "SPCodeID_SPCodeInfoEntity_Alias.ChannelID";
		public const string PROPERTY_SPCODEID_MO = "SPCodeID_SPCodeInfoEntity_Alias.Mo";
		public const string PROPERTY_SPCODEID_MOTYPE = "SPCodeID_SPCodeInfoEntity_Alias.MOType";
		public const string PROPERTY_SPCODEID_MOLENGTH = "SPCodeID_SPCodeInfoEntity_Alias.MOLength";
		public const string PROPERTY_SPCODEID_ORDERINDEX = "SPCodeID_SPCodeInfoEntity_Alias.OrderIndex";
		public const string PROPERTY_SPCODEID_SPCODE = "SPCodeID_SPCodeInfoEntity_Alias.SPCode";
		public const string PROPERTY_SPCODEID_SPCODETYPE = "SPCodeID_SPCodeInfoEntity_Alias.SPCodeType";
		public const string PROPERTY_SPCODEID_SPCODELENGTH = "SPCodeID_SPCodeInfoEntity_Alias.SPCodeLength";
		public const string PROPERTY_SPCODEID_HASFILTERS = "SPCodeID_SPCodeInfoEntity_Alias.HasFilters";
		public const string PROPERTY_SPCODEID_HASPARAMSCONVERT = "SPCodeID_SPCodeInfoEntity_Alias.HasParamsConvert";
		public const string PROPERTY_SPCODEID_ISDIABLE = "SPCodeID_SPCodeInfoEntity_Alias.IsDiable";
		public const string PROPERTY_SPCODEID_PRICE = "SPCodeID_SPCodeInfoEntity_Alias.Price";
		public const string PROPERTY_SPCODEID_OPERATIONTYPE = "SPCodeID_SPCodeInfoEntity_Alias.OperationType";
		public const string PROPERTY_SPCODEID_HASDAYTOTALLIMIT = "SPCodeID_SPCodeInfoEntity_Alias.HasDayTotalLimit";
		public const string PROPERTY_SPCODEID_DAYTOTALLIMITCOUNT = "SPCodeID_SPCodeInfoEntity_Alias.DayTotalLimitCount";
		public const string PROPERTY_SPCODEID_HASPHONELIMIT = "SPCodeID_SPCodeInfoEntity_Alias.HasPhoneLimit";
		public const string PROPERTY_SPCODEID_HASDAYMONTHLIMIT = "SPCodeID_SPCodeInfoEntity_Alias.HasDayMonthLimit";
		public const string PROPERTY_SPCODEID_PHONELIMITDAYCOUNT = "SPCodeID_SPCodeInfoEntity_Alias.PhoneLimitDayCount";
		public const string PROPERTY_SPCODEID_PHONELIMITMONTHCOUNT = "SPCodeID_SPCodeInfoEntity_Alias.PhoneLimitMonthCount";
		public const string PROPERTY_SPCODEID_PHONELIMITTYPE = "SPCodeID_SPCodeInfoEntity_Alias.PhoneLimitType";
		public const string PROPERTY_SPCODEID_LIMITPROVINCE = "SPCodeID_SPCodeInfoEntity_Alias.LimitProvince";
		public const string PROPERTY_SPCODEID_LIMITPROVINCEAREA = "SPCodeID_SPCodeInfoEntity_Alias.LimitProvinceArea";
		public const string PROPERTY_SPCODEID_PARENTID = "SPCodeID_SPCodeInfoEntity_Alias.ParentID";
		public const string PROPERTY_SPCODEID_ISMATCHCASE = "SPCodeID_SPCodeInfoEntity_Alias.IsMatchCase";
		public const string PROPERTY_SPCODEID_ISDAYTIMELIMIT = "SPCodeID_SPCodeInfoEntity_Alias.IsDayTimeLimit";
		public const string PROPERTY_SPCODEID_DAYTIMELIMITRANGESTART = "SPCodeID_SPCodeInfoEntity_Alias.DayTimeLimitRangeStart";
		public const string PROPERTY_SPCODEID_DAYTIMELIMITRANGEEND = "SPCodeID_SPCodeInfoEntity_Alias.DayTimeLimitRangeEnd";
		public const string PROPERTY_SPCODEID_CHANNELSTATUS = "SPCodeID_SPCodeInfoEntity_Alias.ChannelStatus";
		public const string PROPERTY_SPCODEID_CREATEBY = "SPCodeID_SPCodeInfoEntity_Alias.CreateBy";
		public const string PROPERTY_SPCODEID_CREATEAT = "SPCodeID_SPCodeInfoEntity_Alias.CreateAt";
		public const string PROPERTY_SPCODEID_LASTMODIFYBY = "SPCodeID_SPCodeInfoEntity_Alias.LastModifyBy";
		public const string PROPERTY_SPCODEID_LASTMODIFYAT = "SPCodeID_SPCodeInfoEntity_Alias.LastModifyAt";
		public const string PROPERTY_SPCODEID_LASTMODIFYCOMMENT = "SPCodeID_SPCodeInfoEntity_Alias.LastModifyComment";
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
		public SPCodeWrapper SPCodeID
		{
			get
			{
				return SPCodeWrapper.ConvertEntityToWrapper(entity.SPCodeID) ;
			}
			set
			{
				entity.SPCodeID = ((value == null) ? null : value.Entity);
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
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
		[DataMember]
		public string DisableCity
		{
			get
			{
				return entity.DisableCity;
			}
			set
			{
				entity.DisableCity = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string DayLimit
		{
			get
			{
				return entity.DayLimit;
			}
			set
			{
				entity.DayLimit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string MonthLimit
		{
			get
			{
				return entity.MonthLimit;
			}
			set
			{
				entity.MonthLimit = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string SendText
		{
			get
			{
				return entity.SendText;
			}
			set
			{
				entity.SendText = value;
			}
		}
		#endregion 


		#region Query Property
		
		
		#region sPCodeID字段外键查询字段
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_ID)]
        public int? SPCodeID_Id
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.Id;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_NAME)]
        public string SPCodeID_Name
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.Name;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_DESCRIPTION)]
        public string SPCodeID_Description
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.Description;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_CODE)]
        public string SPCodeID_Code
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.Code;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_CODETYPE)]
        public string SPCodeID_CodeType
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.CodeType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_CHANNELID)]
        public SPChannelWrapper SPCodeID_ChannelID
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.ChannelID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_MO)]
        public string SPCodeID_Mo
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.Mo;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_MOTYPE)]
        public string SPCodeID_MOType
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.MOType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_MOLENGTH)]
        public int? SPCodeID_MOLength
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.MOLength;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_ORDERINDEX)]
        public int? SPCodeID_OrderIndex
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.OrderIndex;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_SPCODE)]
        public string SPCodeID_SPCode
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.SPCode;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_SPCODETYPE)]
        public string SPCodeID_SPCodeType
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.SPCodeType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_SPCODELENGTH)]
        public int? SPCodeID_SPCodeLength
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.SPCodeLength;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_HASFILTERS)]
        public bool? SPCodeID_HasFilters
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.HasFilters;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_HASPARAMSCONVERT)]
        public bool? SPCodeID_HasParamsConvert
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.HasParamsConvert;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_ISDIABLE)]
        public bool? SPCodeID_IsDiable
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.IsDiable;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_PRICE)]
        public decimal? SPCodeID_Price
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.Price;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_OPERATIONTYPE)]
        public string SPCodeID_OperationType
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.OperationType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_HASDAYTOTALLIMIT)]
        public bool? SPCodeID_HasDayTotalLimit
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.HasDayTotalLimit;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_DAYTOTALLIMITCOUNT)]
        public int? SPCodeID_DayTotalLimitCount
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.DayTotalLimitCount;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_HASPHONELIMIT)]
        public bool? SPCodeID_HasPhoneLimit
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.HasPhoneLimit;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_HASDAYMONTHLIMIT)]
        public bool? SPCodeID_HasDayMonthLimit
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.HasDayMonthLimit;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_PHONELIMITDAYCOUNT)]
        public int? SPCodeID_PhoneLimitDayCount
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.PhoneLimitDayCount;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_PHONELIMITMONTHCOUNT)]
        public int? SPCodeID_PhoneLimitMonthCount
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.PhoneLimitMonthCount;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_PHONELIMITTYPE)]
        public int? SPCodeID_PhoneLimitType
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.PhoneLimitType;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_LIMITPROVINCE)]
        public bool? SPCodeID_LimitProvince
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.LimitProvince;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_LIMITPROVINCEAREA)]
        public string SPCodeID_LimitProvinceArea
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.LimitProvinceArea;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_PARENTID)]
        public SPCodeWrapper SPCodeID_ParentID
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.ParentID;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_ISMATCHCASE)]
        public bool? SPCodeID_IsMatchCase
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.IsMatchCase;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_ISDAYTIMELIMIT)]
        public bool? SPCodeID_IsDayTimeLimit
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.IsDayTimeLimit;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_DAYTIMELIMITRANGESTART)]
        public DateTime? SPCodeID_DayTimeLimitRangeStart
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.DayTimeLimitRangeStart;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_DAYTIMELIMITRANGEEND)]
        public DateTime? SPCodeID_DayTimeLimitRangeEnd
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.DayTimeLimitRangeEnd;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_CHANNELSTATUS)]
        public string SPCodeID_ChannelStatus
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.ChannelStatus;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_CREATEBY)]
        public int? SPCodeID_CreateBy
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.CreateBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_CREATEAT)]
        public DateTime? SPCodeID_CreateAt
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.CreateAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_LASTMODIFYBY)]
        public int? SPCodeID_LastModifyBy
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.LastModifyBy;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_LASTMODIFYAT)]
        public DateTime? SPCodeID_LastModifyAt
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.LastModifyAt;
            }
        }
		[NhibernateQueryPropertyAttribute(MappingColumnName = PROPERTY_SPCODEID_LASTMODIFYCOMMENT)]
        public string SPCodeID_LastModifyComment
        {
            get
            {
                if (this. SPCodeID == null)
                    return null;
                return  SPCodeID.LastModifyComment;
            }
        }
		#endregion
      	
   
		#endregion


        #region "FKQuery"
		
        public static List<SPCodeInfoWrapper> FindAllByOrderByAndFilterAndSPCodeID(string orderByColumnName, bool isDesc,   SPCodeWrapper sPCodeID,  PageQueryParams pageQueryParams)
        {
            return ConvertToWrapperList(businessProxy.FindAllByOrderByAndFilterAndSPCodeID(orderByColumnName, isDesc,   sPCodeID.Entity, pageQueryParams));
        }

        public static List<SPCodeInfoWrapper> FindAllBySPCodeID(SPCodeWrapper sPCodeID)
        {
            return ConvertToWrapperList(businessProxy.FindAllBySPCodeID(sPCodeID.Entity));
        }
		



        #endregion








        #region Static Common Data Operation
		
		internal static List<SPCodeInfoWrapper> ConvertToWrapperList(List<SPCodeInfoEntity> entitylist)
        {
            List<SPCodeInfoWrapper> list = new List<SPCodeInfoWrapper>();
            foreach (SPCodeInfoEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }

		internal static List<SPCodeInfoWrapper> ConvertToWrapperList(IList<SPCodeInfoEntity> entitylist)
        {
            List<SPCodeInfoWrapper> list = new List<SPCodeInfoWrapper>();
            foreach (SPCodeInfoEntity lentity in entitylist)
            {
                list.Add(ConvertEntityToWrapper(lentity));
            }
            return list;
        }
		
		internal static List<SPCodeInfoEntity> ConvertToEntityList(List<SPCodeInfoWrapper> wrapperlist)
        {
            List<SPCodeInfoEntity> list = new List<SPCodeInfoEntity>();
            foreach (SPCodeInfoWrapper wrapper in wrapperlist)
            {
                list.Add(wrapper.entity);
            }
            return list;
        }

        internal static SPCodeInfoWrapper ConvertEntityToWrapper(SPCodeInfoEntity entity)
        {
            if (entity == null)
                return null;
				
            if (entity.Id == 0)
                return null;

            return new SPCodeInfoWrapper(entity);
        }
		
		#endregion

    }//End Class
}// End Namespace

