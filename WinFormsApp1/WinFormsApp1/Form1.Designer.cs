namespace WinFormsApp1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.chJava = new System.Windows.Forms.CheckBox();
            this.chPython = new System.Windows.Forms.CheckBox();
            this.chnet = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(393, 30);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 45);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designation";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplay.Location = new System.Drawing.Point(422, 348);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(176, 62);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Save";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(455, 482);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(393, 168);
            this.txtSalary.Multiline = true;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(300, 45);
            this.txtSalary.TabIndex = 8;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(393, 103);
            this.txtDesignation.Multiline = true;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(300, 45);
            this.txtDesignation.TabIndex = 9;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(393, 230);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(75, 29);
            this.rdbtnMale.TabIndex = 10;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(189, 232);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 25);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(568, 230);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(93, 29);
            this.rdbtnFemale.TabIndex = 12;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Skills";
            // 
            // chJava
            // 
            this.chJava.AutoSize = true;
            this.chJava.BackColor = System.Drawing.Color.Silver;
            this.chJava.Location = new System.Drawing.Point(397, 282);
            this.chJava.Name = "chJava";
            this.chJava.Size = new System.Drawing.Size(71, 29);
            this.chJava.TabIndex = 14;
            this.chJava.Text = "Java";
            this.chJava.UseVisualStyleBackColor = false;
            // 
            // chPython
            // 
            this.chPython.AutoSize = true;
            this.chPython.BackColor = System.Drawing.Color.Silver;
            this.chPython.Location = new System.Drawing.Point(474, 282);
            this.chPython.Name = "chPython";
            this.chPython.Size = new System.Drawing.Size(94, 29);
            this.chPython.TabIndex = 15;
            this.chPython.Text = "Python";
            this.chPython.UseVisualStyleBackColor = false;
            // 
            // chnet
            // 
            this.chnet.AutoSize = true;
            this.chnet.BackColor = System.Drawing.Color.Silver;
            this.chnet.Location = new System.Drawing.Point(591, 282);
            this.chnet.Name = "chnet";
            this.chnet.Size = new System.Drawing.Size(70, 29);
            this.chnet.TabIndex = 16;
            this.chnet.Text = ".Net";
            this.chnet.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 439);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1388, 244);
            this.dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1501, 809);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chnet);
            this.Controls.Add(this.chPython);
            this.Controls.Add(this.chJava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdbtnFemale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.rdbtnMale);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "    DataEntry      ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Button btnDisplay;
        private Label lblResult;
        private Label label3;
        private TextBox txtSalary;
        private TextBox txtDesignation;
        private RadioButton rdbtnMale;
        private Label lblGender;
        private RadioButton rdbtnFemale;
        private Label label4;
        private CheckBox chJava;
        private CheckBox chPython;
        private CheckBox chnet;
        private DataGridView dataGridView1;
    }
}