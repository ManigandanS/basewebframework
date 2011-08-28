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
	public partial class SPSClientEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPSClientEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_USERID = "UserID";
		public static readonly string PROPERTY_NAME_SYNCDATA = "SyncData";
		public static readonly string PROPERTY_NAME_SYCNRESENDFAILEDDATA = "SycnResendFailedData";
		public static readonly string PROPERTY_NAME_SYCNRETRYTIMES = "SycnRetryTimes";
		public static readonly string PROPERTY_NAME_SYNCTYPE = "SyncType";
		public static readonly string PROPERTY_NAME_SYCNDATAURL = "SycnDataUrl";
		public static readonly string PROPERTY_NAME_SYCNOKMESSAGE = "SycnOkMessage";
		public static readonly string PROPERTY_NAME_SYCNFAILEDMESSAGE = "SycnFailedMessage";
		public static readonly string PROPERTY_NAME_ALIAS = "Alias";
		public static readonly string PROPERTY_NAME_INTERCEPTRATE = "InterceptRate";
		public static readonly string PROPERTY_NAME_DEFAULTPRICE = "DefaultPrice";
		public static readonly string PROPERTY_NAME_DEFAULTSHOWRECORDDAYS = "DefaultShowRecordDays";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _id;
		private string _name;
		private string _description;
		private int? _userID;
		private bool? _syncData;
		private bool? _sycnResendFailedData;
		private string _sycnRetryTimes;
		private string _syncType;
		private string _sycnDataUrl;
		private string _sycnOkMessage;
		private string _sycnFailedMessage;
		private string _alias;
		private decimal? _interceptRate;
		private decimal? _defaultPrice;
		private int? _defaultShowRecordDays;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPSClientEntity()
		{
			_id = 0;
			_name = null;
			_description = null;
			_userID = null;
			_syncData = null;
			_sycnResendFailedData = null;
			_sycnRetryTimes = null;
			_syncType = null;
			_sycnDataUrl = null;
			_sycnOkMessage = null;
			_sycnFailedMessage = null;
			_alias = null;
			_interceptRate = null;
			_defaultPrice = null;
			_defaultShowRecordDays = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPSClientEntity( int id, string name, string description, int? userID, bool? syncData, bool? sycnResendFailedData, string sycnRetryTimes, string syncType, string sycnDataUrl, string sycnOkMessage, string sycnFailedMessage, string alias, decimal? interceptRate, decimal? defaultPrice, int? defaultShowRecordDays)
		{
			_id = id;
			_name = name;
			_description = description;
			_userID = userID;
			_syncData = syncData;
			_sycnResendFailedData = sycnResendFailedData;
			_sycnRetryTimes = sycnRetryTimes;
			_syncType = syncType;
			_sycnDataUrl = sycnDataUrl;
			_sycnOkMessage = sycnOkMessage;
			_sycnFailedMessage = sycnFailedMessage;
			_alias = alias;
			_interceptRate = interceptRate;
			_defaultPrice = defaultPrice;
			_defaultShowRecordDays = defaultShowRecordDays;
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
		public virtual string Name
		{
			get { return _name; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_isChanged |= (_name != value); _name = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Description
		{
			get { return _description; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_isChanged |= (_description != value); _description = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? UserID
		{
			get { return _userID; }

			set	
			{
				_isChanged |= (_userID != value); _userID = value;
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
		public virtual string Alias
		{
			get { return _alias; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for Alias", value, value.ToString());
				_isChanged |= (_alias != value); _alias = value;
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
		public virtual decimal? DefaultPrice
		{
			get { return _defaultPrice; }

			set	
			{
				_isChanged |= (_defaultPrice != value); _defaultPrice = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? DefaultShowRecordDays
		{
			get { return _defaultShowRecordDays; }

			set	
			{
				_isChanged |= (_defaultShowRecordDays != value); _defaultShowRecordDays = value;
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
			
			SPSClientEntity castObj = (SPSClientEntity)obj;
			
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
