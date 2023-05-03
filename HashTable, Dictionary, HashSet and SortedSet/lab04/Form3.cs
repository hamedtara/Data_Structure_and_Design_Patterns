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
    public partial class Form3 : Form
    {
        private SortedSet<Course> courses1;
        private SortedSet<Course> courses2;

        private Form2 form2;
        public Form3(Form2 form2)
        {
            InitializeComponent();
            courses1= new SortedSet<Course>();
            courses2= new SortedSet<Course>();
            this.form2 = form2;
        }

        private void btn_f3tof2_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void btn_Add_sortedset1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_sortedset_input_.Text))
            {
                Course addNewCourse = new Course(txt_sortedset_input_.Text);
                courses1.Add(addNewCourse);
                lbx_sortedset1.Items.Add(addNewCourse.ToString());
                txt_sortedset_input_.Text = "";
            }
            else
            {
                lbl_sortedset_error_list.Text = "Please enter a course ";
            }
        }

        private void btn_remove_sortedset1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_sortedset_input_.Text))
            {
                Course addNewCourse = new Course(txt_sortedset_input_.Text);
                courses1.Remove(addNewCourse);
                lbx_sortedset1.Items.Remove(addNewCourse.ToString());
                txt_sortedset_input_.Text = " ";

            }
            else
            {
                lbl_sortedset_error_list.Text = " please enter a course";
            }
        }

        private void btn_Add_sortedset2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_sortedset_input_.Text))
            {
                Course addNewCourse = new Course(txt_sortedset_input_.Text);
                courses2.Add(addNewCourse);
                txt_sortedset_input_.Text = " ";
            }
            else
            {
                lbl_sortedset_error_list.Text = "Please enter a course name";
            }

        }

        private void btn_remove_sortedset2_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_sortedset_input_.Text))
            {
                Course addNewCourse = new Course(txt_sortedset_input_.Text);
                courses2.Remove(addNewCourse);
                lbx_sortedset2.Items.Remove(addNewCourse.ToString());
                txt_sortedset_input_.Text = "";
            }
            else
            {
                lbl_sortedset_error_list.Text = "Please enter a course name";
            }

        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            lbx_sortedset1.Items.Clear();
            lbx_sortedset2.Items.Clear();

            foreach (Course course in courses1)
            {
                lbx_sortedset1.Items.Add(course.ToString());
            }

            foreach (Course course in courses2)
            {
                lbx_sortedset2.Items.Add(course.ToString());
            }
        }

        private void btn_inresection_Click(object sender, EventArgs e)
        {
            courses1.IntersectWith(courses2);

            string intersectionString = string.Join(", ", courses1.Select(c => c.ToString()));
            lbl_result.Text =  intersectionString;
        }

        private void btn_subset_Click(object sender, EventArgs e)
        {

             lbl_result.Text = "";
            if(courses1.Count == 0 || courses2.Count == 0) {
                lbl_sortedset_error_list.Text = "sortedset1 or sortedset2 or both of them are empty";
            }
            else
            {
                bool isSubset = courses1.IsSubsetOf(courses2);
                lbl_result.Text = isSubset.ToString();
            }

        }

        private void btn_superset_Click(object sender, EventArgs e)
        {
            lbl_result.Text = "";
            if (courses1.Count == 0 || courses2.Count == 0)
            {
                lbl_sortedset_error_list.Text = "sortedset1 or sortedset2 or both of them are empty";
            }
            else
            {
                bool isSuperset = courses1.IsSupersetOf(courses2);
                lbl_result.Text = isSuperset.ToString();
            }
        }

        private void btn_union_Click(object sender, EventArgs e)
        {
            if (courses1.Count == 0 || courses2.Count == 0)
            {
                lbl_sortedset_error_list.Text = "sortedset1 or sortedset2 or both of them are empty";
            }
            else
            {

                courses1.UnionWith(courses2);

                string unionString = string.Join(", ", courses1.Select(c => c.ToString()));
                lbl_result.Text = "Union : " + unionString;
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            courses1.Clear();
            courses2.Clear();
            lbx_sortedset1.Items.Clear();
            lbx_sortedset2.Items.Clear();
            lbl_result.Text = "";
        }
    }
}
