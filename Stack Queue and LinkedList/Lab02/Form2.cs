using Assignemnt02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form2 : Form
    {
        private LinkedList<Course> my_list;
        public Form2()
        {
            InitializeComponent();
            my_list = new LinkedList<Course>();
        }

        private void btn_addlast2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_coursesLL2.Text) && !string.IsNullOrWhiteSpace(txt_scoreLL2.Text)){
                Course c1 = new Course(txt_coursesLL2.Text, txt_scoreLL2.Text);
                my_list.AddLast(c1);
            }

            else if (!string.IsNullOrWhiteSpace(txt_coursesLL2.Text)){
                lbl_linklistError.Text = "<<< The course text box is empty";
            }

            else if (!string.IsNullOrWhiteSpace(txt_scoreLL2.Text))
            {
                lbl_linklistError.Text = "The scoure text box is empty >>>";
            }
            else
            {
                lbl_linklistError.Text = "<<< Both Boxes Are Empty >>>";
            }
        }


        private void btn_addFirst_Click(object sender, EventArgs e)

        //only works when the input textbox(es) has some value
        {
            if (!string.IsNullOrWhiteSpace(txt_coursesLL2.Text) && !string.IsNullOrWhiteSpace(txt_scoreLL2.Text))
            {
                Course c1 = new Course(txt_coursesLL2.Text, txt_scoreLL2.Text);
                my_list.AddFirst(c1);
            }

            else if (!string.IsNullOrWhiteSpace(txt_coursesLL2.Text))
            {
                lbl_linklistError.Text = "<<< The course text box is empty";
            }

            else if (!string.IsNullOrWhiteSpace(txt_scoreLL2.Text))
            {
                lbl_linklistError.Text = "The scoure text box is empty >>>";
            }
            else
            {
                lbl_linklistError.Text = "<<< Both Boxes Are Empty >>>";
            }
        }



        private void btn_remove2_Click(object sender, EventArgs e)
        {
            Course valueFound = null;
            foreach (Course c in my_list)
            {
                if (c.CourseName == txt_coursesLL2.Text && c.Score
                    == Int32.Parse(txt_scoreLL2.Text))
                {

                    valueFound = c;
                    break;
                }


            }

            if (valueFound != null)
            {
                my_list.Remove(valueFound);
            }


        }

        // Should find and display the object based on course name
        // Throw error if not found


        private void btn_find2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_coursesLL2.Text))
            {
                Course valueFound = null;
                foreach (Course c in my_list)
                {
                    if (c.CourseName == txt_coursesLL2.Text)
                    {
                        valueFound = c;
                        break;
                    }
                }

                if (valueFound != null)
                {
                    lbx_linklist2.Items.Clear();
                    lbx_linklist2.Items.Add(valueFound.CourseName + " : " + valueFound.Score);
                }
                else
                {
                    lbl_linklistError.Text = "The course name not found";
                }
            }
            else
            {
                lbl_linklistError.Text = "The course text box is empty";
            }
        }

        //only works when linkedlist is not empty otherwise throws error

        private void btn_display2_Click(object sender, EventArgs e)
        {
            
            if (my_list.Count > 0)
            {


                lbx_linklist2.Items.Clear();
                foreach (Course c in my_list)
                {
                    lbx_linklist2.Items.Add(c.CourseName + " " + c.Score);

                }
            }

            else
            {
                lbl_linklistError.Text = "The link list is empty";
            }
        }

        private void txt_coursesLL2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_scoreLL2_TextChanged(object sender, EventArgs e)
        {

        }
        private Form1 form1;
        private void btn_form2toform1_Click(object sender, EventArgs e)
        {
            if (form1 == null || form1.IsDisposed)
            {
                form1 = new Form1();
            }
            form1.Show();
            form1.BringToFront();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //Implement RemoveFirst and RemoveLast functionality 
        //Only works when the linkedlist is not empty
        private void btn_removeLast_Click(object sender, EventArgs e)
        {
            if(my_list.Count > 0)
            {
                my_list.RemoveLast();
            }

            else
            {
               lbl_linklistError.Text = "The linked list is already empty!";
            }

        }

        private void btn_removeFirst_Click(object sender, EventArgs e)
        {
            if (my_list.Count > 0)
            {
                my_list.RemoveFirst();
            }

            else
            {
                lbl_linklistError.Text = "The linked list is already empty!";
            }
        }
    }
}