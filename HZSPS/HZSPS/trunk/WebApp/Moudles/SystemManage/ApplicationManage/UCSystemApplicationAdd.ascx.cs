﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;

namespace Legendigital.Common.WebApp.Moudles.SystemManage.ApplicationManage
{
      [DirectMethodProxyID(IDMode = DirectMethodProxyIDMode.Alias, Alias = "UCSystemApplicationAdd")]
    public partial class UCSystemApplicationAdd : System.Web.UI.UserControl
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        [DirectMethod]
        public void Show()
        {
            try
            {
                this.winSystemApplicationAdd.Show();
            }
            catch (Exception ex)
            {
                ResourceManager.AjaxSuccess = false;
                ResourceManager.AjaxErrorMessage = "Error Message:" + ex.Message;
            }
        }

        protected void btnSaveSystemApplication_Click(object sender, DirectEventArgs e)
        {
            try
            {
                SystemApplicationWrapper systemApplication = new SystemApplicationWrapper();
                systemApplication.SystemApplicationName = txtSystemApplicationName.Text.Trim();
                systemApplication.SystemApplicationDescription = txtSystemApplicationDescription.Text.Trim();
                systemApplication.SystemApplicationUrl = txtSystemApplicationUrl.Text.Trim();
                systemApplication.SystemApplicationIsSystemApplication = chkSystemApplicationIsSystemApplication.Checked;

                SystemApplicationWrapper.Save(systemApplication);

                winSystemApplicationAdd.Hide();

            }
            catch (Exception ex)
            {
                ResourceManager.AjaxSuccess = false;
                ResourceManager.AjaxErrorMessage = "Error Message:" + ex.Message;
            }
        }
    }
}