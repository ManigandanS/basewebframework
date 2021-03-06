/****** Object:  View [dbo].[view_ReportDayTotal]    Script Date: 06/27/2010 16:11:38 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[view_ReportDayTotal]'))
DROP VIEW [dbo].[view_ReportDayTotal]
GO
/****** Object:  View [dbo].[view_ReportDayTotal]    Script Date: 06/27/2010 16:11:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[view_ReportDayTotal]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[view_ReportDayTotal]
AS
SELECT   ChannelID, ClientID
FROM      (SELECT   ChannelID, ClinetID AS ClientID
                 FROM      dbo.SPClientChannelSetting
                 GROUP BY ChannelID, ClinetID
                 UNION
                 SELECT   ChannelID, ClientID
                 FROM      view_PaymentReport
                 GROUP BY ChannelID, ClientID) AS tb
GROUP BY ChannelID, ClientID
' 
GO
