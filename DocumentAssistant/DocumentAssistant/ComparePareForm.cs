﻿using System;
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
    public partial class ComparePareForm : Form
    {
        public ComparePareForm(Compare_Pare pr)
        {
            InitializeComponent();


            if (pr.base_el != null && pr.xls_el != null)
            {
                fill(t1, t11, pr.base_el.Serial, pr.xls_el.Serial);
                fill(t2, t22, pr.base_el.Serial2, pr.xls_el.Serial2);

                fill(t3, t33, pr.base_el.Markid, pr.xls_el.Markid, pr.base_el.Mark, pr.xls_el.Mark);
                fill(t4, t44, pr.base_el.Typeid, pr.xls_el.Typeid, pr.base_el.Type, pr.xls_el.Type);
                fill(t5, t55, pr.base_el.Placeid, pr.xls_el.Placeid, pr.base_el.Place, pr.xls_el.Place);
                fill(t6, t66, pr.base_el.Statusid, pr.xls_el.Statusid, pr.base_el.Status, pr.xls_el.Status);

                fill(t7,pr.base_el.Text);
                fill(t8, pr.base_el.Text2);
                fill(t9, pr.base_el.Text3);
                fill(t10, pr.base_el.Text4);
                fill(t111, pr.base_el.Text5);
                
            }
            else
            {
                if (pr.base_el != null)
                {
                    fill(t1, pr.base_el.Serial);
                    fill(t2, pr.base_el.Serial2);

                    fill(t3, pr.base_el.Mark);
                    fill(t4, pr.base_el.Type);
                    fill(t5, pr.base_el.Place);
                    fill(t6, pr.base_el.Text);
                    



                    fill(t7, pr.base_el.Text);
                    fill(t8, pr.base_el.Text2);
                    fill(t9, pr.base_el.Text3);
                    fill(t10, pr.base_el.Text4);
                    fill(t111, pr.base_el.Text5);
                }
                else
                {
                    fill(1,t11, pr.xls_el.Serial);
                    fill(1,t22, pr.xls_el.Serial2);

                    fill(1,t33, pr.xls_el.Mark);
                    fill(1,t44, pr.xls_el.Type);
                    fill(1,t55, pr.xls_el.Place);
                    
                }
            }

      
        }

        private void ComparePareForm_Load(object sender, EventArgs e)
        {

        }

        public void fill(TextBox a, TextBox b,string aa,string bb)
        {
            if (aa != bb)
            {
                a.BackColor=Color.Red;
                b.BackColor = Color.Red;
            }
            else
            {
                a.BackColor = Color.GreenYellow;
                b.BackColor = Color.GreenYellow;
            }
            a.Text = aa;
            b.Text = bb;
        }

        public void fill(TextBox a, TextBox b,int aaa,int bbb, string aa, string bb)
        {
            if (aaa != bbb)
            {
                a.BackColor = Color.Red;
                b.BackColor = Color.Red;
            }
            else
            {
                a.BackColor = Color.GreenYellow;
                b.BackColor = Color.GreenYellow;
            }
            a.Text = aa;
            b.Text = bb;
        }
        public void fill(TextBox a, string aa)
        {
            a.Text = aa;
        }
        public void fill(int i,TextBox b, string aa)
        {
            b.Text = aa;
        }
    }
}