using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebRoleRekenModule.ServRefRekenModule;
using WebRoleRekenModule.ServRefRekenModule32;

namespace WebRoleRekenModule
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculateDll_Click(object sender, EventArgs e)
        {
            lblErrorDll.Text = string.Empty;
            ServRefRekenModule.RekenModuleServiceClient f = new RekenModuleServiceClient();

            int result = 0;
            try
            {
                result = f.RekenDllExample();
            }
            catch (Exception exception)
            {
                lblErrorDll.Text = exception.Message;
            }

            f.Close();
            lblResultdll.Text = result.ToString();
        }

        protected void btnCalculateDllMutex_Click(object sender, EventArgs e)
        {
            lblResultdllMutex.Text = string.Empty;
            ServRefRekenModule.RekenModuleServiceClient f = new RekenModuleServiceClient();

            int result = 0;
            try
            {
                result = f.RekenDllExampleMutex();
            }
            catch (Exception exception)
            {
                lblErrorDllMutex.Text = exception.Message;
            }

            f.Close();
            lblResultdllMutex.Text = result.ToString();
        }

        protected void btnCalculateDll32_Click(object sender, EventArgs e)
        {
            lblResult32.Text = string.Empty;
            ServRefRekenModule32.IRekenModule32 f = new RekenModule32Client();

            int result = 0;
            try
            {
                result = f.Calculate32();
            }
            catch (Exception exception)
            {
                lblErrorDll32.Text = exception.Message;
            }

            lblResult32.Text = result.ToString();
        }

        protected void btnCalculateDll32Mutex_Click(object sender, EventArgs e)
        {
            lblResult32Mutex.Text = string.Empty;
            ServRefRekenModule32.IRekenModule32 f = new RekenModule32Client();

            int result = 0;
            try
            {
                result = f.Calculate32Mutex();
            }
            catch (Exception exception)
            {
                lblErrorDll32Mutex.Text = exception.Message;
            }

            lblResult32Mutex.Text = result.ToString();
        }
    }
}