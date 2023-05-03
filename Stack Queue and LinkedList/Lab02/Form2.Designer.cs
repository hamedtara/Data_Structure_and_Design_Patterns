namespace Lab02
{
    partial class Form2
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
            this.btn_addlast2 = new System.Windows.Forms.Button();
            this.btn_remove2 = new System.Windows.Forms.Button();
            this.btn_find2 = new System.Windows.Forms.Button();
            this.btn_display2 = new System.Windows.Forms.Button();
            this.txt_coursesLL2 = new System.Windows.Forms.TextBox();
            this.txt_scoreLL2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_linklist2 = new System.Windows.Forms.ListBox();
            this.btn_form2toform1 = new System.Windows.Forms.Button();
            this.lbl_linklistError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_addFirst = new System.Windows.Forms.Button();
            this.btn_removeLast = new System.Windows.Forms.Button();
            this.btn_removeFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addlast2
            // 
            this.btn_addlast2.Location = new System.Drawing.Point(29, 409);
            this.btn_addlast2.Name = "btn_addlast2";
            this.btn_addlast2.Size = new System.Drawing.Size(98, 30);
            this.btn_addlast2.TabIndex = 0;
            this.btn_addlast2.Text = "AddLast";
            this.btn_addlast2.UseVisualStyleBackColor = true;
            this.btn_addlast2.Click += new System.EventHandler(this.btn_addlast2_Click_1);
            // 
            // btn_remove2
            // 
            this.btn_remove2.Location = new System.Drawing.Point(342, 409);
            this.btn_remove2.Name = "btn_remove2";
            this.btn_remove2.Size = new System.Drawing.Size(101, 30);
            this.btn_remove2.TabIndex = 1;
            this.btn_remove2.Text = "Remove";
            this.btn_remove2.UseVisualStyleBackColor = true;
            this.btn_remove2.Click += new System.EventHandler(this.btn_remove2_Click);
            // 
            // btn_find2
            // 
            this.btn_find2.Location = new System.Drawing.Point(559, 409);
            this.btn_find2.Name = "btn_find2";
            this.btn_find2.Size = new System.Drawing.Size(111, 30);
            this.btn_find2.TabIndex = 2;
            this.btn_find2.Text = "Find";
            this.btn_find2.UseVisualStyleBackColor = true;
            this.btn_find2.Click += new System.EventHandler(this.btn_find2_Click);
            // 
            // btn_display2
            // 
            this.btn_display2.Location = new System.Drawing.Point(757, 409);
            this.btn_display2.Name = "btn_display2";
            this.btn_display2.Size = new System.Drawing.Size(94, 30);
            this.btn_display2.TabIndex = 3;
            this.btn_display2.Text = "Display";
            this.btn_display2.UseVisualStyleBackColor = true;
            this.btn_display2.Click += new System.EventHandler(this.btn_display2_Click);
            // 
            // txt_coursesLL2
            // 
            this.txt_coursesLL2.Location = new System.Drawing.Point(165, 270);
            this.txt_coursesLL2.Name = "txt_coursesLL2";
            this.txt_coursesLL2.Size = new System.Drawing.Size(100, 22);
            this.txt_coursesLL2.TabIndex = 4;
            this.txt_coursesLL2.TextChanged += new System.EventHandler(this.txt_coursesLL2_TextChanged);
            // 
            // txt_scoreLL2
            // 
            this.txt_scoreLL2.Location = new System.Drawing.Point(732, 267);
            this.txt_scoreLL2.Name = "txt_scoreLL2";
            this.txt_scoreLL2.Size = new System.Drawing.Size(100, 22);
            this.txt_scoreLL2.TabIndex = 5;
            this.txt_scoreLL2.TextChanged += new System.EventHandler(this.txt_scoreLL2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LinkList";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbx_linklist2
            // 
            this.lbx_linklist2.FormattingEnabled = true;
            this.lbx_linklist2.ItemHeight = 16;
            this.lbx_linklist2.Location = new System.Drawing.Point(885, 149);
            this.lbx_linklist2.Name = "lbx_linklist2";
            this.lbx_linklist2.Size = new System.Drawing.Size(120, 84);
            this.lbx_linklist2.TabIndex = 7;
            // 
            // btn_form2toform1
            // 
            this.btn_form2toform1.Location = new System.Drawing.Point(897, 471);
            this.btn_form2toform1.Name = "btn_form2toform1";
            this.btn_form2toform1.Size = new System.Drawing.Size(108, 34);
            this.btn_form2toform1.TabIndex = 23;
            this.btn_form2toform1.Text = "Form1";
            this.btn_form2toform1.UseVisualStyleBackColor = true;
            this.btn_form2toform1.Click += new System.EventHandler(this.btn_form2toform1_Click);
            // 
            // lbl_linklistError
            // 
            this.lbl_linklistError.AutoSize = true;
            this.lbl_linklistError.Location = new System.Drawing.Point(401, 273);
            this.lbl_linklistError.Name = "lbl_linklistError";
            this.lbl_linklistError.Size = new System.Drawing.Size(182, 16);
            this.lbl_linklistError.TabIndex = 25;
            this.lbl_linklistError.Text = "<<<Both Texes Should Fill>>>";
            this.lbl_linklistError.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Scoure";
            // 
            // btn_addFirst
            // 
            this.btn_addFirst.Location = new System.Drawing.Point(180, 408);
            this.btn_addFirst.Name = "btn_addFirst";
            this.btn_addFirst.Size = new System.Drawing.Size(96, 32);
            this.btn_addFirst.TabIndex = 28;
            this.btn_addFirst.Text = "AddFirst";
            this.btn_addFirst.UseVisualStyleBackColor = true;
            this.btn_addFirst.Click += new System.EventHandler(this.btn_addFirst_Click);
            // 
            // btn_removeLast
            // 
            this.btn_removeLast.Location = new System.Drawing.Point(29, 459);
            this.btn_removeLast.Name = "btn_removeLast";
            this.btn_removeLast.Size = new System.Drawing.Size(98, 31);
            this.btn_removeLast.TabIndex = 29;
            this.btn_removeLast.Text = "RemoveLast";
            this.btn_removeLast.UseVisualStyleBackColor = true;
            this.btn_removeLast.Click += new System.EventHandler(this.btn_removeLast_Click);
            // 
            // btn_removeFirst
            // 
            this.btn_removeFirst.Location = new System.Drawing.Point(180, 459);
            this.btn_removeFirst.Name = "btn_removeFirst";
            this.btn_removeFirst.Size = new System.Drawing.Size(96, 31);
            this.btn_removeFirst.TabIndex = 30;
            this.btn_removeFirst.Text = "RemoveFirst";
            this.btn_removeFirst.UseVisualStyleBackColor = true;
            this.btn_removeFirst.Click += new System.EventHandler(this.btn_removeFirst_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1038, 538);
            this.Controls.Add(this.btn_removeFirst);
            this.Controls.Add(this.btn_removeLast);
            this.Controls.Add(this.btn_addFirst);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_linklistError);
            this.Controls.Add(this.btn_form2toform1);
            this.Controls.Add(this.lbx_linklist2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_scoreLL2);
            this.Controls.Add(this.txt_coursesLL2);
            this.Controls.Add(this.btn_display2);
            this.Controls.Add(this.btn_find2);
            this.Controls.Add(this.btn_remove2);
            this.Controls.Add(this.btn_addlast2);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_addlast;
        private System.Windows.Forms.ListBox lbx_linklist;
        private System.Windows.Forms.TextBox txt_coursesLL;
        private System.Windows.Forms.TextBox txt_scoreLL;
        private System.Windows.Forms.Label lbl_linklist;
        private System.Windows.Forms.Button btn_addlast2;
        private System.Windows.Forms.Button btn_remove2;
        private System.Windows.Forms.Button btn_find2;
        private System.Windows.Forms.Button btn_display2;
        private System.Windows.Forms.TextBox txt_coursesLL2;
        private System.Windows.Forms.TextBox txt_scoreLL2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_linklist2;
        private System.Windows.Forms.Button btn_form2toform1;
        private System.Windows.Forms.Label lbl_linklistError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addFirst;
        private System.Windows.Forms.Button btn_removeLast;
        private System.Windows.Forms.Button btn_removeFirst;
    }
}