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
using static System.Net.WebRequestMethods;

namespace SPT_Installer
{
    public partial class installerForm : Form
    {
        public installerForm()
        {
            InitializeComponent();
        }

        private void installerForm_Load(object sender, EventArgs e)
        {
            checkFolders.Start();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            onHover_premodded.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            onHover_premodded.Visible = false;
        }

        private void installer_regular_MouseEnter(object sender, EventArgs e)
        {
            onHover_regular.Visible = true;
        }

        private void installer_regular_MouseLeave(object sender, EventArgs e)
        {
            onHover_regular.Visible = false;
        }

        private void sptFind_Click(object sender, EventArgs e)
        {
            sptFind.BackColor = Color.DodgerBlue;
        }

        private void liveFind_Click(object sender, EventArgs e)
        {
            liveFind.BackColor = Color.DodgerBlue;
        }

        private void checkFolders_Tick(object sender, EventArgs e)
        {
            if (sptFind.BackColor == Color.DodgerBlue && liveFind.BackColor == Color.DodgerBlue)
            {
                installPanel.Visible = true;
            }
        }

        private void installerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            checkFolders.Stop();
        }

        private void installerForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void installerForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] folders = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string folderPath in folders)
            {
                if (folderPath.EndsWith(".zip") || folderPath.EndsWith("7.z"))
                {
                    MessageBox.Show("Please right click \"Open server mods\" and open the modlist before you try to add a mod!", this.Text, MessageBoxButtons.OK);
                }
                else
                {
                    string[] inFolders = Directory.GetDirectories(folderPath);
                    string[] files = Directory.GetFiles(folderPath);

                    foreach(string inFolder in inFolders)
                    {
                        liveList.Items.Add(Path.GetFileName(inFolder));
                    }
                    foreach (string file in files)
                    {
                        liveList.Items.Add(Path.GetFileName(file));
                    }
                }
            }
        }
    }
}
