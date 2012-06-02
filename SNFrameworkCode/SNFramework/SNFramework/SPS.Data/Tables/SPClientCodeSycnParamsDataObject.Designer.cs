// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPClientCodeSycnParamsDataObject.Designer.cs">
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
using SPS.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;


namespace SPS.Data.Tables
{
    public partial class SPClientCodeSycnParamsDataObject : BaseNHibernateDataObject<SPClientCodeSycnParamsEntity,int>
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
		public static readonly StringProperty PROPERTY_CODEID_CODETYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".CodeType"));
		public static readonly EntityProperty<SPChannelEntity> PROPERTY_CODEID_CHANNELID = new EntityProperty<SPChannelEntity>(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".ChannelID"));
		public static readonly StringProperty PROPERTY_CODEID_MO = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Mo"));
		public static readonly StringProperty PROPERTY_CODEID_MOTYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".MOType"));
		public static readonly IntProperty PROPERTY_CODEID_MOLENGTH = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".MOLength"));
		public static readonly IntProperty PROPERTY_CODEID_ORDERINDEX = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".OrderIndex"));
		public static readonly StringProperty PROPERTY_CODEID_SPCODE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPCode"));
		public static readonly StringProperty PROPERTY_CODEID_SPCODETYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPCodeType"));
		public static readonly IntProperty PROPERTY_CODEID_SPCODELENGTH = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".SPCodeLength"));
		public static readonly BoolProperty PROPERTY_CODEID_HASFILTERS = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".HasFilters"));
		public static readonly BoolProperty PROPERTY_CODEID_HASPARAMSCONVERT = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".HasParamsConvert"));
		public static readonly BoolProperty PROPERTY_CODEID_ISDIABLE = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".IsDiable"));
		public static readonly DecimalProperty PROPERTY_CODEID_PRICE = new DecimalProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".Price"));
		public static readonly StringProperty PROPERTY_CODEID_OPERATIONTYPE = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".OperationType"));
		public static readonly BoolProperty PROPERTY_CODEID_HASDAYTOTALLIMIT = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".HasDayTotalLimit"));
		public static readonly IntProperty PROPERTY_CODEID_DAYTOTALLIMITCOUNT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".DayTotalLimitCount"));
		public static readonly BoolProperty PROPERTY_CODEID_HASPHONELIMIT = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".HasPhoneLimit"));
		public static readonly IntProperty PROPERTY_CODEID_PHONELIMITDAYCOUNT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".PhoneLimitDayCount"));
		public static readonly IntProperty PROPERTY_CODEID_PHONELIMITMONTHCOUNT = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".PhoneLimitMonthCount"));
		public static readonly IntProperty PROPERTY_CODEID_PHONELIMITTYPE = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".PhoneLimitType"));
		public static readonly BoolProperty PROPERTY_CODEID_LIMITPROVINCE = new BoolProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".LimitProvince"));
		public static readonly StringProperty PROPERTY_CODEID_LIMITPROVINCEAREA = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".LimitProvinceArea"));
		public static readonly EntityProperty<SPCodeEntity> PROPERTY_CODEID_PARENTID = new EntityProperty<SPCodeEntity>(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".ParentID"));
		public static readonly IntProperty PROPERTY_CODEID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_CODEID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_CODEID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_CODEID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_CODEID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_CODEID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly StringProperty PROPERTY_MAPPINGPARAMS = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_MAPPINGPARAMS));		
		public static readonly StringProperty PROPERTY_TITLE = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_TITLE));		
		public static readonly StringProperty PROPERTY_PARAMSVALUE = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_PARAMSVALUE));		
		public static readonly StringProperty PROPERTY_PARAMSTYPE = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_PARAMSTYPE));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SPClientCodeSycnParamsEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      
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
                case "ParamsValue":
                    return typeof (string);
                case "ParamsType":
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
		
        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SPClientCodeSycnParamsEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "CodeID_SPClientCodeSycnParamsEntity_Alias":
                    queryGenerator.AddAlians(SPClientCodeSycnParamsEntity.PROPERTY_NAME_CODEID, PROPERTY_CODEID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
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
