
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics.Contracts;

namespace Test
{
    public partial class Form1 : Form
    {
        public string url = "https://api-ottcore.iguidevietnam.com/delivery-api/ThirdPartyProviderConfig";
        public string accessToken = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFwcGRhYm9uZyIsIm5hbWVpZCI6IjEiLCJUZW5hbnRJZCI6IjEiLCJuYmYiOjE2ODk3MzM5ODYsImV4cCI6MTY5ODM3Mzk4NiwiaWF0IjoxNjg5NzMzOTg2fQ.0ut1LqCYm5osnk4HMYQKvIsdUZgkw8bcEIAebYG7dgI";
        public Form1()
        {
            InitializeComponent();
        }
        public bool cdn_bool = false;
        public bool transcode_bool = false;
        public int cdn;
        public int transcode;
        public int id;
        private async void button1_Click(object sender, EventArgs e)
        {

            cdn = 1;
            if (NoCDN.Checked)
            {
                cdn = 0;

            }else if (CDN_CNetwork.Checked)
            {
                cdn = 1;
            }
            else if (CDN_CVG.Checked)
            {
                cdn = 2;
            }

            transcode = 0;
            if (Digicom.Checked)
            {
                transcode = 1;
            }else if (FFMpeg.Checked)
            {
                transcode = 0;
            }else if (Ateme.Checked)
            {
                transcode = 2;
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
                HttpResponseMessage response = await client.GetAsync($"{url}/{id}");
                var responseContent = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(responseContent);
                var configExtension = json["configExtension"].ToString();
                if (!String.IsNullOrEmpty(configExtension))
                {
                    var configObject = JObject.Parse(configExtension);
                    configObject["Cdn"] = $"{cdn}";
                    configObject["Transcode"] = $"{transcode}";
                    json["configExtension"] = configObject.ToString();
                    StringContent content = new StringContent(json.ToString(), Encoding.UTF8, "application/json");
                    HttpResponseMessage newResponse = await client.PutAsync(url, content);
                    var finalResponseContent = await newResponse.Content.ReadAsStringAsync();
                    MessageBox.Show(finalResponseContent);
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                id = Int32.Parse(textBox1.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}