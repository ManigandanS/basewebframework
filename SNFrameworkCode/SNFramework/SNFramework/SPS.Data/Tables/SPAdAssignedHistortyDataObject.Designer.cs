// --------------------------------------------------------------------------------------------------------------------
// <copyright company="foreveross" file="SPAdAssignedHistortyDataObject.Designer.cs">
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
    public partial class SPAdAssignedHistortyDataObject : BaseNHibernateDataObject<SPAdAssignedHistortyEntity,int>
    {
		#region Expression Query Property (标准查询字段)
		public static readonly IntProperty PROPERTY_ID = new IntProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_ID));		
		public static readonly IntProperty PROPERTY_SPADID = new IntProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPADID));		
		public static readonly EntityProperty<SPAdPackEntity> PROPERTY_SPADPACKID = new EntityProperty<SPAdPackEntity>(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPADPACKID));
		#region sPAdPackID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> InClude_SPAdPackID_Query(NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPADPACKID, PROPERTY_SPADPACKID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_SPADPACKID_ALIAS_NAME = "SPAdPackID_SPAdAssignedHistortyEntity_Alias";
		public static readonly IntProperty PROPERTY_SPADPACKID_ID = new IntProperty(Property.ForName(PROPERTY_SPADPACKID_ALIAS_NAME + ".Id"));
		public static readonly EntityProperty<SPAdvertisementEntity> PROPERTY_SPADPACKID_SPADID = new EntityProperty<SPAdvertisementEntity>(Property.ForName(PROPERTY_SPADPACKID_ALIAS_NAME + ".SPAdID"));
		public static readonly StringProperty PROPERTY_SPADPACKID_NAME = new StringProperty(Property.ForName(PROPERTY_SPADPACKID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_SPADPACKID_CODE = new StringProperty(Property.ForName(PROPERTY_SPADPACKID_ALIAS_NAME + ".Code"));
		public static readonly StringProperty PROPERTY_SPADPACKID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_SPADPACKID_ALIAS_NAME + ".Description"));
		public static readonly DecimalProperty PROPERTY_SPADPACKID_ADPRICE = new DecimalProperty(Property.ForName(PROPERTY_SPADPACKID_ALIAS_NAME + ".AdPrice"));
		#endregion
		public static readonly EntityProperty<SPSClientEntity> PROPERTY_SPCLIENTID = new EntityProperty<SPSClientEntity>(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPCLIENTID));
		#region sPClientID字段外键查询字段
        public static NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> InClude_SPClientID_Query(NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> queryGenerator)
        {
            return queryGenerator.AddAlians(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPCLIENTID, PROPERTY_SPCLIENTID_ALIAS_NAME);
        }
        public static readonly string PROPERTY_SPCLIENTID_ALIAS_NAME = "SPClientID_SPAdAssignedHistortyEntity_Alias";
		public static readonly IntProperty PROPERTY_SPCLIENTID_ID = new IntProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".Id"));
		public static readonly StringProperty PROPERTY_SPCLIENTID_NAME = new StringProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".Name"));
		public static readonly StringProperty PROPERTY_SPCLIENTID_DESCRIPTION = new StringProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".Description"));
		public static readonly IntProperty PROPERTY_SPCLIENTID_USERID = new IntProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".UserID"));
		public static readonly BoolProperty PROPERTY_SPCLIENTID_ISDEFAULTCLIENT = new BoolProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".IsDefaultClient"));
		public static readonly BoolProperty PROPERTY_SPCLIENTID_SYNCDATA = new BoolProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".SyncData"));
		public static readonly IntProperty PROPERTY_SPCLIENTID_SYCNNOTINTERCEPTCOUNT = new IntProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".SycnNotInterceptCount"));
		public static readonly EntityProperty<SPSDataSycnSettingEntity> PROPERTY_SPCLIENTID_SYNCDATASETTING = new EntityProperty<SPSDataSycnSettingEntity>(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".SyncDataSetting"));
		public static readonly StringProperty PROPERTY_SPCLIENTID_ALIAS = new StringProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".Alias"));
		public static readonly BoolProperty PROPERTY_SPCLIENTID_ISENABLE = new BoolProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".IsEnable"));
		public static readonly DecimalProperty PROPERTY_SPCLIENTID_INTERCEPTRATE = new DecimalProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".InterceptRate"));
		public static readonly DecimalProperty PROPERTY_SPCLIENTID_DEFAULTPRICE = new DecimalProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".DefaultPrice"));
		public static readonly IntProperty PROPERTY_SPCLIENTID_DEFAULTSHOWRECORDDAYS = new IntProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".DefaultShowRecordDays"));
		public static readonly StringProperty PROPERTY_SPCLIENTID_CHANNELSTATUS = new StringProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".ChannelStatus"));
		public static readonly IntProperty PROPERTY_SPCLIENTID_CREATEBY = new IntProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".CreateBy"));
		public static readonly DateTimeProperty PROPERTY_SPCLIENTID_CREATEAT = new DateTimeProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".CreateAt"));
		public static readonly IntProperty PROPERTY_SPCLIENTID_LASTMODIFYBY = new IntProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".LastModifyBy"));
		public static readonly DateTimeProperty PROPERTY_SPCLIENTID_LASTMODIFYAT = new DateTimeProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".LastModifyAt"));
		public static readonly StringProperty PROPERTY_SPCLIENTID_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(PROPERTY_SPCLIENTID_ALIAS_NAME + ".LastModifyComment"));
		#endregion
		public static readonly DecimalProperty PROPERTY_CLIENTPRICE = new DecimalProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_CLIENTPRICE));		
		public static readonly DateTimeProperty PROPERTY_STARTDATE = new DateTimeProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_STARTDATE));		
		public static readonly DateTimeProperty PROPERTY_ENDDATE = new DateTimeProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_ENDDATE));		
		public static readonly IntProperty PROPERTY_CREATEBY = new IntProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_CREATEBY));		
		public static readonly DateTimeProperty PROPERTY_CREATEAT = new DateTimeProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_CREATEAT));		
		public static readonly IntProperty PROPERTY_LASTMODIFYBY = new IntProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_LASTMODIFYBY));		
		public static readonly DateTimeProperty PROPERTY_LASTMODIFYAT = new DateTimeProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_LASTMODIFYAT));		
		public static readonly StringProperty PROPERTY_LASTMODIFYCOMMENT = new StringProperty(Property.ForName(SPAdAssignedHistortyEntity.PROPERTY_NAME_LASTMODIFYCOMMENT));		
      












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
                case "SPAdID":
                    return typeof (int);
                case "SPAdPackID":
                    return typeof (int);
                case "SPClientID":
                    return typeof (int);
                case "ClientPrice":
                    return typeof (decimal);
                case "StartDate":
                    return typeof (DateTime);
                case "EndDate":
                    return typeof (DateTime);
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

		#region 获取外键字段类型
		
		public override Type GetFieldTypeByFieldName(string fieldName, string parent_alias)
        {
            switch (parent_alias)
            {
	            case "SPAdPackID_SPAdAssignedHistortyEntity_Alias":
					switch (fieldName)
					{
                		case "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Id":
							return typeof (int);
                		case "SPAdPackID_SPAdAssignedHistortyEntity_Alias.SPAdID":
							return typeof (int);
                		case "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Name":
							return typeof (string);
                		case "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Code":
							return typeof (string);
                		case "SPAdPackID_SPAdAssignedHistortyEntity_Alias.Description":
							return typeof (string);
                		case "SPAdPackID_SPAdAssignedHistortyEntity_Alias.AdPrice":
							return typeof (decimal);
          			}
                    break;
	            case "SPClientID_SPAdAssignedHistortyEntity_Alias":
					switch (fieldName)
					{
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.Id":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.Name":
							return typeof (string);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.Description":
							return typeof (string);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.UserID":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.IsDefaultClient":
							return typeof (bool);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.SyncData":
							return typeof (bool);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.SycnNotInterceptCount":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.SyncDataSetting":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.Alias":
							return typeof (string);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.IsEnable":
							return typeof (bool);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.InterceptRate":
							return typeof (decimal);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.DefaultPrice":
							return typeof (decimal);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.DefaultShowRecordDays":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.ChannelStatus":
							return typeof (string);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.CreateBy":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.CreateAt":
							return typeof (DateTime);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.LastModifyBy":
							return typeof (int);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.LastModifyAt":
							return typeof (DateTime);
                		case "SPClientID_SPAdAssignedHistortyEntity_Alias.LastModifyComment":
							return typeof (string);
          			}
                    break;
 
                default:
                    break;
            }

            return typeof(string);
        }
		
		#endregion

        public override void InClude_Parent_Table(string parent_alias, NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> queryGenerator)
        {
            switch (parent_alias)
            {
	            case "SPAdPackID_SPAdAssignedHistortyEntity_Alias":
                    queryGenerator.AddAlians(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPADPACKID, PROPERTY_SPADPACKID_ALIAS_NAME);
                    break;
	            case "SPClientID_SPAdAssignedHistortyEntity_Alias":
                    queryGenerator.AddAlians(SPAdAssignedHistortyEntity.PROPERTY_NAME_SPCLIENTID, PROPERTY_SPCLIENTID_ALIAS_NAME);
                    break;
                default:
                    break;
 
            }
        }
		
		
		
		public List<SPAdAssignedHistortyEntity> GetList_By_SPAdPackID_SPAdPackEntity(SPAdPackEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_SPADPACKID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPAdAssignedHistortyEntity> GetPageList_By_SPAdPackID_SPAdPackEntity(string orderByColumnName, bool isDesc, SPAdPackEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_SPADPACKID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		
		public List<SPAdAssignedHistortyEntity> GetList_By_SPClientID_SPSClientEntity(SPSClientEntity fkentity)
		{
			NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_SPCLIENTID.Eq(fkentity));

            return this.FindListByQueryBuilder(dynamicQueryGenerator);
		}
		
		
        public List<SPAdAssignedHistortyEntity> GetPageList_By_SPClientID_SPSClientEntity(string orderByColumnName, bool isDesc, SPSClientEntity fkentity, PageQueryParams pageQueryParams)
        {
            NHibernateDynamicQueryGenerator<SPAdAssignedHistortyEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            dynamicQueryGenerator.AddWhereClause(PROPERTY_SPCLIENTID.Eq(fkentity));

            AddDefaultOrderByToQueryGenerator(orderByColumnName, isDesc, dynamicQueryGenerator);

            return FindListByPageByQueryBuilder(dynamicQueryGenerator, pageQueryParams);
        }		
		

		
		
    }
}
