namespace lab04
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
            this.hs1 = new System.Windows.Forms.ListBox();
            this.hs2 = new System.Windows.Forms.ListBox();
            this.btn_disolay = new System.Windows.Forms.Button();
            this.btn_inresection = new System.Windows.Forms.Button();
            this.btn_subset = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_union = new System.Windows.Forms.Button();
            this.btn_superset = new System.Windows.Forms.Button();
            this.btn_Add_has1 = new System.Windows.Forms.Button();
            this.btn_hs1_remove = new System.Windows.Forms.Button();
            this.btn_hs2_add = new System.Windows.Forms.Button();
            this.btn_hs2_remove = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_form1 = new System.Windows.Forms.Button();
            this.lbl_hashset_error_list = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_f2tof3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hs1
            // 
            this.hs1.FormattingEnabled = true;
            this.hs1.ItemHeight = 16;
            this.hs1.Location = new System.Drawing.Point(57, 32);
            this.hs1.Name = "hs1";
            this.hs1.Size = new System.Drawing.Size(120, 84);
            this.hs1.TabIndex = 0;
            // 
            // hs2
            // 
            this.hs2.FormattingEnabled = true;
            this.hs2.ItemHeight = 16;
            this.hs2.Location = new System.Drawing.Point(654, 21);
            this.hs2.Name = "hs2";
            this.hs2.Size = new System.Drawing.Size(120, 84);
            this.hs2.TabIndex = 1;
            // 
            // btn_disolay
            // 
            this.btn_disolay.Location = new System.Drawing.Point(275, 32);
            this.btn_disolay.Name = "btn_disolay";
            this.btn_disolay.Size = new System.Drawing.Size(89, 23);
            this.btn_disolay.TabIndex = 2;
            this.btn_disolay.Text = "Display";
            this.btn_disolay.UseVisualStyleBackColor = true;
            this.btn_disolay.Click += new System.EventHandler(this.btn_disolay_Click);
            // 
            // btn_inresection
            // 
            this.btn_inresection.Location = new System.Drawing.Point(275, 61);
            this.btn_inresection.Name = "btn_inresection";
            this.btn_inresection.Size = new System.Drawing.Size(89, 23);
            this.btn_inresection.TabIndex = 3;
            this.btn_inresection.Text = "Intersection";
            this.btn_inresection.UseVisualStyleBackColor = true;
            this.btn_inresection.Click += new System.EventHandler(this.btn_inresection_Click);
            // 
            // btn_subset
            // 
            this.btn_subset.Location = new System.Drawing.Point(275, 93);
            this.btn_subset.Name = "btn_subset";
            this.btn_subset.Size = new System.Drawing.Size(89, 23);
            this.btn_subset.TabIndex = 4;
            this.btn_subset.Text = "Subset";
            this.btn_subset.UseVisualStyleBackColor = true;
            this.btn_subset.Click += new System.EventHandler(this.btn_subset_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(405, 32);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_union
            // 
            this.btn_union.Location = new System.Drawing.Point(405, 61);
            this.btn_union.Name = "btn_union";
            this.btn_union.Size = new System.Drawing.Size(75, 23);
            this.btn_union.TabIndex = 6;
            this.btn_union.Text = "Union";
            this.btn_union.UseVisualStyleBackColor = true;
            this.btn_union.Click += new System.EventHandler(this.btn_union_Click);
            // 
            // btn_superset
            // 
            this.btn_superset.Location = new System.Drawing.Point(405, 93);
            this.btn_superset.Name = "btn_superset";
            this.btn_superset.Size = new System.Drawing.Size(75, 23);
            this.btn_superset.TabIndex = 7;
            this.btn_superset.Text = "Superset";
            this.btn_superset.UseVisualStyleBackColor = true;
            this.btn_superset.Click += new System.EventHandler(this.btn_superset_Click);
            // 
            // btn_Add_has1
            // 
            this.btn_Add_has1.Location = new System.Drawing.Point(57, 235);
            this.btn_Add_has1.Name = "btn_Add_has1";
            this.btn_Add_has1.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_has1.TabIndex = 8;
            this.btn_Add_has1.Text = "Add";
            this.btn_Add_has1.UseVisualStyleBackColor = true;
            this.btn_Add_has1.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_hs1_remove
            // 
            this.btn_hs1_remove.Location = new System.Drawing.Point(182, 235);
            this.btn_hs1_remove.Name = "btn_hs1_remove";
            this.btn_hs1_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_hs1_remove.TabIndex = 9;
            this.btn_hs1_remove.Text = "Remove";
            this.btn_hs1_remove.UseVisualStyleBackColor = true;
            this.btn_hs1_remove.Click += new System.EventHandler(this.btn_hs1_remove_Click);
            // 
            // btn_hs2_add
            // 
            this.btn_hs2_add.Location = new System.Drawing.Point(569, 235);
            this.btn_hs2_add.Name = "btn_hs2_add";
            this.btn_hs2_add.Size = new System.Drawing.Size(75, 23);
            this.btn_hs2_add.TabIndex = 10;
            this.btn_hs2_add.Text = "Add";
            this.btn_hs2_add.UseVisualStyleBackColor = true;
            this.btn_hs2_add.Click += new System.EventHandler(this.btn_hs2_add_Click);
            // 
            // btn_hs2_remove
            // 
            this.btn_hs2_remove.Location = new System.Drawing.Point(682, 235);
            this.btn_hs2_remove.Name = "btn_hs2_remove";
            this.btn_hs2_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_hs2_remove.TabIndex = 11;
            this.btn_hs2_remove.Text = "Remove";
            this.btn_hs2_remove.UseVisualStyleBackColor = true;
            this.btn_hs2_remove.Click += new System.EventHandler(this.btn_hs2_remove_Click);
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(362, 235);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 22);
            this.txt_input.TabIndex = 12;
            // 
            // btn_form1
            // 
            this.btn_form1.Location = new System.Drawing.Point(25, 379);
            this.btn_form1.Name = "btn_form1";
            this.btn_form1.Size = new System.Drawing.Size(75, 23);
            this.btn_form1.TabIndex = 14;
            this.btn_form1.Text = "Form1";
            this.btn_form1.UseVisualStyleBackColor = true;
            this.btn_form1.Click += new System.EventHandler(this.btn_form1_Click);
            // 
            // lbl_hashset_error_list
            // 
            this.lbl_hashset_error_list.AutoSize = true;
            this.lbl_hashset_error_list.Location = new System.Drawing.Point(262, 326);
            this.lbl_hashset_error_list.Name = "lbl_hashset_error_list";
            this.lbl_hashset_error_list.Size = new System.Drawing.Size(146, 16);
            this.lbl_hashset_error_list.TabIndex = 16;
            this.lbl_hashset_error_list.Text = "<<<HastSetErrorList>>>";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(350, 161);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(76, 20);
            this.lbl_result.TabIndex = 13;
            this.lbl_result.Text = "RESULT";
            // 
            // btn_f2tof3
            // 
            this.btn_f2tof3.Location = new System.Drawing.Point(677, 383);
            this.btn_f2tof3.Name = "btn_f2tof3";
            this.btn_f2tof3.Size = new System.Drawing.Size(75, 23);
            this.btn_f2tof3.TabIndex = 17;
            this.btn_f2tof3.Text = "Form3";
            this.btn_f2tof3.UseVisualStyleBackColor = true;
            this.btn_f2tof3.Click += new System.EventHandler(this.btn_f2tof3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_f2tof3);
            this.Controls.Add(this.lbl_hashset_error_list);
            this.Controls.Add(this.btn_form1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_hs2_remove);
            this.Controls.Add(this.btn_hs2_add);
            this.Controls.Add(this.btn_hs1_remove);
            this.Controls.Add(this.btn_Add_has1);
            this.Controls.Add(this.btn_superset);
            this.Controls.Add(this.btn_union);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_subset);
            this.Controls.Add(this.btn_inresection);
            this.Controls.Add(this.btn_disolay);
            this.Controls.Add(this.hs2);
            this.Controls.Add(this.hs1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox hs1;
        private System.Windows.Forms.ListBox hs2;
        private System.Windows.Forms.Button btn_disolay;
        private System.Windows.Forms.Button btn_inresection;
        private System.Windows.Forms.Button btn_subset;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_union;
        private System.Windows.Forms.Button btn_superset;
        private System.Windows.Forms.Button btn_Add_has1;
        private System.Windows.Forms.Button btn_hs1_remove;
        private System.Windows.Forms.Button btn_hs2_add;
        private System.Windows.Forms.Button btn_hs2_remove;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_form1;
        private System.Windows.Forms.Label lbl_hashset_error_list;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_f2tof3;
    }
}