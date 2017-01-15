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
using WIA;

namespace DocumentAssistant
{
    public partial class GetDocument : Form
    {
        

        public GetDocument(int id)
        {
            InitializeComponent();
            Item_ID = id;
            
        }
        public int Item_ID;
        private void button1_Click(object sender, EventArgs e)
        {
            const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
            WIA.CommonDialog wiaDiag = new WIA.CommonDialog();
            WIA.ImageFile wiaImage = null;
            wiaImage = wiaDiag.ShowAcquireImage(WiaDeviceType.UnspecifiedDeviceType, WiaImageIntent.GrayscaleIntent,
                WiaImageBias.MaximizeQuality, wiaFormatJPEG, true, true, false);
            WIA.Vector vector = wiaImage.FileData;
            Image i = Image.FromStream(new MemoryStream((byte[]) vector.get_BinaryData()));
            pictureBox.Image = i;
        }

        private void Path_GetFile_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                path = ofd.FileName;
                Path_Path_Tbox.Text = path;
                Path_Name_Tbox.Text = Path.GetFileName(path);
                Path_Save_But.Enabled = true;
            }
        }

        private void Path_Save_But_Click(object sender, EventArgs e)
        {
            if(DocumentDirectory.add_document(Item_ID, Path_Path_Tbox.Text)) Close();
        }

        private void GetPath_Rbut_CheckedChanged(object sender, EventArgs e)
        {
            if (GetPath_Rbut.Checked)
            {
                Path_grBox.Enabled = true;
                scan_grBox.Enabled = false;
            }
            else
            {
                Path_grBox.Enabled = false;
                scan_grBox.Enabled = true;
            }
        }

        private void scan_save_but_Click(object sender, EventArgs e)
        {
           if( DocumentDirectory.add_document(Item_ID,pictureBox.Image))Close();
        }
    }
}
