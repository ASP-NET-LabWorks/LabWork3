using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.UI;

namespace Server
{
    public partial class Sum : Page
    {
        private static readonly HttpClient client = new HttpClient();

        private async System.Threading.Tasks.Task SendRequest()
        {
            try
            {
                var values = new Dictionary<string, string>
                {
                    ["x"] = TextBoxX.Text,
                    ["y"] = TextBoxY.Text
                };

                using (var content = new FormUrlEncodedContent(values))
                {

                    HttpResponseMessage response;

                    response = await client.PostAsync("http://localhost/LabWork3/xxx.sum", content);

                    var responseString = await response.Content.ReadAsStringAsync();

                    LabelResult.Text = responseString;
                }
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