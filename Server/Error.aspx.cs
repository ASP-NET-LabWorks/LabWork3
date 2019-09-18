using System;
using System.Web.UI;

namespace Server
{
    public partial class Error : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            throw new ApplicationException("Test");
        }
    }
}