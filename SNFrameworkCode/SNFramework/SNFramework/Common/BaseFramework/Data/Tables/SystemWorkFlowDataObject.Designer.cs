// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemWorkFlowDataObject.Designer.cs">
//   Copyright (c) Foreveross Enterprises. All rights reserved.
// </copyright>
// <summary>
//   Generated by MyGeneration Version # (1.3.0.9)
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery.Propertys;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace Legendigital.Framework.Common.BaseFramework.Data.Tables
{
    public partial class SystemWorkFlowDataObject : BaseNHibernateDataObject<SystemWorkFlowEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_WORKFLOWID = new IntProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_WORKFLOWID));		
		public static readonly StringProperty PROPERTY_NAME = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_NAME));		
		public static readonly StringProperty PROPERTY_CODE = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_CODE));		
		public static readonly StringProperty PROPERTY_DESCRIPTION = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_DESCRIPTION));		
		public static readonly StringProperty PROPERTY_ISSYSTEMFLOW = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_ISSYSTEMFLOW));		
		public static readonly StringProperty PROPERTY_ISDELETE = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_ISDELETE));		
		public static readonly StringProperty PROPERTY_ISENABLE = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_ISENABLE));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SystemWorkFlowEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "WorkFlowID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "WorkFlowID":
                    return typeof (int);
                case "Name":
                    return typeof (string);
                case "Code":
                    return typeof (string);
                case "Description":
                    return typeof (string);
                case "IsSystemFlow":
                    return typeof (string);
                case "IsDelete":
                    return typeof (string);
                case "IsEnable":
                    return typeof (string);
                case "CreateBy":
                    return typeof (int);
                case "CreateAt":
                    return typeof (DateTime);
                case "LastModifyBy":
                    return typeof (int);
                case "LastModifyAt":
                    return typeof (DateTime);
                case "LastModifyComment":
                    return typeof (string);
          }
			return typeof(string);
        }
		
        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SystemWorkFlowEntity> queryGenerator)
        {
            switch (parent_alias)
            {
                default:
                    break;
 
            }
        }
		
		
		

		
		
    }
}
