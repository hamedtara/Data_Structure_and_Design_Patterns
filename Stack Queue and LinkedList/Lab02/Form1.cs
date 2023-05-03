using Lab02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignemnt02
{
    public partial class Form1 : Form
    {
        //Hamed Tara - n01540404

        Stack<Course> courseStack = new Stack<Course>();
        Queue<Course> courseQueue = new Queue<Course>();  

        public Form1()
        {
            InitializeComponent();
        }

        //stack

        private void btn_push_Click(object sender, EventArgs e)
        //Push only works when the input textbox(es) has some value
        {
            if (!string.IsNullOrWhiteSpace(txt_stack.Text) && !string.IsNullOrWhiteSpace(txt_stackscoure.Text))
            {
                Course c = new Course(txt_stack.Text, txt_stackscoure.Text);
                courseStack.Push(c);
            }
            else if(!string.IsNullOrWhiteSpace(txt_stack.Text))
            {
                lbl_stackError.Text = "Course Name Is Empty";
            }

            else if (!string.IsNullOrWhiteSpace(txt_stackscoure.Text)){
                lbl_stackError.Text = "Course Scoure Is Empty";
            }
            else
            {
                lbl_stackError.Text = "Course Name And Scoure Are Empty";
            }
            
        }

        private void btn_pop_Click(object sender, EventArgs e)
            //Pop only works when stack is not empty
            //Pop starts throwing error once you end up removing all the items from the Stack

        {
            if (courseStack.Count > 0)
            {
                courseStack.Pop();
                lbx_stack.Items.Clear();
                foreach (Course c in courseStack)
                {
                    lbx_stack.Items.Add(c.CourseName + " _ " + c.Score);
                }
            }
            else
            {
                lbl_stackError.Text = "The stack is empty.";
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            //Display only works when stack is not empty, otherwise throws error
            if (courseStack.Count > 0) { 
            lbx_stack.Items.Clear();
            foreach (Course c in courseStack)
            {
                lbx_stack.Items.Add(c.CourseName + " _ " + c.Score);
            }
            }

            else
            {
                lbl_stackError.Text = "The stack is empty.";
            }
        }

        //Implement Peek functionality 
        // Create a new button
        //Peek only works when stack is not empty otherwise throws error
        //Add all the input-output validations possible

        private void btn_peek_Click(object sender, EventArgs e)
        {
            
            if (courseStack.Count > 0)
            {
               
                Course c = courseStack.Peek();
                lbx_stack.Items.Clear();
                lbx_stack.Items.Add(c.CourseName + " _ " + c.Score);

            }
            else
            {
                lbl_stackError.Text = "The stack is empty.";
            }
        }


        //Queue implementation 

        private void btn_enqueue_Click(object sender, EventArgs e)
        // Enqueue only works when the input textbox(es) has some value
        {
            if (!string.IsNullOrWhiteSpace(txt_queue.Text) && !string.IsNullOrWhiteSpace(txt_queuescore.Text))
            {
                Course c = new Course(txt_queue.Text, txt_queuescore.Text);
                courseQueue.Enqueue(c);
            }
            else if (!string.IsNullOrWhiteSpace(txt_queue.Text))
            {
                lbl_queueErrors.Text = "Course Name Is Empty";
            }
            else if (!string.IsNullOrWhiteSpace(txt_queuescore.Text))
            {
                lbl_queueErrors.Text = "Course Score Is Empty";
            }

            else
            {
                lbl_queueErrors.Text = "Course Name And Scoure Are Empty";
            }
        }

        //Dequeue only works when queue is not empty
        private void btn_dequeue_Click(object sender, EventArgs e)
        {
            if (courseQueue.Count > 0)
            {
                courseQueue.Dequeue();
                lbx_queue.Items.Clear();
                foreach (Course c in courseQueue)
                {
                    lbx_queue.Items.Add(c.CourseName + " _ " + c.Score);
                }
            }
            else
            {
               lbl_queueErrors.Text = "The Queue is empty.";
            }
        }

        private void btn_displayqueue_Click(object sender, EventArgs e)
        //Display only works when queue is not empty, otherwise throws error
        {
            if (courseQueue.Count > 0)
            {
                lbx_queue.Items.Clear();
                foreach (Course c in courseQueue)
                {
                    lbx_queue.Items.Add(c.CourseName + " _ " + c.Score);
                }
            }
            else
            {
                lbl_queueErrors.Text = "The Queue Is Empty";
            }
        }

        //Implement Peek functionality (1 Point)
        //Create a new button
        //Peek only works when queue is not empty otherwise throws error
        //Add all the input-output validations possible

        private void btn_QueuePeek_Click(object sender, EventArgs e)
        {
            if (courseQueue.Count > 0)
            {
                Course c = courseQueue.Peek();
                lbx_queue.Items.Clear();
                lbx_queue.Items.Add(c.CourseName + " _ " + c.Score);

            }
            else
            {
                lbl_queueErrors.Text = "The stack is empty.";
            }

        }

        private void txt_stack_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private bool form2Created = false;
        private Form2 form2;

        private void btn_form1toform2_Click(object sender, EventArgs e)
        {
            if (!form2Created)
            {
                form2 = new Form2();
                form2Created = true;
                form2.Show();
            }
            else
            {
                form2.Show();
                form2.BringToFront();
            }
        }

    }
}
