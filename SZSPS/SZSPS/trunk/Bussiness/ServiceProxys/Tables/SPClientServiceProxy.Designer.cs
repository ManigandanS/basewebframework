// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Data.Tables;
using LD.SPPipeManage.Entity.Tables;
using LD.SPPipeManage.Data.Tables.Container;
using LD.SPPipeManage.Data.AdoNet;




namespace LD.SPPipeManage.Bussiness.ServiceProxys.Tables
{

    public interface ISPClientServiceProxyDesigner
    {
		List<SPClientEntity> FindAllByOrderByAndFilterAndSPClientGroupID(string orderByColumnName, bool isDesc, int pageIndex, int pageSize,    SPClientGroupEntity _sPClientGroupID, out int recordCount);
		List<SPClientEntity> FindAllBySPClientGroupID(SPClientGroupEntity _sPClientGroupID);
    }


    internal partial class SPClientServiceProxy : BaseSpringNHibernateEntityServiceProxy<SPClientEntity> , ISPClientServiceProxyDesigner
    {
		public DataObjectContainers DataObjectsContainerIocID { set; get; }
	
        public SPClientDataObject SelfDataObj
        {
            set
            {
                selfDataObject = value;
            }
			get
            {
                return (SPClientDataObject)selfDataObject;
            }
        }
	
		public List<SPClientEntity> FindAllByOrderByAndFilterAndSPClientGroupID(string orderByColumnName, bool isDesc,int pageIndex, int pageSize,     SPClientGroupEntity _sPClientGroupID,  out int recordCount)
        {
			return this.SelfDataObj.GetPageList_By_SPClientGroupEntity(orderByColumnName, isDesc,pageIndex, pageSize,_sPClientGroupID, out recordCount);
        }
		
		public List<SPClientEntity> FindAllBySPClientGroupID(SPClientGroupEntity _sPClientGroupID)
        {
			return this.SelfDataObj.GetList_By_SPClientGroupEntity(_sPClientGroupID);
        }

		
		
        public AdoNetDataObject AdoNetDb { set; get; }		

		
    }
}
