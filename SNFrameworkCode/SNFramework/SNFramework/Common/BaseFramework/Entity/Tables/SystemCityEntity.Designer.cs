// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemCityEntity.Designer.cs">
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
	///	
	/// </summary>
	[DataContract]
	public partial class SystemCityEntity  : BaseTableEntity<int>,ICloneable
	{
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemCityEntity";
		public static readonly string PROPERTY_NAME_ID = "Id";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_ABBRNAME = "AbbrName";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_PROVINCEID = "ProvinceID";
		public static readonly string PROPERTY_NAME_CAPITAL = "Capital";
		
        #endregion
	
 
		#region provinceID字段外键查询字段
        public const string PROPERTY_PROVINCEID_ALIAS_NAME = "ProvinceID_SystemCityEntity_Alias";
		public const string PROPERTY_PROVINCEID_ID = "ProvinceID_SystemCityEntity_Alias.Id";
		public const string PROPERTY_PROVINCEID_NAME = "ProvinceID_SystemCityEntity_Alias.Name";
		public const string PROPERTY_PROVINCEID_ABBRNAME = "ProvinceID_SystemCityEntity_Alias.AbbrName";
		public const string PROPERTY_PROVINCEID_SINGLEABBRNAME = "ProvinceID_SystemCityEntity_Alias.SingleAbbrName";
		public const string PROPERTY_PROVINCEID_CODE = "ProvinceID_SystemCityEntity_Alias.Code";
		public const string PROPERTY_PROVINCEID_COUNTRYID = "ProvinceID_SystemCityEntity_Alias.CountryID";
		#endregion
      	
	
	
		 
		
		
		
		
	
        #region 私有成员变量

 
		
		private int _id;
		private string _name;
		private string _abbrName;
		private string _code;
		private SystemProvinceEntity _provinceID;
		private bool? _capital;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemCityEntity()
		{
			_id = 0;
			_name = null;
			_abbrName = null;
			_code = null;
			_provinceID = null;
			_capital = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemCityEntity( int id, string name, string abbrName, string code, SystemProvinceEntity provinceID, bool? capital)
		{
			_id = id;
			_name = name;
			_abbrName = abbrName;
			_code = code;
			_provinceID = provinceID;
			_capital = capital;
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

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for Name", value, value.ToString());
				_isChanged |= (_name != value); _name = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string AbbrName
		{
			get { return _abbrName; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for AbbrName", value, value.ToString());
				_isChanged |= (_abbrName != value); _abbrName = value;
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
		public virtual SystemProvinceEntity ProvinceID
		{
			get { return _provinceID; }

			set	
			{
				_isChanged |= (_provinceID != value); _provinceID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? Capital
		{
			get { return _capital; }

			set	
			{
				_isChanged |= (_capital != value); _capital = value;
			}
		}
	

		#endregion 

        

		#region Equals 和 HashCode 方法覆盖
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			 return this.CheckEquals(obj as SystemCityEntity);
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
