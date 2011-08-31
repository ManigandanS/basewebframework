// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using Legendigital.Framework.Common.Exceptions;
using SPS.Data.Tables;
using SPS.Entity.Tables;
using Spring.Transaction.Interceptor;


namespace SPS.Bussiness.ServiceProxys.Tables
{
	public interface ISPChannelServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPChannelEntity> ,ISPChannelServiceProxyDesigner
    {
	    void QuickAddSPChannel(SPChannelEntity channelEntity, string pLinkId, string pMo, string pMobile, string pSpCode, string pCreateDate, string pProvince, string pCity, string pExtend1, string pExtend2, string pExtend3, string pExtend4, string pExtend5, string pExtend6, string pExtend7, string pExtend8, string pExtend9, string pExtend10);
        void QuickAddIVRChannel(SPChannelEntity channelEntity, string pIvrLinkId, string pIvrFeetime, string pIvrMobile, string pIvrspCode, string pIvrStartTime, string pIvrEndTime, string pIvrProvince, string pIvrCity, string pIvrExtend1, string pIvrExtend2, string pIvrExtend3, string pIvrExtend4, string pIvrExtend5, string pIvrExtend6, string pIvrExtend7, string pIvrExtend8, string pIvrExtend9, string pIvrExtend10);
    }

    internal partial class SPChannelServiceProxy : ISPChannelServiceProxy
    {
        [Transaction(ReadOnly = false)]
        public void QuickAddSPChannel(SPChannelEntity channelEntity, string pLinkId, string pMo, string pMobile, string pSpCode, string pCreateDate, string pProvince, string pCity, string pExtend1, string pExtend2, string pExtend3, string pExtend4, string pExtend5, string pExtend6, string pExtend7, string pExtend8, string pExtend9, string pExtend10)
        {
            if (string.IsNullOrEmpty(pLinkId))
                throw new ArgumentNullException("pLinkId");
            if (string.IsNullOrEmpty(pMo))
                throw new ArgumentNullException("pMo");
            if (string.IsNullOrEmpty(pLinkId))
                throw new ArgumentNullException("pMobile");
            if (string.IsNullOrEmpty(pMo))
                throw new ArgumentNullException("pSpCode");
            
            this.selfDataObject.Save(channelEntity);

            SPSClientEntity spClientEntity =
                this.DataObjectsContainerIocID.SPSClientDataObjectInstance.FindDefaultClient();

            if (spClientEntity==null)
            {
                int defaultSPClientuserID = SystemUserWrapper.QuickAddUser("defaultSPClient", "SPDownUser", "123456", "@163.com");

                if (defaultSPClientuserID<0)
                    throw new Exception("Create defaultSPClient failed");

                SPSClientServiceProxy.NewDefaultSPClient(defaultSPClientuserID);

                this.DataObjectsContainerIocID.SPSClientDataObjectInstance.Save(spClientEntity);
            }

            SPChannelParamsEntity cpLinkId = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pLinkId,"唯一标识","linkid","1");

            this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpLinkId);

            SPChannelParamsEntity cpMo = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pMo, "上行内容", "ywid", "1");

            this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpMo);

            SPChannelParamsEntity cpMobile = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pMobile, "手机号码", "mobile", "1");

            this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpMobile);

            SPChannelParamsEntity cpSpCode = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pSpCode, "通道号码", "cpid", "1");

            this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpSpCode);

            if(!string.IsNullOrEmpty(pCreateDate))
            {
                SPChannelParamsEntity cpCreateDate = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pCreateDate, "数据日期", "CreateDate", "1");

                this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpCreateDate);
            }

            if (!string.IsNullOrEmpty(pProvince))
            {
                SPChannelParamsEntity cpProvince = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pProvince, "省份", "Province", "1");

                this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpProvince);
            }

            if (!string.IsNullOrEmpty(pCity))
            {
                SPChannelParamsEntity cpCity = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pCity, "地市", "City", "1");

                this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpCity);
            }

            if (channelEntity.IsStateReport.HasValue && channelEntity.IsStateReport.Value && !string.IsNullOrEmpty(channelEntity.StateReportParamName))
            {
                SPChannelParamsEntity cpStateReport = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, channelEntity.StateReportParamName, "状态", "Status", "1");

                this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpStateReport);
            }

            if (!string.IsNullOrEmpty(pExtend1))
            {
                SPChannelParamsEntity cpExtend1 = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pExtend1, "扩展1", "Extend1", "1");

                this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpExtend1);
            }


            if (!string.IsNullOrEmpty(pExtend2))
            {
                SPChannelParamsEntity cpExtend2 = SPChannelParamsServiceProxy.NewChannelParams(channelEntity, pExtend1, "扩展2", "Extend2", "1");

                this.DataObjectsContainerIocID.SPChannelParamsDataObjectInstance.Save(cpExtend2);
            }

        }




        [Transaction(ReadOnly = false)]
        public void QuickAddIVRChannel(SPChannelEntity channelEntity, string pIvrLinkId, string pIvrFeetime, string pIvrMobile, string pIvrspCode, string pIvrStartTime, string pIvrEndTime, string pIvrProvince, string pIvrCity, string pIvrExtend1, string pIvrExtend2, string pIvrExtend3, string pIvrExtend4, string pIvrExtend5, string pIvrExtend6, string pIvrExtend7, string pIvrExtend8, string pIvrExtend9, string pIvrExtend10)
        {
            throw new NotImplementedException();
        }
    }
}
