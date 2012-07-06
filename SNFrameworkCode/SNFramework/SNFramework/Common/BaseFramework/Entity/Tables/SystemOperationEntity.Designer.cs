// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemOperationEntity.Designer.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Legendigital.Framework.Common.Entity;

namespace Legendigital.Framework.Common.BaseFramework.Entity.Tables
{
	/// <summary>
	///	????
       
	/// </summary>
	[DataContract]
	public partial class SystemOperationEntity  : BaseTableEntity<int>,ICloneable
	{
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemOperationEntity";
		public static readonly string PROPERTY_NAME_OPERATIONID = "OperationID";
		public static readonly string PROPERTY_NAME_OPERATIONNAMECN = "OperationNameCn";
		public static readonly string PROPERTY_NAME_OPERATIONNAMEEN = "OperationNameEn";
		public static readonly string PROPERTY_NAME_OPERATIONDESCRIPTION = "OperationDescription";
		public static readonly string PROPERTY_NAME_ISSYSTEMOPERATION = "IsSystemOperation";
		public static readonly string PROPERTY_NAME_ISCANSINGLEOPERATION = "IsCanSingleOperation";
		public static readonly string PROPERTY_NAME_ISCANMUTILOPERATION = "IsCanMutilOperation";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_ISINLISTPAGE = "IsInListPage";
		public static readonly string PROPERTY_NAME_ISINSINGLEPAGE = "IsInSinglePage";
		public static readonly string PROPERTY_NAME_OPERATIONORDER = "OperationOrder";
		public static readonly string PROPERTY_NAME_ISCOMMONOPERATION = "IsCommonOperation";
		public static readonly string PROPERTY_NAME_RESOURCEID = "ResourceID";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
		#region resourceID字段外键查询字段
        public const string PROPERTY_RESOURCEID_ALIAS_NAME = "ResourceID_SystemOperationEntity_Alias";
		public const string PROPERTY_RESOURCEID_RESOURCESID = "ResourceID_SystemOperationEntity_Alias.ResourcesID";
		public const string PROPERTY_RESOURCEID_RESOURCESNAMECN = "ResourceID_SystemOperationEntity_Alias.ResourcesNameCn";
		public const string PROPERTY_RESOURCEID_RESOURCESNAMEEN = "ResourceID_SystemOperationEntity_Alias.ResourcesNameEn";
		public const string PROPERTY_RESOURCEID_RESOURCESDESCRIPTION = "ResourceID_SystemOperationEntity_Alias.ResourcesDescription";
		public const string PROPERTY_RESOURCEID_RESOURCESTYPE = "ResourceID_SystemOperationEntity_Alias.ResourcesType";
		public const string PROPERTY_RESOURCEID_RESOURCESLIMITEXPRESSION = "ResourceID_SystemOperationEntity_Alias.ResourcesLimitExpression";
		public const string PROPERTY_RESOURCEID_RESOURCESISRELATEUSER = "ResourceID_SystemOperationEntity_Alias.ResourcesIsRelateUser";
		public const string PROPERTY_RESOURCEID_MOUDLEID = "ResourceID_SystemOperationEntity_Alias.MoudleID";
		public const string PROPERTY_RESOURCEID_PARENTRESOURCESID = "ResourceID_SystemOperationEntity_Alias.ParentResourcesID";
		public const string PROPERTY_RESOURCEID_ORDERINDEX = "ResourceID_SystemOperationEntity_Alias.OrderIndex";
		public const string PROPERTY_RESOURCEID_CREATEBY = "ResourceID_SystemOperationEntity_Alias.CreateBy";
		public const string PROPERTY_RESOURCEID_CREATEAT = "ResourceID_SystemOperationEntity_Alias.CreateAt";
		public const string PROPERTY_RESOURCEID_LASTMODIFYBY = "ResourceID_SystemOperationEntity_Alias.LastModifyBy";
		public const string PROPERTY_RESOURCEID_LASTMODIFYAT = "ResourceID_SystemOperationEntity_Alias.LastModifyAt";
		public const string PROPERTY_RESOURCEID_LASTMODIFYCOMMENT = "ResourceID_SystemOperationEntity_Alias.LastModifyComment";
		#endregion
      	
	
	
		 
		
		
		
		
	
        #region 私有成员变量

 
		
