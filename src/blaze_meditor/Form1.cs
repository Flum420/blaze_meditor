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

namespace blaze_meditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Clear();
            con.AppendText("Blaze Map Editor Console - 0.1\n");
            con.AppendText("------------------------------\n");
            con.AppendText(DateTime.UtcNow + " - [INIT] application init\n");
            con.AppendText(DateTime.UtcNow + " - [IO] Loading last project: C:/Blaze/Maps/map01.xml\n");
            con.AppendText(DateTime.UtcNow + " - [MAP] Loading entity list data from map source: C:/Blaze/Maps/entlist.xml\n");
            //
            // Load textures from <MapEditorPath>/textures
            //
            DirectoryInfo texturePath = new DirectoryInfo(@"C:\TextureTest\");
            foreach (FileInfo file in texturePath.GetFiles())
            {
                try
                {
                    this.imageList1.Images.Add(Image.FromFile(file.FullName));
                    con.AppendText(DateTime.UtcNow + " - [IO] found texture file (" + file.Name + ") in texture folder, adding to texturelist\n");
                }
                catch
                {
                    MessageBox.Show("One or more files in given texture directory is not an image file!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            con.AppendText(DateTime.UtcNow + " - [IO] " + imageList1.Images.Count + " textures were successfully added to texture list.\n");
            //
            // Set icon size once loaded in listview
            // also assign our imagelist to the listview
            //
            this.imageList1.ImageSize = new Size(48, 48);
            this.listView1.LargeImageList = this.imageList1;

            for (int j = 0; j < this.imageList1.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.listView1.Items.Add(item);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blaze Map Editor" + Environment.NewLine + "Copyright © 2017 - All Rights Reserved."  + Environment.NewLine + "http://www.flum420.com", "About BME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
