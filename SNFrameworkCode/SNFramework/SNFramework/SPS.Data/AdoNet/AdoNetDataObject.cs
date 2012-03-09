// Generated by MyGeneration Version # (1.3.0.9)
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using SPS.Entity.Tables;
using Spring.Data.Common;

namespace SPS.Data.AdoNet
{
    public enum DayReportType
    {
        AllUp,
        AllUpSuccess,
        Intercept,
        Down,
        DownSycnSuccess,
        DownNotSycn,
        DownSycnFailed
    }


    public partial class AdoNetDataObject
    {

        #region Common

        private T GetScalarFromDataSet<T>(DataTable dt, int columnIndex)
        {
            DataRow dr = GetFristDataRowFromDataTable(dt);

            if (dr != null && dr.Table.Columns.Count >= columnIndex + 1)
                return (T)dr[columnIndex];
            return default(T);
        }

        private T GetScalarFromDataSet<T>(DataSet ds, int columnIndex)
        {
            return GetScalarFromDataSet<T>(GetDataTableFromDataSet(ds), columnIndex);
        }

        private DataRow GetFristDataRowFromDataSet(DataSet ds)
        {
            return GetFristDataRowFromDataTable(GetDataTableFromDataSet(ds));
        }

        private DataRow GetFristDataRowFromDataTable(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
                return dt.Rows[0];
            return null;
        }

        private DataTable GetDataTableFromDataSet(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }

        #endregion

        public void UpdateUrlFailedSend(int recordId, string url,string errMessage)
        {
            if(errMessage.Length>50)
            {
                errMessage = errMessage.Substring(0, 50);
            }


            string sql = "update SPRecordExtendInfo set sSycnDataUrl=@sSycnDataUrl,sSycnDataFailedMessage=@Error where RecordID=@RecordID ;";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("sSycnDataUrl", url);

            dbParameters.AddWithValue("RecordID", recordId);

            dbParameters.AddWithValue("Error", errMessage);

            this.ExecuteNoQuery(sql, CommandType.Text, dbParameters);

        }

        public void UpdateUrlSuccessSend(int recordId, string url)
        {

            string sql = "update SPRecord set IsSycnSuccessed =1  where ID=@RecordID and IsIntercept=0 and IsSycnToClient=1 and IsStatOK=1;" +
                         "update SPRecordExtendInfo set  sSycnDataUrl=@sSycnDataUrl,sSycnDataFailedMessage='' where RecordID=@RecordID ;";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("sSycnDataUrl", url);

            dbParameters.AddWithValue("RecordID", recordId);

            this.ExecuteNoQuery(sql, CommandType.Text, dbParameters);
 
        }

        public DataTable CaculateReport(DateTime reportDate,DayReportType dayReportType)
        {
            string sql = "Select [ChannelID],[ClientID],[CodeID],Sum([Count]) as RecordCount from SPRecord with(nolock) where CreateDate >= @startDate and  CreateDate <  @endDate";

            sql += BuildDayReportTypeFilterSql(dayReportType);

            sql += " group by [ChannelID],[ClientID],[CodeID]";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("startDate", reportDate.Date);

            dbParameters.AddWithValue("endDate", reportDate.Date.AddDays(1));

 
            return this.ExecuteDataSet(sql, CommandType.Text, dbParameters).Tables[0];
        }

        public DataTable CaculateReport(DateTime reportDate, DayReportType dayReportType, SPSClientEntity clientEntity)
        {
            string sql = "Select [ChannelID],[CodeID],Sum([Count]) as RecordCount from SPRecord with(nolock) where CreateDate >= @startDate and  CreateDate <  @endDate and [ClientID] = @ClientID";

            sql += BuildDayReportTypeFilterSql(dayReportType);

            sql += " group by [ChannelID],[CodeID]";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("startDate", reportDate.Date);

            dbParameters.AddWithValue("endDate", reportDate.Date.AddDays(1));

            dbParameters.AddWithValue("ClientID", clientEntity.Id);

            return this.ExecuteDataSet(sql, CommandType.Text, dbParameters).Tables[0];
        }

