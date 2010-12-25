// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	System Navigation Menu
	/// </summary>
	[DataContract]
	public partial class SystemMenuEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemMenuEntity";
		public static readonly string PROPERTY_NAME_MENUID = "MenuID";
		public static readonly string PROPERTY_NAME_MENUNAME = "MenuName";
		public static readonly string PROPERTY_NAME_MENUDESCRIPTION = "MenuDescription";
		public static readonly string PROPERTY_NAME_MENUURL = "MenuUrl";
		public static readonly string PROPERTY_NAME_MENUURLTARGET = "MenuUrlTarget";
		public static readonly string PROPERTY_NAME_MENUICONURL = "MenuIconUrl";
		public static readonly string PROPERTY_NAME_MENUISCATEGORY = "MenuIsCategory";
		public static readonly string PROPERTY_NAME_PARENTMENUID = "ParentMenuID";
		public static readonly string PROPERTY_NAME_MENUORDER = "MenuOrder";
		public static readonly string PROPERTY_NAME_MENUTYPE = "MenuType";
		public static readonly string PROPERTY_NAME_MENUISSYSTEMMENU = "MenuIsSystemMenu";
		public static readonly string PROPERTY_NAME_MENUISENABLE = "MenuIsEnable";
		public static readonly string PROPERTY_NAME_APPLICATIONID = "ApplicationID";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _menuID;
		private string _menuName;
		private string _menuDescription;
		private string _menuUrl;
		private string _menuUrlTarget;
		private string _menuIconUrl;
		private bool _menuIsCategory;
		private SystemMenuEntity _parentMenuID;
		private int? _menuOrder;
		private string _menuType;
		private bool? _menuIsSystemMenu;
		private bool? _menuIsEnable;
		private SystemApplicationEntity _applicationID;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemMenuEntity()
		{
			_menuID = 0;
			_menuName = String.Empty;
			_menuDescription = null;
			_menuUrl = null;
			_menuUrlTarget = null;
			_menuIconUrl = null;
			_menuIsCategory = false;
			_parentMenuID = null;
			_menuOrder = null;
			_menuType = String.Empty;
			_menuIsSystemMenu = null;
			_menuIsEnable = null;
			_applicationID = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemMenuEntity( int menuID, string menuName, string menuDescription, string menuUrl, string menuUrlTarget, string menuIconUrl, bool menuIsCategory, SystemMenuEntity parentMenuID, int? menuOrder, string menuType, bool? menuIsSystemMenu, bool? menuIsEnable, SystemApplicationEntity applicationID)
		{
			_menuID = menuID;
			_menuName = menuName;
			_menuDescription = menuDescription;
			_menuUrl = menuUrl;
			_menuUrlTarget = menuUrlTarget;
			_menuIconUrl = menuIconUrl;
			_menuIsCategory = menuIsCategory;
			_parentMenuID = parentMenuID;
			_menuOrder = menuOrder;
			_menuType = menuType;
			_menuIsSystemMenu = menuIsSystemMenu;
			_menuIsEnable = menuIsEnable;
			_applicationID = applicationID;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// Primary Key
		/// </summary>
		[DataMember]
		public virtual int MenuID
		{
			get { return _menuID; }

			set	
			{
				_isChanged |= (_menuID != value); _menuID = value;
			}
		}

		/// <summary>
		/// Menu Name
		/// </summary>
		[DataMember]
		public virtual string MenuName
		{
			get { return _menuName; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for MenuName", value, value.ToString());
				_isChanged |= (_menuName != value); _menuName = value;
			}
		}

		/// <summary>
		/// Menu Description
		/// </summary>
		[DataMember]
		public virtual string MenuDescription
		{
			get { return _menuDescription; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for MenuDescription", value, value.ToString());
				_isChanged |= (_menuDescription != value); _menuDescription = value;
			}
		}

		/// <summary>
		/// Menu Url
		/// </summary>
		[DataMember]
		public virtual string MenuUrl
		{
			get { return _menuUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for MenuUrl", value, value.ToString());
				_isChanged |= (_menuUrl != value); _menuUrl = value;
			}
		}

		/// <summary>
		/// Menu Url Target Name
		/// </summary>
		[DataMember]
		public virtual string MenuUrlTarget
		{
			get { return _menuUrlTarget; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for MenuUrlTarget", value, value.ToString());
				_isChanged |= (_menuUrlTarget != value); _menuUrlTarget = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string MenuIconUrl
		{
			get { return _menuIconUrl; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for MenuIconUrl", value, value.ToString());
				_isChanged |= (_menuIconUrl != value); _menuIconUrl = value;
			}
		}

		/// <summary>
		/// Menu Is Category
		/// </summary>
		[DataMember]
		public virtual bool MenuIsCategory
		{
			get { return _menuIsCategory; }

			set	
			{
				_isChanged |= (_menuIsCategory != value); _menuIsCategory = value;
			}
		}

		/// <summary>
		/// Parent Menu
		/// </summary>
		[DataMember]
		public virtual SystemMenuEntity ParentMenuID
		{
			get { return _parentMenuID; }

			set	
			{
				_isChanged |= (_parentMenuID != value); _parentMenuID = value;
			}
		}

		/// <summary>
		/// Menu Order
		/// </summary>
		[DataMember]
		public virtual int? MenuOrder
		{
			get { return _menuOrder; }

			set	
			{
				_isChanged |= (_menuOrder != value); _menuOrder = value;
			}
		}

		/// <summary>
		/// Menu Type
		/// </summary>
		[DataMember]
		public virtual string MenuType
		{
			get { return _menuType; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for MenuType", value, value.ToString());
				_isChanged |= (_menuType != value); _menuType = value;
			}
		}

		/// <summary>
		/// Is System Menu
		/// </summary>
		[DataMember]
		public virtual bool? MenuIsSystemMenu
		{
			get { return _menuIsSystemMenu; }

			set	
			{
				_isChanged |= (_menuIsSystemMenu != value); _menuIsSystemMenu = value;
			}
		}

		/// <summary>
		/// Is Enable
		/// </summary>
		[DataMember]
		public virtual bool? MenuIsEnable
		{
			get { return _menuIsEnable; }

			set	
			{
				_isChanged |= (_menuIsEnable != value); _menuIsEnable = value;
			}
		}

		/// <summary>
		/// Application
		/// </summary>
		[DataMember]
		public virtual SystemApplicationEntity ApplicationID
		{
			get { return _applicationID; }

			set	
			{
				_isChanged |= (_applicationID != value); _applicationID = value;
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
			
			SystemMenuEntity castObj = (SystemMenuEntity)obj;
			
			return ( castObj != null ) && ( this._menuID == castObj.MenuID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _menuID.GetHashCode();

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
