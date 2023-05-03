namespace Lab_01_V2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ArrayList = new System.Windows.Forms.Label();
            this.btn_AddAL = new System.Windows.Forms.Button();
            this.btn_RemoveAL = new System.Windows.Forms.Button();
            this.btn_DisplayAl = new System.Windows.Forms.Button();
            this.txt_ArrayList = new System.Windows.Forms.TextBox();
            this.lbx_ArrayList = new System.Windows.Forms.ListBox();
            this.lbx_List = new System.Windows.Forms.ListBox();
            this.btn_AddL = new System.Windows.Forms.Button();
            this.btn_removeL = new System.Windows.Forms.Button();
            this.btn_DisplatL = new System.Windows.Forms.Button();
            this.lbl_list = new System.Windows.Forms.Label();
            this.txt_List = new System.Windows.Forms.TextBox();
            this.lbl_Array_errorLabel = new System.Windows.Forms.Label();
            this.lbl_list_erroerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ArrayList
            // 
            this.lbl_ArrayList.AutoSize = true;
            this.lbl_ArrayList.Location = new System.Drawing.Point(287, 34);
            this.lbl_ArrayList.Name = "lbl_ArrayList";
            this.lbl_ArrayList.Size = new System.Drawing.Size(156, 20);
            this.lbl_ArrayList.TabIndex = 0;
            this.lbl_ArrayList.Text = "List - Array Of Cources";
            // 
            // btn_AddAL
            // 
            this.btn_AddAL.Location = new System.Drawing.Point(168, 233);
            this.btn_AddAL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddAL.Name = "btn_AddAL";
            this.btn_AddAL.Size = new System.Drawing.Size(86, 31);
            this.btn_AddAL.TabIndex = 1;
            this.btn_AddAL.Text = "Add";
            this.btn_AddAL.UseVisualStyleBackColor = true;
            this.btn_AddAL.Click += new System.EventHandler(this.btn_AddAL_Click);
            // 
            // btn_RemoveAL
            // 
            this.btn_RemoveAL.Location = new System.Drawing.Point(298, 233);
            this.btn_RemoveAL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_RemoveAL.Name = "btn_RemoveAL";
            this.btn_RemoveAL.Size = new System.Drawing.Size(86, 31);
            this.btn_RemoveAL.TabIndex = 2;
            this.btn_RemoveAL.Text = "Remove";
            this.btn_RemoveAL.UseVisualStyleBackColor = true;
            this.btn_RemoveAL.Click += new System.EventHandler(this.btn_RemoveAL_Click);
            // 
            // btn_DisplayAl
            // 
            this.btn_DisplayAl.Location = new System.Drawing.Point(446, 233);
            this.btn_DisplayAl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DisplayAl.Name = "btn_DisplayAl";
            this.btn_DisplayAl.Size = new System.Drawing.Size(86, 31);
            this.btn_DisplayAl.TabIndex = 3;
            this.btn_DisplayAl.Text = "Display";
            this.btn_DisplayAl.UseVisualStyleBackColor = true;
            this.btn_DisplayAl.Click += new System.EventHandler(this.btn_DisplayAl_Click);
            // 
            // txt_ArrayList
            // 
            this.txt_ArrayList.Location = new System.Drawing.Point(301, 75);
            this.txt_ArrayList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ArrayList.Name = "txt_ArrayList";
            this.txt_ArrayList.Size = new System.Drawing.Size(114, 27);
            this.txt_ArrayList.TabIndex = 4;
            this.txt_ArrayList.TextChanged += new System.EventHandler(this.txt_ArrayList_TextChanged);
            // 
            // lbx_ArrayList
            // 
            this.lbx_ArrayList.FormattingEnabled = true;
            this.lbx_ArrayList.ItemHeight = 20;
            this.lbx_ArrayList.Location = new System.Drawing.Point(698, 75);
            this.lbx_ArrayList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbx_ArrayList.Name = "lbx_ArrayList";
            this.lbx_ArrayList.Size = new System.Drawing.Size(137, 124);
            this.lbx_ArrayList.TabIndex = 5;
            // 
            // lbx_List
            // 
            this.lbx_List.FormattingEnabled = true;
            this.lbx_List.ItemHeight = 20;
            this.lbx_List.Location = new System.Drawing.Point(698, 376);
            this.lbx_List.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbx_List.Name = "lbx_List";
            this.lbx_List.Size = new System.Drawing.Size(137, 124);
            this.lbx_List.TabIndex = 6;
            // 
            // btn_AddL
            // 
            this.btn_AddL.Location = new System.Drawing.Point(168, 483);
            this.btn_AddL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddL.Name = "btn_AddL";
            this.btn_AddL.Size = new System.Drawing.Size(86, 31);
            this.btn_AddL.TabIndex = 7;
            this.btn_AddL.Text = "Add";
            this.btn_AddL.UseVisualStyleBackColor = true;
            this.btn_AddL.Click += new System.EventHandler(this.btn_AddL_Click);
            // 
            // btn_removeL
            // 
            this.btn_removeL.Location = new System.Drawing.Point(298, 483);
            this.btn_removeL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_removeL.Name = "btn_removeL";
            this.btn_removeL.Size = new System.Drawing.Size(86, 31);
            this.btn_removeL.TabIndex = 8;
            this.btn_removeL.Text = "Remove";
            this.btn_removeL.UseVisualStyleBackColor = true;
            this.btn_removeL.Click += new System.EventHandler(this.btn_removeL_Click);
            // 
            // btn_DisplatL
            // 
            this.btn_DisplatL.Location = new System.Drawing.Point(446, 483);
            this.btn_DisplatL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DisplatL.Name = "btn_DisplatL";
            this.btn_DisplatL.Size = new System.Drawing.Size(86, 31);
            this.btn_DisplatL.TabIndex = 9;
            this.btn_DisplatL.Text = "Display";
            this.btn_DisplatL.UseVisualStyleBackColor = true;
            this.btn_DisplatL.Click += new System.EventHandler(this.btn_DisplatL_Click);
            // 
            // lbl_list
            // 
            this.lbl_list.AutoSize = true;
            this.lbl_list.Location = new System.Drawing.Point(295, 315);
            this.lbl_list.Name = "lbl_list";
            this.lbl_list.Size = new System.Drawing.Size(138, 20);
            this.lbl_list.TabIndex = 10;
            this.lbl_list.Text = "List-List  Of Scoures";
            // 
            // txt_List
            // 
            this.txt_List.Location = new System.Drawing.Point(298, 361);
            this.txt_List.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_List.Name = "txt_List";
            this.txt_List.Size = new System.Drawing.Size(114, 27);
            this.txt_List.TabIndex = 11;
            // 
            // lbl_Array_errorLabel
            // 
            this.lbl_Array_errorLabel.AutoSize = true;
            this.lbl_Array_errorLabel.Location = new System.Drawing.Point(239, 134);
            this.lbl_Array_errorLabel.Name = "lbl_Array_errorLabel";
            this.lbl_Array_errorLabel.Size = new System.Drawing.Size(238, 20);
            this.lbl_Array_errorLabel.TabIndex = 12;
            this.lbl_Array_errorLabel.Text = "Welcome TO Hamed Tara Program";
            // 
            // lbl_list_erroerLabel
            // 
            this.lbl_list_erroerLabel.AutoSize = true;
            this.lbl_list_erroerLabel.Location = new System.Drawing.Point(227, 412);
            this.lbl_list_erroerLabel.Name = "lbl_list_erroerLabel";
            this.lbl_list_erroerLabel.Size = new System.Drawing.Size(238, 20);
            this.lbl_list_erroerLabel.TabIndex = 13;
            this.lbl_list_erroerLabel.Text = "Welcome TO Hamed Tara Program";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lbl_list_erroerLabel);
            this.Controls.Add(this.lbl_Array_errorLabel);
            this.Controls.Add(this.txt_List);
            this.Controls.Add(this.lbl_list);
            this.Controls.Add(this.btn_DisplatL);
            this.Controls.Add(this.btn_removeL);
            this.Controls.Add(this.btn_AddL);
            this.Controls.Add(this.lbx_List);
            this.Controls.Add(this.lbx_ArrayList);
            this.Controls.Add(this.txt_ArrayList);
            this.Controls.Add(this.btn_DisplayAl);
            this.Controls.Add(this.btn_RemoveAL);
            this.Controls.Add(this.btn_AddAL);
            this.Controls.Add(this.lbl_ArrayList);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "  Hamed Tara - n01540404 - Assignment1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_ArrayList;
        private Button btn_AddAL;
        private Button btn_RemoveAL;
        private Button btn_DisplayAl;
        private TextBox txt_ArrayList;
        private ListBox lbx_ArrayList;
        private ListBox lbx_List;
        private Button btn_AddL;
        private Button btn_removeL;
        private Button btn_DisplatL;
        private Label lbl_list;
        private TextBox txt_List;
        private Label lbl_Array_errorLabel;
        private Label lbl_list_erroerLabel;
    }
}