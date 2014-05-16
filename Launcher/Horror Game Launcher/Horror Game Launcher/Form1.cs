using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;
using System.Net;
using System.IO.Compression;
using System.Threading;

namespace Horror_Game_Launcher
{
    public partial class Form1 : Form
    {
        string currUpdate = "0";
        string path_name = @Directory.GetCurrentDirectory();
        string instal_dir = null;

        string width;
        string height;
        bool fullScreen;

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(path_name + "/config.xml"))
            {
                loadXMLFile();
            }
            else
                setupXMLFile();
        }

        private void setupXMLFile()
        {
            GameOptions go = new GameOptions();
            go.Width = 1920;
            go.Height = 1080;
            go.FullScreen = true;
            go.Version = 0;
            XMLSave.SaveData(go, path_name + "/config.xml");

            loadXMLFile();
        }
        private void loadXMLFile()
        {
            GameOptions go = new GameOptions();
            XMLLoad<GameOptions> loadGameOptions = new XMLLoad<GameOptions>();

            go = loadGameOptions.LoadData(path_name + "/config.xml");
            width = go.Width.ToString();
            height = go.Height.ToString();
            gameVersion.Text = go.Version.ToString();
            currUpdate = go.Version.ToString();
            fullScreen = go.FullScreen;

            widthBox.Text = width;
            heightBox.Text = height;
            

        }

        private void play_Click(object sender, EventArgs e)
        {
            Process game = new Process();
            game.StartInfo.FileName = "Horror Game.exe";
            game.StartInfo.WorkingDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path_name);
            game.Start();
            
        }

        private void update_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("http://horrorgame.net16.net/buildversion.txt");
            StreamReader sr = new StreamReader(stream);

            string content = sr.ReadToEnd();

            if (int.Parse(content) > int.Parse(currUpdate))
            {
                currUpdate = content;
                DialogResult upd = MessageBox.Show("Update Found! Would you like to update?", "Update Found", MessageBoxButtons.YesNo);
                if (upd == DialogResult.Yes)
                {
                    string updurl = "www.horrorgame.net16.net/builds/";
                    
                    string filename = "horrorgame-" + content + ".zip";
                    instal_dir = filename;

                    currUpdate = content;

                    Uri aurl = new Uri("http://www.horrorgame.net16.net/builds/" + filename);

                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(dlcompleted);

                    client.DownloadFileAsync(aurl, @filename);
                    if (File.Exists(path_name + "/Horror Game.exe"))
                    {
                        File.Delete(path_name + "/Horror Game.exe");
                        //System.IO.Directory.Delete(path_name + "/Horror Game_Data/");
                       // Directory.Delete(path_name + "/Horror Game_Data/");
                    }
                    if (Directory.Exists(path_name + "/Horror Game_Data/"))
                    {
                        //System.IO.Directory.Delete(path_name + "/Horror Game_Data/");
                        Directory.Delete(path_name + "/Horror Game_Data/", true);
                    }
                   
                }
            }
            else
            {
                DialogResult noupd = MessageBox.Show("Game is Up To Date!", "No Updates Found", MessageBoxButtons.OK);
            }
        }

        private void dlcompleted(object sender, AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory(path_name + "/" + instal_dir, path_name);

            GameOptions gv = new GameOptions();
            gv.Version = int.Parse(currUpdate);
            XMLSave.SaveData(gv, path_name + "/config.xml");
            MessageBox.Show("Download Completed");
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            dlbar.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameVersion_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            GameOptions go = new GameOptions();
            go.Width = 1920;
            go.Height = 1080;
            XMLSave.SaveData(go, path_name + "/config.xml");
        }

        private void dlbar_Click(object sender, EventArgs e)
        {

        }
    }

    public class GameVersion
    {
        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }

    public class GameOptions
    {
        private int width;
        private int height;
        private bool fullScreen;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool FullScreen
        {
            get { return fullScreen; }
            set { fullScreen = value; }
        }

        private int version;

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}