		private int _operationID;
		private string _operationNameCn;
		private string _operationNameEn;
		private string _operationDescription;
		private bool _isSystemOperation;
		private bool _isCanSingleOperation;
		private bool _isCanMutilOperation;
		private bool _isEnable;
		private bool _isInListPage;
		private bool _isInSinglePage;
		private int _operationOrder;
		private bool? _isCommonOperation;
		private SystemResourcesEntity _resourceID;
		private int? _createBy;
		private DateTime? _createAt;
		private int? _lastModifyBy;
		private DateTime? _lastModifyAt;
		private string _lastModifyComment;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemOperationEntity()
		{
			_operationID = 0;
			_operationNameCn = null;
			_operationNameEn = null;
			_operationDescription = String.Empty;
			_isSystemOperation = false;
			_isCanSingleOperation = false;
			_isCanMutilOperation = false;
			_isEnable = false;
			_isInListPage = false;
			_isInSinglePage = false;
			_operationOrder = 9999;
			_isCommonOperation = null;
			_resourceID = null;
			_createBy = null;
			_createAt = null;
			_lastModifyBy = null;
			_lastModifyAt = null;
			_lastModifyComment = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemOperationEntity( int operationID, string operationNameCn, string operationNameEn, string operationDescription, bool isSystemOperation, bool isCanSingleOperation, bool isCanMutilOperation, bool isEnable, bool isInListPage, bool isInSinglePage, int operationOrder, bool? isCommonOperation, SystemResourcesEntity resourceID, int? createBy, DateTime? createAt, int? lastModifyBy, DateTime? lastModifyAt, string lastModifyComment)
		{
			_operationID = operationID;
			_operationNameCn = operationNameCn;
			_operationNameEn = operationNameEn;
			_operationDescription = operationDescription;
			_isSystemOperation = isSystemOperation;
			_isCanSingleOperation = isCanSingleOperation;
			_isCanMutilOperation = isCanMutilOperation;
			_isEnable = isEnable;
			_isInListPage = isInListPage;
			_isInSinglePage = isInSinglePage;
			_operationOrder = operationOrder;
			_isCommonOperation = isCommonOperation;
			_resourceID = resourceID;
			_createBy = createBy;
			_createAt = createAt;
			_lastModifyBy = lastModifyBy;
			_lastModifyAt = lastModifyAt;
			_lastModifyComment = lastModifyComment;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// ??
		/// </summary>
		[DataMember]
		public virtual int OperationID
		{
			get { return _operationID; }

			set	
			{
				_isChanged |= (_operationID != value); _operationID = value;
			}
		}

		/// <summary>
		/// ?????
		/// </summary>
		[DataMember]
		public virtual string OperationNameCn
		{
			get { return _operationNameCn; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for OperationNameCn", value, value.ToString());
				_isChanged |= (_operationNameCn != value); _operationNameCn = value;
			}
		}

		/// <summary>
		/// ????
		/// </summary>
		[DataMember]
		public virtual string OperationNameEn
		{
			get { return _operationNameEn; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for OperationNameEn", value, value.ToString());
				_isChanged |= (_operationNameEn != value); _operationNameEn = value;
			}
		}

		/// <summary>
		/// ????
		/// </summary>
		[DataMember]
		public virtual string OperationDescription
		{
			get { return _operationDescription; }

			set	
			{

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for OperationDescription", value, value.ToString());
				_isChanged |= (_operationDescription != value); _operationDescription = value;
			}
		}

		/// <summary>
		/// ???????
		/// </summary>
		[DataMember]
		public virtual bool IsSystemOperation
		{
			get { return _isSystemOperation; }

			set	
			{
				_isChanged |= (_isSystemOperation != value); _isSystemOperation = value;
			}
		}

		/// <summary>
		/// ??????????
		/// </summary>
		[DataMember]
		public virtual bool IsCanSingleOperation
		{
			get { return _isCanSingleOperation; }

			set	
			{
				_isChanged |= (_isCanSingleOperation != value); _isCanSingleOperation = value;
			}
		}

		/// <summary>
		/// ??????????
		/// </summary>
		[DataMember]
		public virtual bool IsCanMutilOperation
		{
			get { return _isCanMutilOperation; }

			set	
			{
				_isChanged |= (_isCanMutilOperation != value); _isCanMutilOperation = value;
			}
		}

		/// <summary>
		/// ????
		/// </summary>
		[DataMember]
		public virtual bool IsEnable
		{
			get { return _isEnable; }

			set	
			{
				_isChanged |= (_isEnable != value); _isEnable = value;
			}
		}

		/// <summary>
		/// ?????????
		/// </summary>
		[DataMember]
		public virtual bool IsInListPage
		{
			get { return _isInListPage; }

			set	
			{
				_isChanged |= (_isInListPage != value); _isInListPage = value;
			}
		}

		/// <summary>
		/// ?????????
		/// </summary>
		[DataMember]
		public virtual bool IsInSinglePage
		{
			get { return _isInSinglePage; }

			set	
			{
				_isChanged |= (_isInSinglePage != value); _isInSinglePage = value;
			}
		}

		/// <summary>
		/// ?????
		/// </summary>
		[DataMember]
		public virtual int OperationOrder
		{
			get { return _operationOrder; }

			set	
			{
				_isChanged |= (_operationOrder != value); _operationOrder = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? IsCommonOperation
		{
			get { return _isCommonOperation; }

			set	
			{
				_isChanged |= (_isCommonOperation != value); _isCommonOperation = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual SystemResourcesEntity ResourceID
		{
			get { return _resourceID; }

			set	
			{
				_isChanged |= (_resourceID != value); _resourceID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? CreateBy
		{
			get { return _createBy; }

			set	
			{
				_isChanged |= (_createBy != value); _createBy = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? CreateAt
		{
			get { return _createAt; }

			set	
			{
				_isChanged |= (_createAt != value); _createAt = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int? LastModifyBy
		{
			get { return _lastModifyBy; }

			set	
			{
				_isChanged |= (_lastModifyBy != value); _lastModifyBy = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual DateTime? LastModifyAt
		{
			get { return _lastModifyAt; }

			set	
			{
				_isChanged |= (_lastModifyAt != value); _lastModifyAt = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string LastModifyComment
		{
			get { return _lastModifyComment; }

			set	
			{

				if( value != null && value.Length > 600)
					throw new ArgumentOutOfRangeException("Invalid value for LastModifyComment", value, value.ToString());
				_isChanged |= (_lastModifyComment != value); _lastModifyComment = value;
			}
		}
	

		#endregion 

        

		#region Equals 和 HashCode 方法覆盖
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			 return this.CheckEquals(obj as SystemOperationEntity);
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			return GetEntityHashCode();
		}
		#endregion
		
		public override int GetDataEntityKey()
	    {
	        return this._operationID;
	    }
		
		
	
		#region ICloneable methods
		
		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}
		
		#endregion
	
	}
}
