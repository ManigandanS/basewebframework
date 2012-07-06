// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SystemViewItemDataObject.Designer.cs">
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
    public partial class SystemViewItemDataObject : BaseNHibernateDataObject<SystemViewItemEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_SYSTEMVIEWITEMID = new IntProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWITEMID));		
		public static readonly StringProperty PROPERTY_SYSTEMVIEWITEMNAMEEN = new StringProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWITEMNAMEEN));		
		public static readonly StringProperty PROPERTY_SYSTEMVIEWITEMNAMECN = new StringProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWITEMNAMECN));		
		public static readonly StringProperty PROPERTY_SYSTEMVIEWITEMDESCRIPTION = new StringProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWITEMDESCRIPTION));		
		public static readonly StringProperty PROPERTY_SYSTEMVIEWITEMDISPLAYFORMAT = new StringProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWITEMDISPLAYFORMAT));		
		public static readonly EntityProperty<SystemViewEntity> PROPERTY_SYSTEMVIEWID = new EntityProperty<SystemViewEntity>(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWID));
		#region systemViewID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SystemViewItemEntity> InClude_SystemViewID_Query(NHibernateDynamicQueryGenerator<SystemViewItemEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWID, PROPERTY_SYSTEMVIEWID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_SYSTEMVIEWID_ALIAS_NAME = "SystemViewID_SystemViewItemEntity_Alias";
		public static readonly IntProperty PROPERTY_SYSTEMVIEWID_SYSTEMVIEWID = new IntProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".SystemViewID"));
		public static readonly StringProperty PROPERTY_SYSTEMVIEWID_SYSTEMVIEWNAMECN = new StringProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".SystemViewNameCn"));
		public static readonly StringProperty PROPERTY_SYSTEMVIEWID_SYSTEMVIEWNAMEEN = new StringProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".SystemViewNameEn"));
		public static readonly EntityProperty<SystemApplicationEntity> PROPERTY_SYSTEMVIEWID_APPLICATIONID = new EntityProperty<SystemApplicationEntity>(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".ApplicationID"));
		public static readonly StringProperty PROPERTY_SYSTEMVIEWID_SYSTEMVIEWDESCRIPTION = new StringProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".SystemViewDescription"));
		public static readonly IntProperty PROPERTY_SYSTEMVIEWID_ORDERINDEX = new IntProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".OrderIndex"));
		public static readonly IntProperty PROPERTY_SYSTEMVIEWID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_SYSTEMVIEWID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_SYSTEMVIEWID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_SYSTEMVIEWID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_SYSTEMVIEWID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_SYSTEMVIEWID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly IntProperty PROPERTY_ORDERINDEX = new IntProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_ORDERINDEX));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SystemViewItemEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "SystemViewItemID" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "SystemViewItemID":
                    return typeof (int);
                case "SystemViewItemNameEn":
                    return typeof (string);
                case "SystemViewItemNameCn":
                    return typeof (string);
                case "SystemViewItemDescription":
                    return typeof (string);
                case "SystemViewItemDisplayFormat":
                    return typeof (string);
                case "SystemViewID":
                    return typeof (int);
                case "OrderIndex":
                    return typeof (int);
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
		
        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SystemViewItemEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "SystemViewID_SystemViewItemEntity_Alias":
                    queryGenerator.AddAlians(SystemViewItemEntity.PROPERTY_NAME_SYSTEMVIEWID, PROPERTY_SYSTEMVIEWID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
        }
		
		
		
		public List<SystemViewItemEntity> GetList_By_SystemViewID_SystemViewEntity(SystemViewEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SystemViewItemEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_SYSTEMVIEWID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SystemViewItemEntity> GetPageList_By_SystemViewID_SystemViewEntity(string orderByColumnName, bool isDesc, SystemViewEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SystemViewItemEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_SYSTEMVIEWID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
