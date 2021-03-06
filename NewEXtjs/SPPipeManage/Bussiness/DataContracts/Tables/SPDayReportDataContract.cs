using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using LD.SPPipeManage.Bussiness.Wrappers;

namespace LD.SPPipeManage.Bussiness.DataContracts.Tables
{
	/// <summary>
	///	
	/// </summary>
	[DataContract]
	public class SPDayReportDataContract
	{
        #region 公共常量

		public static readonly string CLASS_FULL_NAME = "LD.SPPipeManage.Bussiness.DataContracts.Tables.SPDayReportDataContract";
		public static readonly string PROPERTY_NAME_REPORTID = "ReportID";
		public static readonly string PROPERTY_NAME_REPORTDATE = "ReportDate";
		public static readonly string PROPERTY_NAME_UPTOTALCOUNT = "UpTotalCount";
		public static readonly string PROPERTY_NAME_UPSUCCESS = "UpSuccess";
		public static readonly string PROPERTY_NAME_INTERCEPTTOTALCOUNT = "InterceptTotalCount";
		public static readonly string PROPERTY_NAME_INTERCEPTSUCCESS = "InterceptSuccess";
		public static readonly string PROPERTY_NAME_DOWNTOTALCOUNT = "DownTotalCount";
		public static readonly string PROPERTY_NAME_DOWNSUCCESS = "DownSuccess";
		public static readonly string PROPERTY_NAME_DAYXMLFILENAME = "DayXmlFileName";
		public static readonly string PROPERTY_NAME_CLIENTID = "ClientID";
		public static readonly string PROPERTY_NAME_CHANNELID = "ChannelID";
		public static readonly string PROPERTY_NAME_CHANNELCLIENTID = "ChannelClientID";
		public static readonly string PROPERTY_NAME_UPERID = "UperID";
		public static readonly string PROPERTY_NAME_CLIENTGROUPID = "ClientGroupID";
		
        #endregion
	
        #region 私有成员变量
		
		private int _reportID;
		private DateTime? _reportDate;
		private int? _upTotalCount;
		private int? _upSuccess;
		private int? _interceptTotalCount;
		private int? _interceptSuccess;
		private int? _downTotalCount;
		private int? _downSuccess;
		private string _dayXmlFileName;
		private int? _clientID;
		private int? _channelID;
		private int? _channelClientID;
		private int? _uperID;
		private int? _clientGroupID;
		
		#endregion

		#region 构造函数
		/// <summary>
		/// 默认构造函数
		/// </summary>
		public SPDayReportDataContract()
		{
			_reportID = 0;
			_reportDate = null;
			_upTotalCount = null;
			_upSuccess = null;
			_interceptTotalCount = null;
			_interceptSuccess = null;
			_downTotalCount = null;
			_downSuccess = null;
			_dayXmlFileName = null;
			_clientID = null;
			_channelID = null;
			_channelClientID = null;
			_uperID = null;
			_clientGroupID = null;
		}
		#endregion

	    #region 公共属性

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int ReportID
		{
			get { return _reportID; }

			set	
			{
				_reportID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public DateTime? ReportDate
		{
			get { return _reportDate; }

			set	
			{
				_reportDate = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? UpTotalCount
		{
			get { return _upTotalCount; }

			set	
			{
				_upTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? UpSuccess
		{
			get { return _upSuccess; }

			set	
			{
				_upSuccess = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? InterceptTotalCount
		{
			get { return _interceptTotalCount; }

			set	
			{
				_interceptTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? InterceptSuccess
		{
			get { return _interceptSuccess; }

			set	
			{
				_interceptSuccess = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? DownTotalCount
		{
			get { return _downTotalCount; }

			set	
			{
				_downTotalCount = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? DownSuccess
		{
			get { return _downSuccess; }

			set	
			{
				_downSuccess = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public string DayXmlFileName
		{
			get { return _dayXmlFileName; }

			set	
			{

				if( value != null && value.Length > 400)
					throw new ArgumentOutOfRangeException("Invalid value for DayXmlFileName", value, value.ToString());
				_dayXmlFileName = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? ClientID
		{
			get { return _clientID; }

			set	
			{
				_clientID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? ChannelID
		{
			get { return _channelID; }

			set	
			{
				_channelID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? ChannelClientID
		{
			get { return _channelClientID; }

			set	
			{
				_channelClientID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? UperID
		{
			get { return _uperID; }

			set	
			{
				_uperID = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		[DataMember]
		public int? ClientGroupID
		{
			get { return _clientGroupID; }

			set	
			{
				_clientGroupID = value;
			}
		}

		
		#endregion 


        public void FromWrapper(SPDayReportWrapper wrapper)
		{
			this.ReportID = wrapper.ReportID;
			this.ReportDate = wrapper.ReportDate;
			this.UpTotalCount = wrapper.UpTotalCount;
			this.UpSuccess = wrapper.UpSuccess;
			this.InterceptTotalCount = wrapper.InterceptTotalCount;
			this.InterceptSuccess = wrapper.InterceptSuccess;
			this.DownTotalCount = wrapper.DownTotalCount;
			this.DownSuccess = wrapper.DownSuccess;
			this.DayXmlFileName = wrapper.DayXmlFileName;
			this.ClientID = wrapper.ClientID;
			this.ChannelID = wrapper.ChannelID;
			this.ChannelClientID = wrapper.ChannelClientID;
			this.UperID = wrapper.UperID;
			this.ClientGroupID = wrapper.ClientGroupID;
		}
		
		
		public SPDayReportWrapper ToWrapper()
        {
			SPDayReportWrapper wrapper = new SPDayReportWrapper();
			wrapper.ReportID = this.ReportID;
			wrapper.ReportDate = this.ReportDate;
			wrapper.UpTotalCount = this.UpTotalCount;
			wrapper.UpSuccess = this.UpSuccess;
			wrapper.InterceptTotalCount = this.InterceptTotalCount;
			wrapper.InterceptSuccess = this.InterceptSuccess;
			wrapper.DownTotalCount = this.DownTotalCount;
			wrapper.DownSuccess = this.DownSuccess;
			wrapper.DayXmlFileName = this.DayXmlFileName;
			wrapper.ClientID = this.ClientID;
			wrapper.ChannelID = this.ChannelID;
			wrapper.ChannelClientID = this.ChannelClientID;
			wrapper.UperID = this.UperID;
			wrapper.ClientGroupID = this.ClientGroupID;
		
		return wrapper;
        }



   }
}
