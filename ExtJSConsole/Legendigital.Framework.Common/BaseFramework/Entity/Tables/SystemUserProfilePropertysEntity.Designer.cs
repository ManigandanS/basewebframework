// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	public partial class SystemUserProfilePropertysEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemUserProfilePropertysEntity";
		public static readonly string PROPERTY_NAME_PROPERTYID = "PropertyID";
		public static readonly string PROPERTY_NAME_PROPERTYNAME = "PropertyName";
		public static readonly string PROPERTY_NAME_PROPERTYDESCRIPTION = "PropertyDescription";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _propertyID;
		private string _propertyName;
		private string _propertyDescription;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemUserProfilePropertysEntity()
		{
			_propertyID = 0;
			_propertyName = String.Empty;
			_propertyDescription = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemUserProfilePropertysEntity( int propertyID, string propertyName, string propertyDescription)
		{
			_propertyID = propertyID;
			_propertyName = propertyName;
			_propertyDescription = propertyDescription;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>		
		public virtual int PropertyID
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
		public virtual string PropertyName
		{
			get { return _propertyName; }

			set	
			{

				if( value != null && value.Length > 1000)
					throw new ArgumentOutOfRangeException("Invalid value for PropertyName", value, value.ToString());
				_isChanged |= (_propertyName != value); _propertyName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>		
		public virtual string PropertyDescription
		{
			get { return _propertyDescription; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for PropertyDescription", value, value.ToString());
				_isChanged |= (_propertyDescription != value); _propertyDescription = value;
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
			
			SystemUserProfilePropertysEntity castObj = (SystemUserProfilePropertysEntity)obj;
			
			return ( castObj != null ) && ( this._propertyID == castObj.PropertyID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _propertyID.GetHashCode();

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
