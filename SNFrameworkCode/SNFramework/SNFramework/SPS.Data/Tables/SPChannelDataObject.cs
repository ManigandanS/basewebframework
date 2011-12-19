// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using NHibernate.SqlCommand;
using NHibernate.Type;
using SPS.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;

namespace SPS.Data.Tables
{
    public partial class SPChannelDataObject
    {
        public SPChannelEntity GetChannelByDataAdaptorUrl(string dataAdaptorUrl)
        {
            NHibernateDynamicQueryGenerator<SPChannelEntity> dynamicQueryGenerator = this.GetNewQueryBuilder();

            //指定查询条件
            dynamicQueryGenerator.AddWhereClause(FindUrl(dataAdaptorUrl));

           return this.FindSingleEntityByQueryBuilder(dynamicQueryGenerator);

            //if (spChannelEntity != null && (spChannelEntity.Code + spChannelEntity.DataAdapterUrl).ToLower().Trim().Equals(dataAdaptorUrl.ToLower().Trim()))
            //    return spChannelEntity;
            //else
            //    return null;
        }

        public ICriterion FindUrl(string dataAdaptorUrl)
        {
            string hql = string.Format("( ({0} + {1}) = ? )",SPChannelEntity.PROPERTY_NAME_CODE,SPChannelEntity.PROPERTY_NAME_DATAADAPTERURL);


            //hql = " (Code + DataAdapterUrl) = 'sptestHttpGetPostAdapter.ashx' ";

            //return Expression.Sql(hql);


            return Expression.Sql(hql, dataAdaptorUrl, NHibernate.NHibernateUtil.String);
        }
    }
}
