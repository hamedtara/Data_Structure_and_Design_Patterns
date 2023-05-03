namespace Assignemnt02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_stack = new System.Windows.Forms.Label();
            this.lbl_queue = new System.Windows.Forms.Label();
            this.txt_stack = new System.Windows.Forms.TextBox();
            this.txt_queue = new System.Windows.Forms.TextBox();
            this.lbx_stack = new System.Windows.Forms.ListBox();
            this.lbx_queue = new System.Windows.Forms.ListBox();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.btn_display = new System.Windows.Forms.Button();
            this.btn_enqueue = new System.Windows.Forms.Button();
            this.btn_dequeue = new System.Windows.Forms.Button();
            this.btn_displayqueue = new System.Windows.Forms.Button();
            this.txt_stackscoure = new System.Windows.Forms.TextBox();
            this.txt_queuescore = new System.Windows.Forms.TextBox();
            this.lbl_stackError = new System.Windows.Forms.Label();
            this.lbl_courseHeader = new System.Windows.Forms.Label();
            this.lbl_scoreOfCourse = new System.Windows.Forms.Label();
            this.btn_peek = new System.Windows.Forms.Button();
            this.lbl_queue_qourseName = new System.Windows.Forms.Label();
            this.lbl_queue_courseScoure = new System.Windows.Forms.Label();
            this.lbl_queueErrors = new System.Windows.Forms.Label();
            this.btn_QueuePeek = new System.Windows.Forms.Button();
            this.btn_form1toform2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stack
            // 
            this.lbl_stack.AutoSize = true;
            this.lbl_stack.Location = new System.Drawing.Point(343, 26);
            this.lbl_stack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_stack.Name = "lbl_stack";
            this.lbl_stack.Size = new System.Drawing.Size(108, 16);
            this.lbl_stack.TabIndex = 0;
            this.lbl_stack.Text = "Stack Of cources";
            // 
            // lbl_queue
            // 
            this.lbl_queue.AutoSize = true;
            this.lbl_queue.Location = new System.Drawing.Point(335, 338);
            this.lbl_queue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_queue.Name = "lbl_queue";
            this.lbl_queue.Size = new System.Drawing.Size(116, 16);
            this.lbl_queue.TabIndex = 1;
            this.lbl_queue.Text = "Queue Of Courses";
            // 
            // txt_stack
            // 
            this.txt_stack.Location = new System.Drawing.Point(67, 81);
            this.txt_stack.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stack.Name = "txt_stack";
            this.txt_stack.Size = new System.Drawing.Size(132, 22);
            this.txt_stack.TabIndex = 2;
            this.txt_stack.TextChanged += new System.EventHandler(this.txt_stack_TextChanged);
            // 
            // txt_queue
            // 
            this.txt_queue.Location = new System.Drawing.Point(58, 455);
            this.txt_queue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_queue.Name = "txt_queue";
            this.txt_queue.Size = new System.Drawing.Size(132, 22);
            this.txt_queue.TabIndex = 3;
            // 
            // lbx_stack
            // 
            this.lbx_stack.FormattingEnabled = true;
            this.lbx_stack.ItemHeight = 16;
            this.lbx_stack.Location = new System.Drawing.Point(1053, 13);
            this.lbx_stack.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_stack.Name = "lbx_stack";
            this.lbx_stack.Size = new System.Drawing.Size(159, 116);
            this.lbx_stack.TabIndex = 4;
            // 
            // lbx_queue
            // 
            this.lbx_queue.FormattingEnabled = true;
            this.lbx_queue.ItemHeight = 16;
            this.lbx_queue.Location = new System.Drawing.Point(1053, 325);
            this.lbx_queue.Margin = new System.Windows.Forms.Padding(4);
            this.lbx_queue.Name = "lbx_queue";
            this.lbx_queue.Size = new System.Drawing.Size(159, 116);
            this.lbx_queue.TabIndex = 5;
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(67, 182);
            this.btn_push.Margin = new System.Windows.Forms.Padding(4);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(100, 36);
            this.btn_push.TabIndex = 6;
            this.btn_push.Text = "Push";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(315, 182);
            this.btn_pop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(141, 36);
            this.btn_pop.TabIndex = 7;
            this.btn_pop.Text = "Pop";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(594, 182);
            this.btn_display.Margin = new System.Windows.Forms.Padding(4);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(122, 36);
            this.btn_display.TabIndex = 8;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // btn_enqueue
            // 
            this.btn_enqueue.Location = new System.Drawing.Point(58, 529);
            this.btn_enqueue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_enqueue.Name = "btn_enqueue";
            this.btn_enqueue.Size = new System.Drawing.Size(109, 45);
            this.btn_enqueue.TabIndex = 9;
            this.btn_enqueue.Text = "Enqueue";
            this.btn_enqueue.UseVisualStyleBackColor = true;
            this.btn_enqueue.Click += new System.EventHandler(this.btn_enqueue_Click);
            // 
            // btn_dequeue
            // 
            this.btn_dequeue.Location = new System.Drawing.Point(315, 529);
            this.btn_dequeue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dequeue.Name = "btn_dequeue";
            this.btn_dequeue.Size = new System.Drawing.Size(141, 45);
            this.btn_dequeue.TabIndex = 10;
            this.btn_dequeue.Text = "dequeue";
            this.btn_dequeue.UseVisualStyleBackColor = true;
            this.btn_dequeue.Click += new System.EventHandler(this.btn_dequeue_Click);
            // 
            // btn_displayqueue
            // 
            this.btn_displayqueue.Location = new System.Drawing.Point(594, 529);
            this.btn_displayqueue.Margin = new System.Windows.Forms.Padding(4);
            this.btn_displayqueue.Name = "btn_displayqueue";
            this.btn_displayqueue.Size = new System.Drawing.Size(122, 45);
            this.btn_displayqueue.TabIndex = 11;
            this.btn_displayqueue.Text = "Display";
            this.btn_displayqueue.UseVisualStyleBackColor = true;
            this.btn_displayqueue.Click += new System.EventHandler(this.btn_displayqueue_Click);
            // 
            // txt_stackscoure
            // 
            this.txt_stackscoure.Location = new System.Drawing.Point(584, 81);
            this.txt_stackscoure.Margin = new System.Windows.Forms.Padding(4);
            this.txt_stackscoure.Name = "txt_stackscoure";
            this.txt_stackscoure.Size = new System.Drawing.Size(147, 22);
            this.txt_stackscoure.TabIndex = 12;
            // 
            // txt_queuescore
            // 
            this.txt_queuescore.Location = new System.Drawing.Point(584, 452);
            this.txt_queuescore.Margin = new System.Windows.Forms.Padding(4);
            this.txt_queuescore.Name = "txt_queuescore";
            this.txt_queuescore.Size = new System.Drawing.Size(147, 22);
            this.txt_queuescore.TabIndex = 13;
            // 
            // lbl_stackError
            // 
            this.lbl_stackError.AutoSize = true;
            this.lbl_stackError.Location = new System.Drawing.Point(300, 87);
            this.lbl_stackError.Name = "lbl_stackError";
            this.lbl_stackError.Size = new System.Drawing.Size(207, 16);
            this.lbl_stackError.TabIndex = 14;
            this.lbl_stackError.Text = "<<<Both Textboxes Should Fill>>>";
            // 
            // lbl_courseHeader
            // 
            this.lbl_courseHeader.AutoSize = true;
            this.lbl_courseHeader.Location = new System.Drawing.Point(86, 26);
            this.lbl_courseHeader.Name = "lbl_courseHeader";
            this.lbl_courseHeader.Size = new System.Drawing.Size(90, 16);
            this.lbl_courseHeader.TabIndex = 15;
            this.lbl_courseHeader.Text = "Course Name";
            // 
            // lbl_scoreOfCourse
            // 
            this.lbl_scoreOfCourse.AutoSize = true;
            this.lbl_scoreOfCourse.Location = new System.Drawing.Point(607, 26);
            this.lbl_scoreOfCourse.Name = "lbl_scoreOfCourse";
            this.lbl_scoreOfCourse.Size = new System.Drawing.Size(99, 16);
            this.lbl_scoreOfCourse.TabIndex = 16;
            this.lbl_scoreOfCourse.Text = "Course Scoure:";
            // 
            // btn_peek
            // 
            this.btn_peek.Location = new System.Drawing.Point(789, 182);
            this.btn_peek.Name = "btn_peek";
            this.btn_peek.Size = new System.Drawing.Size(135, 36);
            this.btn_peek.TabIndex = 17;
            this.btn_peek.Text = "PEEK";
            this.btn_peek.UseVisualStyleBackColor = true;
            this.btn_peek.Click += new System.EventHandler(this.btn_peek_Click);
            // 
            // lbl_queue_qourseName
            // 
            this.lbl_queue_qourseName.AutoSize = true;
            this.lbl_queue_qourseName.Location = new System.Drawing.Point(64, 378);
            this.lbl_queue_qourseName.Name = "lbl_queue_qourseName";
            this.lbl_queue_qourseName.Size = new System.Drawing.Size(87, 16);
            this.lbl_queue_qourseName.TabIndex = 18;
            this.lbl_queue_qourseName.Text = "CourseName";
            // 
            // lbl_queue_courseScoure
            // 
            this.lbl_queue_courseScoure.AutoSize = true;
            this.lbl_queue_courseScoure.Location = new System.Drawing.Point(607, 378);
            this.lbl_queue_courseScoure.Name = "lbl_queue_courseScoure";
            this.lbl_queue_courseScoure.Size = new System.Drawing.Size(96, 16);
            this.lbl_queue_courseScoure.TabIndex = 19;
            this.lbl_queue_courseScoure.Text = "Course Scoure";
            // 
            // lbl_queueErrors
            // 
            this.lbl_queueErrors.AutoSize = true;
            this.lbl_queueErrors.Location = new System.Drawing.Point(289, 455);
            this.lbl_queueErrors.Name = "lbl_queueErrors";
            this.lbl_queueErrors.Size = new System.Drawing.Size(208, 16);
            this.lbl_queueErrors.TabIndex = 20;
            this.lbl_queueErrors.Text = "<<<Both TextBoxes Should Fill>>>";
            // 
            // btn_QueuePeek
            // 
            this.btn_QueuePeek.Location = new System.Drawing.Point(818, 529);
            this.btn_QueuePeek.Name = "btn_QueuePeek";
            this.btn_QueuePeek.Size = new System.Drawing.Size(106, 45);
            this.btn_QueuePeek.TabIndex = 21;
            this.btn_QueuePeek.Text = "PEEK";
            this.btn_QueuePeek.UseVisualStyleBackColor = true;
            this.btn_QueuePeek.Click += new System.EventHandler(this.btn_QueuePeek_Click);
            // 
            // btn_form1toform2
            // 
            this.btn_form1toform2.Location = new System.Drawing.Point(1089, 540);
            this.btn_form1toform2.Name = "btn_form1toform2";
            this.btn_form1toform2.Size = new System.Drawing.Size(108, 34);
            this.btn_form1toform2.TabIndex = 22;
            this.btn_form1toform2.Text = "Form2";
            this.btn_form1toform2.UseVisualStyleBackColor = true;
            this.btn_form1toform2.Click += new System.EventHandler(this.btn_form1toform2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_form1toform2);
            this.Controls.Add(this.btn_QueuePeek);
            this.Controls.Add(this.lbl_queueErrors);
            this.Controls.Add(this.lbl_queue_courseScoure);
            this.Controls.Add(this.lbl_queue_qourseName);
            this.Controls.Add(this.btn_peek);
            this.Controls.Add(this.lbl_scoreOfCourse);
            this.Controls.Add(this.lbl_courseHeader);
            this.Controls.Add(this.lbl_stackError);
            this.Controls.Add(this.txt_queuescore);
            this.Controls.Add(this.txt_stackscoure);
            this.Controls.Add(this.btn_displayqueue);
            this.Controls.Add(this.btn_dequeue);
            this.Controls.Add(this.btn_enqueue);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.lbx_queue);
            this.Controls.Add(this.lbx_stack);
            this.Controls.Add(this.txt_queue);
            this.Controls.Add(this.txt_stack);
            this.Controls.Add(this.lbl_queue);
            this.Controls.Add(this.lbl_stack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Stack and Assignment 02 :Hamed Tara - n01540404";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stack;
        private System.Windows.Forms.Label lbl_queue;
        private System.Windows.Forms.TextBox txt_stack;
        private System.Windows.Forms.TextBox txt_queue;
        private System.Windows.Forms.ListBox lbx_stack;
        private System.Windows.Forms.ListBox lbx_queue;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_enqueue;
        private System.Windows.Forms.Button btn_dequeue;
        private System.Windows.Forms.Button btn_displayqueue;
        private System.Windows.Forms.TextBox txt_stackscoure;
        private System.Windows.Forms.TextBox txt_queuescore;
        private System.Windows.Forms.Label lbl_stackError;
        private System.Windows.Forms.Label lbl_courseHeader;
        private System.Windows.Forms.Label lbl_scoreOfCourse;
        private System.Windows.Forms.Button btn_peek;
        private System.Windows.Forms.Label lbl_queue_qourseName;
        private System.Windows.Forms.Label lbl_queue_courseScoure;
        private System.Windows.Forms.Label lbl_queueErrors;
        private System.Windows.Forms.Button btn_QueuePeek;
        private System.Windows.Forms.Button btn_form1toform2;
    }
}

