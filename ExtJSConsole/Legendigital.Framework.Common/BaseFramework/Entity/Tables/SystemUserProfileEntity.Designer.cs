// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public partial class SystemUserProfileEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemUserProfileEntity";
		public static readonly string PROPERTY_NAME_PROFILEID = "ProfileID";
		public static readonly string PROPERTY_NAME_USERID = "UserID";
		public static readonly string PROPERTY_NAME_PROPERTYID = "PropertyID";
		public static readonly string PROPERTY_NAME_PROPERTYVALUESSTRING = "PropertyValuesString";
		public static readonly string PROPERTY_NAME_PROPERTYVALUESBINARY = "PropertyValuesBinary";
		public static readonly string PROPERTY_NAME_LASTUPDATEDDATE = "LastUpdatedDate";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _profileID;
		private SystemUserEntity _userID;
		private SystemUserProfilePropertysEntity _propertyID;
		private string _propertyValuesString;
		private byte[] _propertyValuesBinary;
		private DateTime _lastUpdatedDate;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemUserProfileEntity()
		{
			_profileID = 0;
			_userID = null;
			_propertyID = null;
			_propertyValuesString = null;
			_propertyValuesBinary = null;
			_lastUpdatedDate = DateTime.MinValue;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemUserProfileEntity( int profileID, SystemUserEntity userID, SystemUserProfilePropertysEntity propertyID, string propertyValuesString, byte[] propertyValuesBinary, DateTime lastUpdatedDate)
		{
			_profileID = profileID;
			_userID = userID;
			_propertyID = propertyID;
			_propertyValuesString = propertyValuesString;
			_propertyValuesBinary = propertyValuesBinary;
			_lastUpdatedDate = lastUpdatedDate;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int ProfileID
		{
			get { return _profileID; }

			set	
			{
				_isChanged |= (_profileID != value); _profileID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SystemUserEntity UserID
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
		public virtual SystemUserProfilePropertysEntity PropertyID
		{
			get { return _propertyID; }

			set	
			{
				_isChanged |= (_propertyID != value); _propertyID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string PropertyValuesString
		{
			get { return _propertyValuesString; }

			set	
			{

				if( value != null && value.Length > 510)
					throw new ArgumentOutOfRangeException("Invalid value for PropertyValuesString", value, value.ToString());
				_isChanged |= (_propertyValuesString != value); _propertyValuesString = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual byte[] PropertyValuesBinary
		{
			get { return _propertyValuesBinary; }

			set	
			{

				if( value != null && value.Length > 2147483647)
					throw new ArgumentOutOfRangeException("Invalid value for PropertyValuesBinary", value, value.ToString());
				_isChanged |= (_propertyValuesBinary != value); _propertyValuesBinary = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime LastUpdatedDate
		{
			get { return _lastUpdatedDate; }

			set	
			{
				_isChanged |= (_lastUpdatedDate != value); _lastUpdatedDate = value;
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
			
			SystemUserProfileEntity castObj = (SystemUserProfileEntity)obj;
			
			return ( castObj != null ) && ( this._profileID == castObj.ProfileID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _profileID.GetHashCode();

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
