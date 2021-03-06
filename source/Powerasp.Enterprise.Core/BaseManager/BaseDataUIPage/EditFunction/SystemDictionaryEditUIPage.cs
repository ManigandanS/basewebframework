﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Powerasp.Enterprise.Core.BaseManager.Domain;
using Powerasp.Enterprise.Core.BaseManager.Service;
using Powerasp.Enterprise.Core.Web.BasePage;
using Powerasp.Enterprise.Core.Attribute;

namespace Powerasp.Enterprise.Core.BaseManager.BaseDataUIPage.EditFunction
{
	[WebDataModule("系统字典表")]
    public class SystemDictionaryEditUIPage : BaseDataEditPage<SystemDictionary>
    {
        protected SystemDictionaryService systemDictionaryServiceInstance;

        public SystemDictionaryService SystemDictionaryServiceInstance
        {
            set { systemDictionaryServiceInstance = value; }
        }
		 protected override SystemDictionary LoadDataByID(int id)
        {
            return systemDictionaryServiceInstance.FindById(id);
        }

        protected override void DeleteDataByID(int id)
        {
            systemDictionaryServiceInstance.DeleteByID(id);
        }

        protected override void UpdateData(SystemDictionary obj)
        {
            systemDictionaryServiceInstance.Update(obj);
        }
    }
}



