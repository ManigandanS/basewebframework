/****** Object:  Table [dbo].[SystemApplication]    Script Date: 06/07/2010 00:31:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemApplication]') AND type in (N'U'))
DROP TABLE [dbo].[SystemApplication]
GO
/****** Object:  Table [dbo].[SystemApplication]    Script Date: 06/07/2010 00:31:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SystemApplication]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[SystemApplication](
	[SystemApplication_ID] [int] IDENTITY(1,1) NOT NULL,
	[SystemApplication_Name] [nvarchar](200) NOT NULL,
	[SystemApplication_Description] [nvarchar](2000) NULL,
	[SystemApplication_Url] [nvarchar](200) NULL,
	[SystemApplication_IsSystemApplication] [bit] NULL,
 CONSTRAINT [PK_SystemApplication] PRIMARY KEY CLUSTERED 
(
	[SystemApplication_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_SystemApplication_SystemApplication_IsSystemApplication]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[SystemApplication] ADD  CONSTRAINT [DF_SystemApplication_SystemApplication_IsSystemApplication]  DEFAULT ((0)) FOR [SystemApplication_IsSystemApplication]
END

GO
