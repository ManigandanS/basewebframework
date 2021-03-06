// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using LD.SPPipeManage.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;

namespace LD.SPPipeManage.Data.Tables
{
    public partial class SPSStatePaymentInfoDataObject
    {
        public SPSStatePaymentInfoEntity CheckChannleLinkIDIsExist(int channelID, SPSStatePaymentInfoEntity statePaymentInfoEntity, List<string> uniqueKeyNames)
        {
            var queryBuilder = new NHibernateDynamicQueryGenerator<SPSStatePaymentInfoEntity>();

            queryBuilder.AddWhereClause(PROPERTY_CHANNELID.Eq(channelID));

            queryBuilder.AddWhereClause(PROPERTY_LINKID.Eq(statePaymentInfoEntity.Linkid));

            if (uniqueKeyNames.Contains("mobile"))
                queryBuilder.AddWhereClause(PROPERTY_MOBILENUMBER.Eq(statePaymentInfoEntity.MobileNumber));

            return this.FindSingleEntityByQueryBuilder(queryBuilder);
        }

        public SPSStatePaymentInfoEntity FindByChannelIDAndLinkID(int channelId, string linkid)
        {
            var queryBuilder = new NHibernateDynamicQueryGenerator<SPSStatePaymentInfoEntity>();

            queryBuilder.AddWhereClause(PROPERTY_CHANNELID.Eq(channelId));

            queryBuilder.AddWhereClause(PROPERTY_LINKID.Eq(linkid));

            return this.FindSingleEntityByQueryBuilder(queryBuilder);
        }
    }
}
