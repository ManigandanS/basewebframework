// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Text;
using LD.SPPipeManage.Bussiness.Wrappers;
using Legendigital.Framework.Common.Bussiness.Interfaces;
using Legendigital.Framework.Common.Data.Interfaces;
using Legendigital.Framework.Common.Bussiness.NHibernate;
using LD.SPPipeManage.Data.Tables;
using LD.SPPipeManage.Entity.Tables;
using Spring.Transaction.Interceptor;


namespace LD.SPPipeManage.Bussiness.ServiceProxys.Tables
{
    public interface ISPClientChannelSettingServiceProxy : IBaseSpringNHibernateEntityServiceProxy<SPClientChannelSettingEntity>, ISPClientChannelSettingServiceProxyDesigner
    {
	    List<SPClientChannelSettingEntity> GetSettingByChannel(SPChannelEntity spChannelEntity);
        List<SPChannelEntity> GetChannelByClient(SPClientEntity spClientEntity);
        decimal GetToDayRate(int clinetId, int channelId);
        List<SPClientChannelSycnParamsEntity> GetAllEnableParams(SPClientChannelSettingEntity entity);
        List<SPClientChannelSettingEntity> GetAllNeedRendSetting();
        List<SPClientChannelSettingEntity> GetSettingByClient(SPClientEntity spClientEntity);
        void ChangeClientUser(SPClientChannelSettingEntity oldClientEntity, string clientName, string clientAlias, string userLoginId, int userId);
        void ResetAllSycnCount(SPClientChannelSettingEntity spClientChannelSettingEntity, DateTime date);
        int GetSycnFailedCount(SPClientChannelSettingEntity spClientChannelSettingEntity, DateTime date);
        void ResetIntercept(SPClientChannelSettingEntity spClientChannelSettingEntity, DateTime date, int dataCount);

 
        List<SPClientChannelSettingEntity> FindAllByOrderByAndFilterAndChannelIDAndProvinceAndPort(string sortFieldName, bool isDesc, int channleId, string province, string port, int pageIndex, int pageSize, out int recordCount);
    }

    internal partial class SPClientChannelSettingServiceProxy : ISPClientChannelSettingServiceProxy
    {
        public List<SPClientChannelSettingEntity> GetSettingByChannel(SPChannelEntity spChannelEntity)
        {
            return this.SelfDataObj.GetSettingByChannel(spChannelEntity);
        }

        public List<SPChannelEntity> GetChannelByClient(SPClientEntity spClientEntity)
        {
            List < SPClientChannelSettingEntity > list =
                this.SelfDataObj.GetSettingByClient(
                    spClientEntity);

            List<SPChannelEntity> clients = new List<SPChannelEntity>();

            foreach (SPClientChannelSettingEntity spClientChannelSettingEntity in list)
            {
                if(!clients.Contains(spClientChannelSettingEntity.ChannelID))
                {
                    clients.Add(spClientChannelSettingEntity.ChannelID);
                }
            }

            return clients;

        }

        public decimal GetToDayRate(int clinetId, int channelId)
        {
            return this.AdoNetDb.CountInterceptRate(clinetId, channelId);
        }

        public List<SPClientChannelSycnParamsEntity> GetAllEnableParams(SPClientChannelSettingEntity entity)
        {
            return this.DataObjectsContainerIocID.SPClientChannelSycnParamsDataObjectInstance.GetAllEnableParams(entity);
        }

        public List<SPClientChannelSettingEntity> GetAllNeedRendSetting()
        {
            return this.DataObjectsContainerIocID.SPClientChannelSettingDataObjectInstance.GetAllNeedRendSetting();
        }

 

        public List<SPClientChannelSettingEntity> GetSettingByClient(SPClientEntity spClientEntity)
        {
            return this.DataObjectsContainerIocID.SPClientChannelSettingDataObjectInstance.GetSettingByClient(spClientEntity);
        }
                [Transaction(ReadOnly = false)]
        public void ChangeClientUser(SPClientChannelSettingEntity oldClientEntity, string clientName, string clientAlias, string userLoginId, int userId)
        {
            SPClientEntity mainclientEntity = new SPClientEntity();
            mainclientEntity.Name = oldClientEntity.ChannelID.Name + userLoginId;
            mainclientEntity.Description = oldClientEntity.ChannelID.Name + userLoginId;
            mainclientEntity.UserID = userId;
            mainclientEntity.IsDefaultClient = false;
            mainclientEntity.Alias = "";

            this.DataObjectsContainerIocID.SPClientDataObjectInstance.Save(mainclientEntity);

            SPClientChannelSettingEntity mainChannelClient = new SPClientChannelSettingEntity();

            mainChannelClient.Name = oldClientEntity.ChannelID.Name + userLoginId;
            mainChannelClient.Description = oldClientEntity.ChannelID.Name + userLoginId;
            mainChannelClient.ChannelID = oldClientEntity.ChannelID;
            mainChannelClient.ClinetID = mainclientEntity;
            mainChannelClient.InterceptRate = oldClientEntity.InterceptRate;
            mainChannelClient.InterceptRateType = oldClientEntity.InterceptRateType;
            mainChannelClient.OrderIndex = oldClientEntity.OrderIndex;
            mainChannelClient.UpRate = oldClientEntity.UpRate;
            mainChannelClient.DownRate = oldClientEntity.DownRate;
            mainChannelClient.CommandColumn = oldClientEntity.CommandColumn;
            mainChannelClient.CommandType = oldClientEntity.CommandType;
            mainChannelClient.CommandCode = oldClientEntity.CommandCode;
            mainChannelClient.SyncData = false;
            mainChannelClient.ChannelCode = oldClientEntity.ChannelCode;
            mainChannelClient.Disable = false;
            mainChannelClient.FailedMessage = "failed";
            mainChannelClient.OkMessage = "ok";
            mainChannelClient.SyncDataUrl = "";
            mainChannelClient.SyncType = "2";

            this.DataObjectsContainerIocID.SPClientChannelSettingDataObjectInstance.Save(mainChannelClient);

            oldClientEntity.Disable = true;

            this.DataObjectsContainerIocID.SPClientChannelSettingDataObjectInstance.Save(oldClientEntity);


        }

        public void ResetAllSycnCount(SPClientChannelSettingEntity spClientChannelSettingEntity, DateTime date)
        {
            this.AdoNetDb.ResetAllSycnCount(spClientChannelSettingEntity.Id, date);
        }

        public int GetSycnFailedCount(SPClientChannelSettingEntity spClientChannelSettingEntity, DateTime date)
        {
            return this.AdoNetDb.GetSycnFailedCount(spClientChannelSettingEntity.Id, date);
        }

        public void ResetIntercept(SPClientChannelSettingEntity spClientChannelSettingEntity, DateTime date, int dataCount)
        {
            this.AdoNetDb.ResetIntercept(spClientChannelSettingEntity.Id, date, dataCount);
        }

        public List<SPClientChannelSettingEntity> FindAllByOrderByAndFilterAndChannelIDAndProvinceAndPort(string sortFieldName, bool isDesc, int channleId, string province, string port, int pageIndex, int pageSize, out int recordCount)
        {
            SPChannelEntity channelEntity = null;

            if(channleId>0)
                channelEntity = this.DataObjectsContainerIocID.SPChannelDataObjectInstance.Load(channleId);

            return this.SelfDataObj.FindAllByOrderByAndFilterAndChannelIDAndProvinceAndPort(sortFieldName, isDesc,
                                                                                     channelEntity, province, port,
                                                                                     pageIndex, pageSize,
                                                                                     out recordCount);
        
        }
    }
}
