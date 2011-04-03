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
	public partial class SystemWorkFlowEntity : ICloneable
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemWorkFlowEntity";
		public static readonly string PROPERTY_NAME_WORKFLOWID = "WorkFlowID";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_ISSYSTEMFLOW = "IsSystemFlow";
		public static readonly string PROPERTY_NAME_ISDELETE = "IsDelete";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		
        #endregion
	
        #region 私有成员变量

		private bool _isChanged;		
		private bool _isDeleted;
		
		private int _workFlowID;
		private string _name;
		private string _code;
		private string _description;
		private string _isSystemFlow;
		private string _isDelete;
		private string _isEnable;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemWorkFlowEntity()
		{
			_workFlowID = 0;
			_name = null;
			_code = null;
			_description = null;
			_isSystemFlow = null;
			_isDelete = null;
			_isEnable = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemWorkFlowEntity( int workFlowID, string name, string code, string description, string isSystemFlow, string isDelete, string isEnable)
		{
			_workFlowID = workFlowID;
			_name = name;
			_code = code;
			_description = description;
			_isSystemFlow = isSystemFlow;
			_isDelete = isDelete;
			_isEnable = isEnable;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int WorkFlowID
		{
			get { return _workFlowID; }

			set	
			{
				_isChanged |= (_workFlowID != value); _workFlowID = value;
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

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_isChanged |= (_name != value); _name = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Code
		{
			get { return _code; }

			set	
			{

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Code", value, value.ToString());
				_isChanged |= (_code != value); _code = value;
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

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_isChanged |= (_description != value); _description = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string IsSystemFlow
		{
			get { return _isSystemFlow; }

			set	
			{

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for IsSystemFlow", value, value.ToString());
				_isChanged |= (_isSystemFlow != value); _isSystemFlow = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string IsDelete
		{
			get { return _isDelete; }

			set	
			{

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for IsDelete", value, value.ToString());
				_isChanged |= (_isDelete != value); _isDelete = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string IsEnable
		{
			get { return _isEnable; }

			set	
			{

				if( value != null && value.Length > 20)
					throw new ArgumentOutOfRangeException("Invalid value for IsEnable", value, value.ToString());
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
			
			SystemWorkFlowEntity castObj = (SystemWorkFlowEntity)obj;
			
			return ( castObj != null ) && ( this._workFlowID == castObj.WorkFlowID );
		}
		
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			
			int hash = 57; 
			hash = 27 * hash * _workFlowID.GetHashCode();

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
