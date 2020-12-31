using Banana.Klaslar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banana
{
    public partial class DosyaCalistir : Form
    {
        public string ipport;
        public DosyaCalistir(string ipjuan)
        {
            InitializeComponent();
            ipport = ipjuan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Server.server.Send(ipport, "dosya " + textBox1.Text + " " + "true");
            }
            else
            {
                Server.server.Send(ipport, "dosya " + textBox1.Text + " " + "false");
            }
        }
    }
}
