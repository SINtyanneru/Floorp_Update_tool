using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using System.IO;
using System.IO.Compression;
using Microsoft.VisualBasic;
using System.Threading;

namespace Floorp_UpdateTool
{
    public partial class Main_Form : Form
    {
        string user = Environment.UserName; //ユーザー名

        public Main_Form()
        {
            InitializeComponent();

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            MessageBox.Show("ようこそ！\r\n※プロファイルの設定ファイルの文字コードが「UTF-8」以外だと日本語表記がおかしくなります");
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            log_label.Text += "[ OK ]起動しました\r\n";

            Console.WriteLine(user);    // ユーザー名
            log_label.Text += "[ DB ]ユーザー名:" + user + "\r\n";
            //プロファイル一覧を取得

            var profile_src_parser = new FileIniDataParser();
            var Profile = profile_src_parser.ReadFile(@"C:\Users\" + user + @"\AppData\Roaming\Mozilla\Firefox\profiles.ini");


            string profile_error = "n";
            int profile_cl = 0;

            while (profile_error == "n")
            {
                if (Profile["Profile" + profile_cl]["Name"] != null)
                {
                    string ProfileName = Profile["Profile" + profile_cl]["Name"];
                    string ProfileID = Profile["Profile" + profile_cl]["Path"];
                    Profile_listView.Items.Add("プロファイル" + profile_cl);
                    Profile_listView.Items[profile_cl].SubItems.Add(ProfileName);
                    Profile_listView.Items[profile_cl].SubItems.Add(ProfileID);

                    log_label.Text += "[ DB ]プロファイル名:" + ProfileName + "\r\n";
                    log_label.Text += "[ DB ]プロファイルID:" + ProfileID + "\r\n";

                    profile_cl++;
                }
                else
                {
                    profile_error = "y";
                }
            }
        }

        public void Start (object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new Action(this.Copy_Start));
                }
                else
                {
                    log_label.Text += "[ OK ]Invokeする必要がありません" + "\r\n";
                    Copy_Start();
                }

            }));
            thread.Start();
            MessageBox.Show("完了");
        }

        public void Copy_Start()
        {
            try
            {
                log_label.Text += "[ OK ]コピー開始" + "\r\n";
                Start_button.Enabled = false;

                foreach (ListViewItem itemx in Profile_listView.CheckedItems)
                {
                    //msg += itemx.SubItems[0].Text + itemx.SubItems[1].Text + itemx.SubItems[2].Text;
                    log_label.Text += "[ OK ]コピー元プロファイル" + itemx.SubItems[1].Text + "|" + itemx.SubItems[2].Text + "\r\n";

                    //プロファイルのディレクトリを作成
                    string path = @"C:\Users\" + user + @"\AppData\Roaming\Ablaze\Floorp\" + itemx.SubItems[2].Text;

                    Directory.CreateDirectory(path);
                    log_label.Text += "[ OK ]ディレクトリを作成:" + itemx.SubItems[2].Text + "\r\n";

                    //=======================[ コピー開始！！！！！！！ ]=======================

                    string sourceDirName = @"C:\Users\" + user + @"\AppData\Roaming\Mozilla\Firefox\" + itemx.SubItems[2].Text + "\\"; //コピー元のフォルダー
                    string destDirName = @"C:\Users\" + user + @"\AppData\Roaming\Ablaze\Floorp\" + itemx.SubItems[2].Text + "\\"; //コピー先のフォルダー

                    CopyDirectory(sourceDirName, destDirName);
                }
            }catch (Exception ex)
            {
                log_label.Text += "[ ERROR ]" + ex.Message + "\r\n";
            }
        }

        public static void CopyDirectory(string sourceDirName, string destDirName)
        {
            //コピー先のディレクトリがないときは作る
            if (!System.IO.Directory.Exists(destDirName))
            {
                System.IO.Directory.CreateDirectory(destDirName);
                //属性もコピー
                System.IO.File.SetAttributes(destDirName,
                    System.IO.File.GetAttributes(sourceDirName));
            }

            //コピー先のディレクトリ名の末尾に"\"をつける
            if (destDirName[destDirName.Length - 1] !=
                    System.IO.Path.DirectorySeparatorChar)
                destDirName = destDirName + System.IO.Path.DirectorySeparatorChar;

            //コピー元のディレクトリにあるファイルをコピー
            string[] files = System.IO.Directory.GetFiles(sourceDirName);
            foreach (string file in files)
                System.IO.File.Copy(file,
                    destDirName + System.IO.Path.GetFileName(file), true);

            //コピー元のディレクトリにあるディレクトリについて、再帰的に呼び出す
            string[] dirs = System.IO.Directory.GetDirectories(sourceDirName);
            foreach (string dir in dirs)
                CopyDirectory(dir, destDirName + System.IO.Path.GetFileName(dir));
        }
    }
}
