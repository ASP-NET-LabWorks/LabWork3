using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task SendRequest()
        {
            try
            {
                var values = new Dictionary<string, string>
                {
                    ["x"] = numericUpDownX.Value.ToString(),
                    ["y"] = numericUpDownY.Value.ToString()
                };

                using (var content = new FormUrlEncodedContent(values))
                {

                    HttpResponseMessage response;

                    response = await client.PostAsync("http://localhost/LabWork3/xxx.sum", content);

                    var responseString = await response.Content.ReadAsStringAsync();

                    labelResult.Text = responseString;
                }
            }
            catch (Exception error)
            {
                labelResult.Text = error.Message;
            }
        }

        private async void ButtonEquals_Click(object sender, EventArgs e)
        {
            await SendRequest();
        }
    }
}
