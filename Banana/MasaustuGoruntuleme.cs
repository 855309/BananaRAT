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
    public partial class MasaustuGoruntuleme : Form
    {
        public bool gonder;
        public string ipport;
        public MasaustuGoruntuleme(string ipjuan)
        {
            InitializeComponent();
            ipport = ipjuan;
            Control.CheckForIllegalCrossThreadCalls = false;
            Server.server.Events.MessageReceived += mesajgeldi;
        }

        private void baslatbuton_Click(object sender, EventArgs e)
        {
            if (baslatbuton.Text == "Başlat")
            {
                baslatbuton.Text = "Durdur";
                baslat();
            }
            else
            {
                baslatbuton.Text = "Başlat";
                durdur();
            }
        }

        public void baslat()
        {
            gonder = true;
            gonderici.Start();
        }

        public void durdur()
        {
            gonder = false;
            gonderici.Stop();
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

        private void MasaustuGoruntuleme_Load(object sender, EventArgs e)
        {

        }

        private void gonderici_Tick(object sender, EventArgs e)
        {
            Server.server.Send(ipport, "masaustugonder" + ":" + textBox1.Text + ":" + textBox2.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            gonderici.Interval = trackBar1.Value;
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
