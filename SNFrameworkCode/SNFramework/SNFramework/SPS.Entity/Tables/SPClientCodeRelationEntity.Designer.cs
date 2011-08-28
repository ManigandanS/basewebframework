// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SPS.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public partial class SPClientCodeRelationEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPClientCodeRelationEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_CODEID = "CodeID";
		public static readonly string PROPERTY_NAME_CLIENTID = "ClientID";
		public static readonly string PROPERTY_NAME_PRICE = "Price";
		public static readonly string PROPERTY_NAME_INTERCEPTRATE = "InterceptRate";
		public static readonly string PROPERTY_NAME_USECLIENTDEFAULTSYCNSETTING = "UseClientDefaultSycnSetting";
		public static readonly string PROPERTY_NAME_SYNCDATA = "SyncData";
		public static readonly string PROPERTY_NAME_SYCNRESENDFAILEDDATA = "SycnResendFailedData";
		public static readonly string PROPERTY_NAME_SYCNRETRYTIMES = "SycnRetryTimes";
		public static readonly string PROPERTY_NAME_SYNCTYPE = "SyncType";
		public static readonly string PROPERTY_NAME_SYCNDATAURL = "SycnDataUrl";
		public static readonly string PROPERTY_NAME_SYCNOKMESSAGE = "SycnOkMessage";
		public static readonly string PROPERTY_NAME_SYCNFAILEDMESSAGE = "SycnFailedMessage";
		public static readonly string PROPERTY_NAME_STARTDATE = "StartDate";
		public static readonly string PROPERTY_NAME_ENDDATE = "EndDate";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _id;
		private SPCodeEntity _codeID;
		private SPSClientEntity _clientID;
		private decimal? _price;
		private decimal? _interceptRate;
		private bool? _useClientDefaultSycnSetting;
		private bool? _syncData;
		private bool? _sycnResendFailedData;
		private string _sycnRetryTimes;
		private string _syncType;
		private string _sycnDataUrl;
		private string _sycnOkMessage;
		private string _sycnFailedMessage;
		private DateTime? _startDate;
		private DateTime? _endDate;
		private bool? _isEnable;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPClientCodeRelationEntity()
		{
			_id = 0;
			_codeID = null;
			_clientID = null;
			_price = null;
			_interceptRate = null;
			_useClientDefaultSycnSetting = null;
			_syncData = null;
			_sycnResendFailedData = null;
			_sycnRetryTimes = null;
			_syncType = null;
			_sycnDataUrl = null;
			_sycnOkMessage = null;
			_sycnFailedMessage = null;
			_startDate = null;
			_endDate = null;
			_isEnable = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPClientCodeRelationEntity( int id, SPCodeEntity codeID, SPSClientEntity clientID, decimal? price, decimal? interceptRate, bool? useClientDefaultSycnSetting, bool? syncData, bool? sycnResendFailedData, string sycnRetryTimes, string syncType, string sycnDataUrl, string sycnOkMessage, string sycnFailedMessage, DateTime? startDate, DateTime? endDate, bool? isEnable)
		{
			_id = id;
			_codeID = codeID;
			_clientID = clientID;
			_price = price;
			_interceptRate = interceptRate;
			_useClientDefaultSycnSetting = useClientDefaultSycnSetting;
			_syncData = syncData;
			_sycnResendFailedData = sycnResendFailedData;
			_sycnRetryTimes = sycnRetryTimes;
			_syncType = syncType;
			_sycnDataUrl = sycnDataUrl;
			_sycnOkMessage = sycnOkMessage;
			_sycnFailedMessage = sycnFailedMessage;
			_startDate = startDate;
			_endDate = endDate;
			_isEnable = isEnable;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int Id
		{
			get { return _id; }

			set	
			{
				_isChanged |= (_id != value); _id = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SPCodeEntity CodeID
		{
			get { return _codeID; }

			set	
			{
				_isChanged |= (_codeID != value); _codeID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SPSClientEntity ClientID
		{
			get { return _clientID; }

			set	
			{
				_isChanged |= (_clientID != value); _clientID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual decimal? Price
		{
			get { return _price; }

			set	
			{
				_isChanged |= (_price != value); _price = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual decimal? InterceptRate
		{
			get { return _interceptRate; }

			set	
			{
				_isChanged |= (_interceptRate != value); _interceptRate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? UseClientDefaultSycnSetting
		{
			get { return _useClientDefaultSycnSetting; }

			set	
			{
				_isChanged |= (_useClientDefaultSycnSetting != value); _useClientDefaultSycnSetting = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? SyncData
		{
			get { return _syncData; }

			set	
			{
				_isChanged |= (_syncData != value); _syncData = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? SycnResendFailedData
		{
			get { return _sycnResendFailedData; }

			set	
			{
				_isChanged |= (_sycnResendFailedData != value); _sycnResendFailedData = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string SycnRetryTimes
		{
			get { return _sycnRetryTimes; }

			set	
			{

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for SycnRetryTimes", value, value.ToString());
				_isChanged |= (_sycnRetryTimes != value); _sycnRetryTimes = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string SyncType
		{
			get { return _syncType; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for SyncType", value, value.ToString());
				_isChanged |= (_syncType != value); _syncType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string SycnDataUrl
		{
			get { return _sycnDataUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for SycnDataUrl", value, value.ToString());
				_isChanged |= (_sycnDataUrl != value); _sycnDataUrl = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string SycnOkMessage
		{
			get { return _sycnOkMessage; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for SycnOkMessage", value, value.ToString());
				_isChanged |= (_sycnOkMessage != value); _sycnOkMessage = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string SycnFailedMessage
		{
			get { return _sycnFailedMessage; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for SycnFailedMessage", value, value.ToString());
				_isChanged |= (_sycnFailedMessage != value); _sycnFailedMessage = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? StartDate
		{
			get { return _startDate; }

			set	
			{
				_isChanged |= (_startDate != value); _startDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? EndDate
		{
			get { return _endDate; }

			set	
			{
				_isChanged |= (_endDate != value); _endDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? IsEnable
		{
			get { return _isEnable; }

			set	
			{
				_isChanged |= (_isEnable != value); _isEnable = value;
			}
		}
		/// <summary>
		/// 返回对象是否被改变。
		/// </summary>
		public virtual bool IsChanged
		{
			get { return _isChanged; }
		}
		
		/// <summary>
		/// Returns whether or not the object has changed it's values.
		/// </summary>
		public virtual bool IsDeleted
		{
			get { return _isDeleted; }
		}
		
		#endregion 

        #region 公共方法
		
		/// <summary>
		/// mark the item as deleted
		/// </summary>
		public virtual void MarkAsDeleted()
		{
			_isDeleted = true;
			_isChanged = true;
		}
		
		#endregion

		#region Equals 和 HashCode 方法覆盖
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			
			SPClientCodeRelationEntity castObj = (SPClientCodeRelationEntity)obj;
			
			return ( castObj != null ) && ( this._id == castObj.Id );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _id.GetHashCode();

			return hash; 
		}
		#endregion
	
		#region ICloneable methods
		
		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}
		
		#endregion
	
	}
}
