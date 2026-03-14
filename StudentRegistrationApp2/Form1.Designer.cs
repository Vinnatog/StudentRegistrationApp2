namespace StudentRegistrationApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.tblname = new System.Windows.Forms.TextBox();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.tbmname = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfmale = new System.Windows.Forms.RadioButton();
            this.cbday = new System.Windows.Forms.ComboBox();
            this.cbyear = new System.Windows.Forms.ComboBox();
            this.cbmonth = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbprogram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "STUDENT REGISTRATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FirstName*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MiddleName*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(249, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Of Birth*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(214, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gender*";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(210, 71);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(88, 20);
            this.LastName.TabIndex = 5;
            this.LastName.Text = "LastName*";
            // 
            // tblname
            // 
            this.tblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblname.Location = new System.Drawing.Point(214, 94);
            this.tblname.Name = "tblname";
            this.tblname.Size = new System.Drawing.Size(283, 26);
            this.tblname.TabIndex = 6;
            this.tblname.TextChanged += new System.EventHandler(this.tblname_TextChanged);
            // 
            // tbfname
            // 
            this.tbfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfname.Location = new System.Drawing.Point(214, 162);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(283, 26);
            this.tbfname.TabIndex = 7;
            this.tbfname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbmname
            // 
            this.tbmname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmname.Location = new System.Drawing.Point(214, 220);
            this.tbmname.Name = "tbmname";
            this.tbmname.Size = new System.Drawing.Size(283, 26);
            this.tbmname.TabIndex = 8;
            this.tbmname.TextChanged += new System.EventHandler(this.tbmname_TextChanged);
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(240, 369);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(61, 24);
            this.rbmale.TabIndex = 9;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            this.rbmale.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbfmale
            // 
            this.rbfmale.AutoSize = true;
            this.rbfmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfmale.Location = new System.Drawing.Point(307, 369);
            this.rbfmale.Name = "rbfmale";
            this.rbfmale.Size = new System.Drawing.Size(80, 24);
            this.rbfmale.TabIndex = 10;
            this.rbfmale.TabStop = true;
            this.rbfmale.Text = "Female";
            this.rbfmale.UseVisualStyleBackColor = true;
            this.rbfmale.CheckedChanged += new System.EventHandler(this.rbfmale_CheckedChanged);
            // 
            // cbday
            // 
            this.cbday.FormattingEnabled = true;
            this.cbday.Location = new System.Drawing.Point(122, 437);
            this.cbday.Name = "cbday";
            this.cbday.Size = new System.Drawing.Size(121, 21);
            this.cbday.TabIndex = 11;
            this.cbday.SelectedIndexChanged += new System.EventHandler(this.cbday_SelectedIndexChanged);
            // 
            // cbyear
            // 
            this.cbyear.FormattingEnabled = true;
            this.cbyear.Location = new System.Drawing.Point(391, 437);
            this.cbyear.Name = "cbyear";
            this.cbyear.Size = new System.Drawing.Size(121, 21);
            this.cbyear.TabIndex = 12;
            this.cbyear.SelectedIndexChanged += new System.EventHandler(this.cbyear_SelectedIndexChanged);
            // 
            // cbmonth
            // 
            this.cbmonth.FormattingEnabled = true;
            this.cbmonth.Location = new System.Drawing.Point(253, 437);
            this.cbmonth.Name = "cbmonth";
            this.cbmonth.Size = new System.Drawing.Size(121, 21);
            this.cbmonth.TabIndex = 13;
            this.cbmonth.SelectedIndexChanged += new System.EventHandler(this.cbmonth_SelectedIndexChanged);
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Crimson;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(214, 476);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(184, 39);
            this.btn.TabIndex = 14;
            this.btn.Text = "Student Register";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Program To Apply*";
            // 
            // cbprogram
            // 
            this.cbprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbprogram.FormattingEnabled = true;
            this.cbprogram.Location = new System.Drawing.Point(122, 306);
            this.cbprogram.Name = "cbprogram";
            this.cbprogram.Size = new System.Drawing.Size(404, 28);
            this.cbprogram.TabIndex = 16;
            this.cbprogram.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 582);
            this.Controls.Add(this.cbprogram);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.cbmonth);
            this.Controls.Add(this.cbyear);
            this.Controls.Add(this.cbday);
            this.Controls.Add(this.rbfmale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.tbmname);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.tblname);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox tblname;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.TextBox tbmname;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.RadioButton rbfmale;
        private System.Windows.Forms.ComboBox cbday;
        private System.Windows.Forms.ComboBox cbyear;
        private System.Windows.Forms.ComboBox cbmonth;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbprogram;
    }
}

