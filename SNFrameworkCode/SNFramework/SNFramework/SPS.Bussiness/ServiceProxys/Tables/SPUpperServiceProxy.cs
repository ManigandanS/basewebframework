// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using SPS.Data.Tables;
using SPS.Entity.Tables;


namespace SPS.Bussiness.ServiceProxys.Tables
{
    public interface ISPUpperServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPUpperEntity, int>, ISPUpperServiceProxyDesigner
    {


    }

    internal partial class SPUpperServiceProxy : BaseSpringNHibernateEntityServiceProxy<SPUpperEntity,int>, ISPUpperServiceProxy
    {


    }
}
