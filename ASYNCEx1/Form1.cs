using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ASYNCEx1
{
    public partial class Form1 : Form
    {
        private String url = "https://google.com/";
        delegate void SetTextCallback(string text);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string dnlad = client.DownloadString(url);
            SetText(dnlad);
            //text.Text = "";
            //text.Text = dnlad;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.BeginGetResponse(new AsyncCallback(Callback), request);
        }

        private void Callback(IAsyncResult iar)
        {
            HttpWebRequest request = iar.AsyncState as HttpWebRequest;
            HttpWebResponse response = request.EndGetResponse(iar) as HttpWebResponse;
            response.Close();
            SetText(response.StatusDescription.ToString());
        }

        private void SetText(string txt)
        {
            if (this.text.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { txt });
            }
            else
            {
                text.Text = "";
                text.Text = txt;
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string result = await client.DownloadStringTaskAsync(url);
            SetText(result);
        }
    }
}
