// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPAdPackEntity.Designer.cs">
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

namespace SPS.Entity.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public partial class SPAdPackEntity  : BaseTableEntity<int>,ICloneable
	{
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "SPS.Entity.Tables.SPAdPackEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_SPADID = "SPAdID";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		
        #endregion
	
 
		#region sPAdID字段外键查询字段
        public const string PROPERTY_SPADID_ALIAS_NAME = "SPAdID_SPAdPackEntity_Alias";
		public const string PROPERTY_SPADID_ID = "SPAdID_SPAdPackEntity_Alias.Id";
		public const string PROPERTY_SPADID_SPADID = "SPAdID_SPAdPackEntity_Alias.SPAdID";
		public const string PROPERTY_SPADID_SPADPACKID = "SPAdID_SPAdPackEntity_Alias.SPAdPackID";
		public const string PROPERTY_SPADID_SPCLIENTID = "SPAdID_SPAdPackEntity_Alias.SPClientID";
		public const string PROPERTY_SPADID_STARTDATE = "SPAdID_SPAdPackEntity_Alias.StartDate";
		public const string PROPERTY_SPADID_ENDDATE = "SPAdID_SPAdPackEntity_Alias.EndDate";
		public const string PROPERTY_SPADID_CREATEBY = "SPAdID_SPAdPackEntity_Alias.CreateBy";
		public const string PROPERTY_SPADID_CREATEAT = "SPAdID_SPAdPackEntity_Alias.CreateAt";
		public const string PROPERTY_SPADID_LASTMODIFYBY = "SPAdID_SPAdPackEntity_Alias.LastModifyBy";
		public const string PROPERTY_SPADID_LASTMODIFYAT = "SPAdID_SPAdPackEntity_Alias.LastModifyAt";
		public const string PROPERTY_SPADID_LASTMODIFYCOMMENT = "SPAdID_SPAdPackEntity_Alias.LastModifyComment";
		#endregion
      	
	
	
		 
		
		
		
		
	
        #region 私有成员变量

 
		
		private int _id;
		private SPAdAssignedHistortyEntity _sPAdID;
		private string _name;
		private string _code;
		private string _description;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPAdPackEntity()
		{
			_id = 0;
			_sPAdID = null;
			_name = null;
			_code = null;
			_description = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SPAdPackEntity( int id, SPAdAssignedHistortyEntity sPAdID, string name, string code, string description)
		{
			_id = id;
			_sPAdID = sPAdID;
			_name = name;
			_code = code;
			_description = description;
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
		public virtual SPAdAssignedHistortyEntity SPAdID
		{
			get { return _sPAdID; }

			set	
			{
				_isChanged |= (_sPAdID != value); _sPAdID = value;
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

				if( value != null && value.Length > 100)
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

				if( value != null && value.Length > 100)
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

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_isChanged |= (_description != value); _description = value;
			}
		}
	

		#endregion 

        

		#region Equals 和 HashCode 方法覆盖
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			 return this.CheckEquals(obj as SPAdPackEntity);
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
	        return this._id;
	    }
		
		
	
		#region ICloneable methods
		
		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}
		
		#endregion
	
	}
}
