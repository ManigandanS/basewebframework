﻿ALTER TABLE [dbo].[SystemDepartment]
    ADD CONSTRAINT [PK_SystemDepartment] PRIMARY KEY CLUSTERED ([Department_ID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

