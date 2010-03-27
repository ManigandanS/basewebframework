// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using NHibernate.Criterion;
using Legendigital.Framework.Common.Data.NHibernate.DynamicQuery;
using Legendigital.Framework.Common.BaseFramework.Entity.Tables;
using Legendigital.Framework.Common.Data.NHibernate;

namespace Legendigital.Framework.Common.BaseFramework.Data.Tables
{
    public partial class SystemUserRoleRelationDataObject
    {
        /// <summary>
        /// 获取用户分配的角色
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns></returns>
        public List<SystemRoleEntity> GetUserAssignedRoles(SystemUserEntity user)
        {
            NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> queryGenerator = this.GetNewQueryBuilder();

            queryGenerator.AddWhereClause(PROPERTY_USERID.Eq(user));

            return this.FindListByProjection<SystemRoleEntity>(queryGenerator, SystemUserRoleRelationDataObject.PROPERTY_ROLEID);
        }

        /// <summary>
        /// 获取角色包含的所有用户
        /// </summary>
        /// <param name="role">角色</param>
        /// <returns></returns>
        public List<SystemUserEntity> GetRoleAssignedUsers(SystemRoleEntity role)
        {
            NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> queryGenerator = this.GetNewQueryBuilder();

            queryGenerator.AddWhereClause(SystemUserRoleRelationDataObject.PROPERTY_ROLEID.Eq(role));

            return
                this.FindListByProjection<SystemUserEntity>(queryGenerator, SystemUserRoleRelationDataObject.PROPERTY_USERID);
        }

        /// <summary>
        /// 获取用户角色关系是否存在
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="role">角色</param>
        /// <returns></returns>
        public SystemUserRoleRelationEntity GetUserRoleRelation(SystemUserEntity user, SystemRoleEntity role)
        {
            NHibernateDynamicQueryGenerator<SystemUserRoleRelationEntity> queryGenerator = this.GetNewQueryBuilder();

            queryGenerator.AddWhereClause(PROPERTY_USERID.Eq(user));

            queryGenerator.AddWhereClause(PROPERTY_ROLEID.Eq(role));

            return this.FindSingleEntityByQueryBuilder(queryGenerator);
        }






    }
}
