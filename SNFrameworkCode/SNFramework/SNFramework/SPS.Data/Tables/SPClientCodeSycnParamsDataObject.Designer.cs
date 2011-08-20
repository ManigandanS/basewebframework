// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery.Propertys;
using SPS.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace SPS.Data.Tables
{
    public partial class SPClientCodeSycnParamsDataObject : BaseNHibernateDataObject<SPClientCodeSycnParamsEntity>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_ID));		
		public static readonly StringProperty PROPERTY_NAME = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_NAME));		
		public static readonly StringProperty PROPERTY_DESCRIPTION = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_DESCRIPTION));		
		public static readonly BoolProperty PROPERTY_ISENABLE = new BoolProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_ISENABLE));		
		public static readonly BoolProperty PROPERTY_ISREQUIRED = new BoolProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_ISREQUIRED));		
		public static readonly EntityProperty<SPCodeEntity> PROPERTY_CODEID = new EntityProperty<SPCodeEntity>(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_CODEID));
		#region codeID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPClientCodeSycnParamsEntity> InClude_CodeID_Query(NHibernateDynamicQueryGenerator<SPClientCodeSycnParamsEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPClientCodeSycnParamsEntity.PROPERTY_NAME_CODEID, PROPERTY_CODEID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_CODEID_ALIAS_NAME = "CodeID_SPClientCodeSycnParamsEntity_Alias";
		public static readonly IntProperty PROPERTY_CODEID_ID = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Id"));
		public static readonly StringProperty PROPERTY_CODEID_NAME = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_CODEID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Description"));
		public static readonly StringProperty PROPERTY_CODEID_CODE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Code"));
		public static readonly IntProperty PROPERTY_CODEID_CHANNELID = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".ChannelID"));
		public static readonly StringProperty PROPERTY_CODEID_MO = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Mo"));
		public static readonly StringProperty PROPERTY_CODEID_MOTYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".MOType"));
		public static readonly IntProperty PROPERTY_CODEID_ORDERINDEX = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".OrderIndex"));
		public static readonly StringProperty PROPERTY_CODEID_SPCODE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPCode"));
		public static readonly StringProperty PROPERTY_CODEID_PROVINCE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Province"));
		public static readonly StringProperty PROPERTY_CODEID_DISABLECITY = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".DisableCity"));
		public static readonly BoolProperty PROPERTY_CODEID_ISDIABLE = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".IsDiable"));
		public static readonly StringProperty PROPERTY_CODEID_SPTYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPType"));
		public static readonly IntProperty PROPERTY_CODEID_CODELENGTH = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".CodeLength"));
		public static readonly IntProperty PROPERTY_CODEID_DAYLIMIT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".DayLimit"));
		public static readonly IntProperty PROPERTY_CODEID_MONTHLIMIT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".MonthLimit"));
		#endregion
		public static readonly StringProperty PROPERTY_MAPPINGPARAMS = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_MAPPINGPARAMS));		
		public static readonly StringProperty PROPERTY_TITLE = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_TITLE));		
      
		#region 子类集合字段查询字段
	
		#endregion

		#endregion

		
		public override string[] PkPropertyName
        {
            get { return new string[] { "Id" }; }
        }
		
		public override Type GetFieldTypeByFieldName(string fieldName)
        {
			switch (fieldName)
            {
                case "Id":
                    return typeof (int);
                case "Name":
                    return typeof (string);
                case "Description":
                    return typeof (string);
                case "IsEnable":
                    return typeof (bool);
                case "IsRequired":
                    return typeof (bool);
                case "CodeID":
                    return typeof (int);
                case "MappingParams":
                    return typeof (string);
                case "Title":
                    return typeof (string);
          }
			return typeof(string);
        }
		
		public List<SPClientCodeSycnParamsEntity> GetList_By_CodeID_SPCodeEntity(SPCodeEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPClientCodeSycnParamsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CODEID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPClientCodeSycnParamsEntity> GetPageList_By_CodeID_SPCodeEntity(string orderByColumnName, bool isDesc, SPCodeEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPClientCodeSycnParamsEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_CODEID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
