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
	public partial class SPDayReportEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPDayReportEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_REPORTDATE = "ReportDate";
		public static readonly string PROPERTY_NAME_TOTALCOUNT = "TotalCount";
		public static readonly string PROPERTY_NAME_INTERCEPTCOUNT = "InterceptCount";
		public static readonly string PROPERTY_NAME_DOWNTOTALCOUNT = "DownTotalCount";
		public static readonly string PROPERTY_NAME_DOWNSUCCESS = "DownSuccess";
		public static readonly string PROPERTY_NAME_CLIENTID = "ClientID";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_CODEID = "CodeID";
		public static readonly string PROPERTY_NAME_UPERID = "UperID";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _id;
		private DateTime _reportDate;
		private int _totalCount;
		private int _interceptCount;
		private int _downTotalCount;
		private int _downSuccess;
		private SPSClientEntity _clientID;
		private SPChannelEntity _channelID;
		private SPCodeEntity _codeID;
		private SPUpperEntity _uperID;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPDayReportEntity()
		{
			_id = 0;
			_reportDate = DateTime.MinValue;
			_totalCount = 0;
			_interceptCount = 0;
			_downTotalCount = 0;
			_downSuccess = 0;
			_clientID = null;
			_channelID = null;
			_codeID = null;
			_uperID = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPDayReportEntity( int id, DateTime reportDate, int totalCount, int interceptCount, int downTotalCount, int downSuccess, SPSClientEntity clientID, SPChannelEntity channelID, SPCodeEntity codeID, SPUpperEntity uperID)
		{
			_id = id;
			_reportDate = reportDate;
			_totalCount = totalCount;
			_interceptCount = interceptCount;
			_downTotalCount = downTotalCount;
			_downSuccess = downSuccess;
			_clientID = clientID;
			_channelID = channelID;
			_codeID = codeID;
			_uperID = uperID;
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
		public virtual DateTime ReportDate
		{
			get { return _reportDate; }

			set	
			{
				_isChanged |= (_reportDate != value); _reportDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int TotalCount
		{
			get { return _totalCount; }

			set	
			{
				_isChanged |= (_totalCount != value); _totalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int InterceptCount
		{
			get { return _interceptCount; }

			set	
			{
				_isChanged |= (_interceptCount != value); _interceptCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int DownTotalCount
		{
			get { return _downTotalCount; }

			set	
			{
				_isChanged |= (_downTotalCount != value); _downTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int DownSuccess
		{
			get { return _downSuccess; }

			set	
			{
				_isChanged |= (_downSuccess != value); _downSuccess = value;
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
		public virtual SPChannelEntity ChannelID
		{
			get { return _channelID; }

			set	
			{
				_isChanged |= (_channelID != value); _channelID = value;
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
		public virtual SPUpperEntity UperID
		{
			get { return _uperID; }

			set	
			{
				_isChanged |= (_uperID != value); _uperID = value;
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
			
			SPDayReportEntity castObj = (SPDayReportEntity)obj;
			
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
