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
    public partial class MesajBox : Form
    {
        public string ipjuan;
        public MesajBox(string ipport)
        {
            InitializeComponent();
            ipjuan = ipport;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Error")
            {
                MessageBox.Show(textBox2.Text, textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Bilgi")
            {
                MessageBox.Show(textBox2.Text, textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "Ünlem")
            {
                MessageBox.Show(textBox2.Text, textBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Server.server.Send(ipjuan, "messagebox:" + textBox1.Text.Replace(":", "-") + ":" + textBox2.Text.Replace(":", "-") + ":" + comboBox1.GetItemText(comboBox1.SelectedItem));
        }
    }
}
