﻿ALTER TABLE [dbo].[SystemPrivilegeParameter]
    ADD CONSTRAINT [PK_SystemPrivilegeParameter] PRIMARY KEY CLUSTERED ([PrivilegeParameterID] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

