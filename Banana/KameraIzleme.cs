using Banana.Klaslar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatsonTcp;

namespace Banana
{
    public partial class KameraIzleme : Form
    {
        public string ipport;
        public KameraIzleme(string ipjuan)
        {
            InitializeComponent();
            ipport = ipjuan;
            Server.server.Events.MessageReceived += mesajgeldi;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void baslatbuton_Click(object sender, EventArgs e)
        {
            if (baslatbuton.Text == "Başlat")
            {
                baslatbuton.Text = "Durdur";
                gonderici.Start();
            }
            else
            {
                baslatbuton.Text = "Başlat";
                gonderici.Stop();
            }
        }

        public void mesajgeldi(object sender, MessageReceivedEventArgs args)
        {
            Image image;

            using (MemoryStream ms = new MemoryStream(args.Data))
            {
                image = Image.FromStream(ms);
            }

            pictureBox1.Image = image;
        }

        private void gonderici_Tick(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "kamera");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gonderici.Interval = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
