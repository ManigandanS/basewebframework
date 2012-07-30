﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using Legendigital.Framework.Common.BaseFramework.Bussiness.Wrappers;

namespace SNFramework.BSF.Moudles.SystemManage.RoleManage
{
    [DirectMethodProxyID(IDMode = DirectMethodProxyIDMode.Alias, Alias = "UCSystemRoleAdd")]
    public partial class UCSystemRoleAdd : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [DirectMethod]
        public void Show()
        {
            try
            {
                this.winSystemRoleAdd.Show();
            }
            catch (Exception ex)
            {
                ResourceManager.AjaxSuccess = false;
                ResourceManager.AjaxErrorMessage = string.Format(this.GetGlobalResourceObject("GlobalResource", "msgServerErrorMsg").ToString(), ex.Message);
            }
        }

        protected void btnSaveSystemRole_Click(object sender, DirectEventArgs e)
        {
            try
            {
                SystemRoleWrapper obj = new SystemRoleWrapper();
                obj.RoleName = this.txtRoleName.Text.Trim();
                obj.RoleCode = this.txtRoleCode.Text.Trim();
                obj.RoleDescription = this.txtRoleDescription.Text.Trim();
                obj.RoleIsSystemRole = this.chkRoleIsSystemRole.Checked;


                SystemRoleWrapper.Save(obj);

                winSystemRoleAdd.Hide();

            }
            catch (Exception ex)
            {
                ResourceManager.AjaxSuccess = false;
                ResourceManager.AjaxErrorMessage = string.Format(this.GetGlobalResourceObject("GlobalResource", "msgServerErrorMsg").ToString(), ex.Message);
            }
        }
    }
}