        private static string BuildDayReportTypeFilterSql(DayReportType dayReportType)
        {
            string filterSql = "";

            switch (dayReportType)
            {
                case DayReportType.AllUp:
                    filterSql += " AND IsReport =0";
                    break;
                case DayReportType.AllUpSuccess:
                    filterSql += " AND IsReport =0 AND IsStatOK = 1 ";
                    break;
                case DayReportType.Intercept:
                    filterSql += " AND IsReport =0 AND  IsStatOK = 1 AND IsIntercept = 1 ";
                    break;
                case DayReportType.Down:
                    filterSql += " AND IsReport =0 AND  IsStatOK = 1 AND IsIntercept = 0 ";
                    break;
                case DayReportType.DownNotSycn:
                    filterSql += " AND IsReport =0 AND  IsStatOK = 1 AND IsIntercept = 0 AND IsSycnToClient = 0 ";
                    break;
                case DayReportType.DownSycnSuccess:
                    filterSql += " AND IsReport =0 AND  IsStatOK = 1 AND IsIntercept = 0 AND IsSycnToClient = 1 AND IsSycnSuccessed = 1 ";
                    break;
                case DayReportType.DownSycnFailed:
                    filterSql += " AND IsReport =0 AND  IsStatOK = 1 AND IsIntercept = 0 AND IsSycnToClient = 1 AND IsSycnSuccessed = 0 ";
                    break;
            }
            return filterSql;
        }

        public void RestAllReportedData(DateTime date)
        {
            string sql = "update SPRecord set  IsReport = 0  where CreateDate >= @startDate and  CreateDate <  @endDate";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("startDate", date.Date);

            dbParameters.AddWithValue("endDate", date.Date.AddDays(1));

            this.ExecuteNoQuery(sql, CommandType.Text, dbParameters);
        }

        public void ClearAllReportedData(DateTime date)
        {
            string sql = "update SPRecord set  IsReport = 1  where CreateDate >= @startDate and  CreateDate <  @endDate";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("startDate", date.Date);

            dbParameters.AddWithValue("endDate", date.Date.AddDays(1));

            this.ExecuteNoQuery(sql, CommandType.Text, dbParameters);
        }

        public decimal CaculteActualInterceptRate(SPClientCodeRelationEntity clientCodeRelation, DateTime date)
        {
            string sql = "SELECT  IsIntercept,COUNT(*) as RCount FROM [SPRecord] with(nolock) where CreateDate>@startDate and CreateDate<@endDate and ClientCodeRelationID=@ClientCodeRelationID and IsStatOK=1 group by IsIntercept";

            DbParameters dbParameters = this.CreateNewDbParameters();

            dbParameters.AddWithValue("startDate", date.Date);

            dbParameters.AddWithValue("endDate", date.Date.AddDays(1));

            dbParameters.AddWithValue("ClientCodeRelationID", clientCodeRelation.Id);

            DataTable dt = this.ExecuteDataSet(sql, CommandType.Text, dbParameters).Tables[0];

            object result = dt.Compute("Sum(RCount)","");

            int totalCount = 0;

            if(result!=System.DBNull.Value)
            {
                totalCount = Convert.ToInt32( result);
            }

            int totalInterceptCount = 0;

            object result2 = dt.Compute("Sum(RCount)", " IsIntercept =1 ");

            if (result2 != System.DBNull.Value)
            {
                totalInterceptCount = Convert.ToInt32( result2);
            }

            if (totalCount <= 0)
                return Decimal.Zero;

            return (decimal) totalInterceptCount/(decimal) totalCount;
        }

        public DataSet QueryRecordProvine(DateTime? startDate, DateTime? endDate, DayReportType dayReportType, int? channelId, int? codeID, int? clientID)
        {
            string sql = "SELECT [Province] ,count(*) as ProvinceCount FROM  [dbo].[SPRecord] with(nolock)  {0} group by  [Province]";

            string where = " Where 1=1  ";

            where += BuildDayReportTypeFilterSql(dayReportType);

            if (startDate.HasValue)
                where += " and CreateDate>=@startDate ";

            if (endDate.HasValue)
                where += " and CreateDate<@endDate ";

            if (channelId.HasValue)
                where += " and ChannelID=@ChannelId ";

            if (codeID.HasValue)
                where += " and CodeID=@CodeID ";

            if (clientID.HasValue)
                where += " and ClientID=@ClientID ";

            DbParameters dbParameters = this.CreateNewDbParameters();

            if (startDate.HasValue)
                dbParameters.AddWithValue("startDate", startDate.Value.Date);

            if (endDate.HasValue)
                dbParameters.AddWithValue("endDate", endDate.Value.Date.AddDays(1));

            if (channelId.HasValue)
                dbParameters.AddWithValue("ChannelId", channelId.Value);

            if (codeID.HasValue)
                dbParameters.AddWithValue("CodeID", codeID.Value);

            if (clientID.HasValue)
                dbParameters.AddWithValue("ClientID", clientID.Value);

            return this.ExecuteDataSet(string.Format(sql, where), CommandType.Text, dbParameters);
        }

 
    }
}