using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form2 : Form
    {
        HashSet<string> hashset1;
        HashSet<string> hashset2;
        private Form3 form3;
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            hashset1 = new HashSet<string>();
            hashset2 = new HashSet<string>();
            this.form1 = form1;
            form3 = new Form3(this);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_input.Text))
            {
                lbl_hashset_error_list.Text = "input  should not be empty ";
            }
            hashset1.Add(txt_input.Text);
            txt_input.Clear();
        }

        private void btn_hs1_remove_Click(object sender, EventArgs e)
        {
            if(hashset1.Count == 0 )
            {
                lbl_hashset_error_list.Text = "has1 is empty";
            
            }

            hashset1.Remove(txt_input.Text);
            txt_input.Clear();
        }

        private void btn_hs2_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_input.Text))
            {
                lbl_hashset_error_list.Text = "input  should not be empty ";
            }

            hashset2.Add(txt_input.Text);
            txt_input.Clear();

        }

        private void btn_hs2_remove_Click(object sender, EventArgs e)
        {
            if (hashset2.Count == 0)
            {
                lbl_hashset_error_list.Text = " has2 is empty";

            }
            hashset2.Remove(txt_input.Text);
            txt_input.Clear();

        }

        private void btn_disolay_Click(object sender, EventArgs e)
        {
            hs1.Items.Clear();
            hs2.Items.Clear();
            foreach (string s in hashset1)
            {
                hs1.Items.Add(s);
            }
            foreach (string s in hashset2)
            {
                hs2.Items.Add(s);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            hashset1.Clear();
            hashset2.Clear();
            hs1.Items.Clear();
            hs2.Items.Clear();
            txt_input.Clear();
            lbl_result.Text = "";
            lbl_hashset_error_list.Text = "";
            
        }



        private void btn_inresection_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            if (hashset1.Count == 0 || hashset2.Count == 0)
            {
                lbl_hashset_error_list.Text = "has1 or has2 or both of them are empty";
            }
            else
            {
                hashset1.IntersectWith(hashset2);
                lbl_result.Text = string.Join(", ", hashset1);
                txt_input.Clear();
            }
        }
        private void btn_union_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";

            if (hashset1.Count == 0 || hashset2.Count == 0)
            {
                lbl_hashset_error_list.Text = "has1 or has2 or both of them are empty";
            }
            else
            {
                //showing the result on the label 
                hashset2.UnionWith(hashset1);
                lbl_result.Text = string.Join(", ", hashset2);
            }
            txt_input.Clear();
        }

        private void btn_form1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1.Show();
        }

        private void btn_subset_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            if (hashset1.Count == 0 || hashset2.Count == 0)
            {
                lbl_hashset_error_list.Text = "has1 or has2 or both of them are empty";
            }

            lbl_result.Text = hashset1.IsSubsetOf(hashset2).ToString();
            txt_input.Clear();
        }

        private void btn_superset_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            if (hashset1.Count == 0 || hashset2.Count == 0)
            {
                lbl_hashset_error_list.Text = "has1 or has2 or both of them are empty";
            }

            lbl_result.Text = hashset1.IsSupersetOf(hashset2).ToString();
            txt_input.Clear();
        }

        private void btn_f2tof3_Click(object sender, EventArgs e)
        {
            form3.Show();
            this.Hide();
        }
    }
}
