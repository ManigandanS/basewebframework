// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemEmailTemplateEntity.Designer.cs">
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
	public partial class SystemEmailTemplateEntity  : BaseTableEntity<int>,ICloneable
	{
      #region 公共常量

		public static readonly string CLASS_FULL_NAME = "Legendigital.Framework.Common.BaseFramework.Entity.Tables.SystemEmailTemplateEntity";
		public static readonly string PROPERTY_NAME_EMAILTEMPLATEID = "EmailTemplateID";
		public static readonly string PROPERTY_NAME_NAME = "Name";
		public static readonly string PROPERTY_NAME_CODE = "Code";
		public static readonly string PROPERTY_NAME_DESCRIPTION = "Description";
		public static readonly string PROPERTY_NAME_TEMPLATETYPE = "TemplateType";
		public static readonly string PROPERTY_NAME_TITLETEMPLATE = "TitleTemplate";
		public static readonly string PROPERTY_NAME_BODYTEMPLATE = "BodyTemplate";
		public static readonly string PROPERTY_NAME_PARAMS = "Params";
		public static readonly string PROPERTY_NAME_ISHTMLEMAIL = "IsHtmlEmail";
		public static readonly string PROPERTY_NAME_ISENABLE = "IsEnable";
		public static readonly string PROPERTY_NAME_CREATEAT = "CreateAt";
		public static readonly string PROPERTY_NAME_CREATEBY = "CreateBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYBY = "LastModifyBy";
		public static readonly string PROPERTY_NAME_LASTMODIFYAT = "LastModifyAt";
		public static readonly string PROPERTY_NAME_LASTMODIFYCOMMENT = "LastModifyComment";
		
        #endregion
	
 
      	
	
	
		 
		
		
		
		
	
        #region 私有成员变量

 
		
		private int _emailTemplateID;
		private string _name;
		private string _code;
		private string _description;
		private string _templateType;
		private string _titleTemplate;
		private string _bodyTemplate;
		private string _params;
		private bool? _isHtmlEmail;
		private bool? _isEnable;
		private DateTime? _createAt;
		private int? _createBy;
		private int? _lastModifyBy;
		private DateTime? _lastModifyAt;
		private string _lastModifyComment;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SystemEmailTemplateEntity()
		{
			_emailTemplateID = 0;
			_name = null;
			_code = null;
			_description = null;
			_templateType = null;
			_titleTemplate = null;
			_bodyTemplate = null;
			_params = null;
			_isHtmlEmail = null;
			_isEnable = null;
			_createAt = null;
			_createBy = null;
			_lastModifyBy = null;
			_lastModifyAt = null;
			_lastModifyComment = null;
		}
		#endregion

		#region 全构造函数
		/// <summary>
		/// 全构造函数
		/// </summary>
		public SystemEmailTemplateEntity( int emailTemplateID, string name, string code, string description, string templateType, string titleTemplate, string bodyTemplate, string paramsp, bool? isHtmlEmail, bool? isEnable, DateTime? createAt, int? createBy, int? lastModifyBy, DateTime? lastModifyAt, string lastModifyComment)
		{
			_emailTemplateID = emailTemplateID;
			_name = name;
			_code = code;
			_description = description;
			_templateType = templateType;
			_titleTemplate = titleTemplate;
			_bodyTemplate = bodyTemplate;
			_params = paramsp;
			_isHtmlEmail = isHtmlEmail;
			_isEnable = isEnable;
			_createAt = createAt;
			_createBy = createBy;
			_lastModifyBy = lastModifyBy;
			_lastModifyAt = lastModifyAt;
			_lastModifyComment = lastModifyComment;
		}
		#endregion     
	
	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual int EmailTemplateID
		{
			get { return _emailTemplateID; }

			set	
			{
				_isChanged |= (_emailTemplateID != value); _emailTemplateID = value;
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
		public virtual string Code
		{
			get { return _code; }

			set	
			{

				if( value != null && value.Length > 400)
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

				if( value != null && value.Length > 4000)
					throw new ArgumentOutOfRangeException("Invalid value for Description", value, value.ToString());
				_isChanged |= (_description != value); _description = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string TemplateType
		{
			get { return _templateType; }

			set	
			{

				if( value != null && value.Length > 100)
					throw new ArgumentOutOfRangeException("Invalid value for TemplateType", value, value.ToString());
				_isChanged |= (_templateType != value); _templateType = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string TitleTemplate
		{
			get { return _titleTemplate; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for TitleTemplate", value, value.ToString());
				_isChanged |= (_titleTemplate != value); _titleTemplate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string BodyTemplate
		{
			get { return _bodyTemplate; }

			set	
			{

				if( value != null && value.Length > 2147483646)
					throw new ArgumentOutOfRangeException("Invalid value for BodyTemplate", value, value.ToString());
				_isChanged |= (_bodyTemplate != value); _bodyTemplate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual string Params
		{
			get { return _params; }

			set	
			{

				if( value != null && value.Length > 6000)
					throw new ArgumentOutOfRangeException("Invalid value for Params", value, value.ToString());
				_isChanged |= (_params != value); _params = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public virtual bool? IsHtmlEmail
		{
			get { return _isHtmlEmail; }

			set	
			{
				_isChanged |= (_isHtmlEmail != value); _isHtmlEmail = value;
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
			 return this.CheckEquals(obj as SystemEmailTemplateEntity);
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
	        return this._emailTemplateID;
	    }
		
		
	
		#region ICloneable methods
		
		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}
		
		#endregion
	
	}
}
