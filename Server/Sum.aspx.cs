using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Server
{
    public partial class About : Page
    {
        private static readonly HttpClient client = new HttpClient();

        private async System.Threading.Tasks.Task SendRequest()
        {
            try
            {
                var a = TextBoxA.Text;
                var b = TextBoxB.Text;

                HttpResponseMessage response;
                    
                response = await client.GetAsync($"https://localhost:44375/xxx.sum?a={a}&b={b}");

                var responseString = await response.Content.ReadAsStringAsync();

                LabelResult.Text = responseString;
            }
            catch (Exception error)
            {
                LabelResult.Text = error.Message;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void ButtonEquals_Click(object sender, EventArgs e)
        {
            await SendRequest();
        }
    }
}