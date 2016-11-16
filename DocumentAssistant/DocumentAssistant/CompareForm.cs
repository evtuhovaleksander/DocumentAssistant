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
            for (int i = start ; i <= stop ; i++)
            {
                Compare_Element el = Compare_Element.get_el_as_xls_el_for_cmp(mcl, i).CloneElement();
                string serial2 = el.Serial2;
                int index = mas.Serial2_base.IndexOf(serial2);
                if (index != -1)
                {
                    Compare_Pare pr = mas.pre_mas[index].CloneComparePare();
                    pr.xls_el = el.CloneElement();
                    pr.check_equalence();
                    mas.dual_mas.Add(pr.CloneComparePare());



                    del_index.Add(index);
                }
                else
                {
                    Compare_Pare pr =new Compare_Pare();
                    pr.xls_el = el.CloneElement();
                    pr.check_equalence();
                    mas.xls_only_mas.Add(pr.CloneComparePare());
                }
            }
            for (int i = 0; i < mas.pre_mas.Count; i++)
            {
                if (!del_index.Contains(i))
                {
                    mas.pre_mas[i].check_equalence();
                    mas.base_only_mas.Add(mas.pre_mas[i]);
                }
            }

            mas.all_mas=new List<Compare_Pare>();
            mas.all_mas.AddRange(mas.dual_mas);
            mas.all_mas.AddRange(mas.xls_only_mas);
            mas.all_mas.AddRange(mas.base_only_mas);


            
            
            fill_dgv_with_list(mas.dual_mas,false,base_and_xls_dgv);
            fill_dgv_with_list(mas.xls_only_mas, true, xls_only_dgv);
            fill_dgv_with_list(mas.base_only_mas, false, base_only_dgv);
        }

        public void fill_dgv_with_list(List<Compare_Pare> ms, bool xls, DataGridView dgv)
        {
            dgv.RowCount = ms.Count;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (xls)
                {
                    dgv.Rows[i].Cells[0].Value = ms[i].xls_el.Serial2;
                }
                else
                {
                    dgv.Rows[i].Cells[0].Value = ms[i].base_el.Serial2;
                }

                if (ms[i].full_pair)
                {
                    if (ms[i].equal)
                    {
                        dgv.Rows[i].Cells[0].Style.BackColor=Color.Green;
                    }
                    else
                    {
                        dgv.Rows[i].Cells[0].Style.BackColor = Color.OrangeRed;
                    }
                }

            }
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

        private void base_and_xls_dgv_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void base_and_xls_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Compare_Pare pr = mas.dual_mas[e.RowIndex];

                new ComparePareForm(pr).Show();
            }
        }

        private void base_only_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                new ComparePareForm(mas.base_only_mas[e.RowIndex]).Show();
            }
        }

        private void xls_only_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                new ComparePareForm(mas.xls_only_mas[e.RowIndex]).Show();
            }
        }
    }
}
