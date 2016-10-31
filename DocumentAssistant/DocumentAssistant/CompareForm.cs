using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentAssistant
{
    public partial class CompareForm : Form
    {
        Compare_Pare_Mas mas;
        XLS_Class mcl;
        public CompareForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(start_Tbox.Text);
            int stop = Convert.ToInt32(stop_Tbox.Text);
            List<int> del_index=new List<int>();
            for (int i = start - 1; i < stop - 1; i++)
            {
                Compare_Element el = Compare_Element.get_el_as_xls_el(mcl, i);
                string serial2 = el.Serial2;
                int index = mas.Serial2_base.IndexOf(serial2);
                if (index != -1)
                {
                    Compare_Pare pr = mas.pre_mas[index];
                    pr.xls_el = el;
                    mas.dual_mas.Add(pr);
                    mas.pre_mas[index].base_el = null;
                    mas.pre_mas[index].base_el = null;
                    del_index.Add(index);
                }
                else
                {
                    Compare_Pare pr =new Compare_Pare();
                    pr.xls_el = el;
                    mas.xls_only_mas.Add(pr);
                }
            }
            for (int i = 0; i < mas.pre_mas.Count; i++)
            {
                if (!del_index.Contains(i))
                {
                    mas.base_only_mas.Add(mas.pre_mas[i]);
                }
            }

            mas.all_mas=new List<Compare_Pare>();
            mas.all_mas.AddRange(mas.dual_mas);
            mas.all_mas.AddRange(mas.xls_only_mas);
            mas.all_mas.AddRange(mas.base_only_mas);
        }

        private void CompareForm_Load(object sender, EventArgs e)
        {
            mas = Compare_Pare_Mas.get_base_elements();
        }

        private void get_File_Click(object sender, EventArgs e)
        {
            XLS_Class cl = XLS_Class.get_xls();
            if (cl != null)
            {
                get_File.BackColor = Color.Green;
                mcl = cl;
            }
        }
    }
}
