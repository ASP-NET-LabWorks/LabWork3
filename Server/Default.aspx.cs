using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.UI;

namespace Server
{
    public partial class _Default : Page
    {
        private static readonly HttpClient client = new HttpClient();

        private async System.Threading.Tasks.Task SendRequest(string method)
        {
            try
            {
                var values = new Dictionary<string, string>
                {
                    ["a"] = TextBoxA.Text,
                    ["b"] = TextBoxB.Text
                };

                using (var content = new FormUrlEncodedContent(values))
                {
                    var uri = "http://localhost/LabWork3/xxx.azvm";

                    HttpResponseMessage response;

                    switch (method)
                    {
                        case "GET":
                            response = await client.GetAsync($"{uri}?a={values["a"]}&b={values["b"]}");
                            break;
                        case "POST":
                            response = await client.PostAsync(uri, content);
                            break;
                        case "PUT":
                            response = await client.PutAsync(uri, content);
                            break;
                        default:
                            response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Options, uri));
                            break;
                    }

                    if (!response.IsSuccessStatusCode)
                        throw new HttpRequestException($"Ошибка {response.StatusCode.GetHashCode()}: {response.StatusCode}");

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

        protected async void ButtonGet_Click(object sender, EventArgs e)
        {
            await SendRequest("GET");
        }

        protected async void ButtonPost_Click(object sender, EventArgs e)
        {
            await SendRequest("POST");
        }

        protected async void ButtonPut_Click(object sender, EventArgs e)
        {
            await SendRequest("PUT");
        }

        protected async void Button404_Click(object sender, EventArgs e)
        {
            await SendRequest("OPTIONS");
        }
    }
}