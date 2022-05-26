namespace proWin_Iti.admin
{
    partial class Setting_employee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 481);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "list user";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(424, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.txtpass);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 481);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "details user";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "state";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "pass";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "user name";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.ForeColor = System.Drawing.Color.Brown;
            this.button4.Location = new System.Drawing.Point(295, 426);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 28);
            this.button4.TabIndex = 11;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.ForeColor = System.Drawing.Color.Brown;
            this.button3.Location = new System.Drawing.Point(150, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(6, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add user";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(184, 381);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "manager";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(41, 381);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "employee";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(41, 336);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(240, 26);
            this.txtaddress.TabIndex = 4;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(41, 263);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(240, 26);
            this.txtpass.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(41, 196);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 26);
            this.txtemail.TabIndex = 2;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(41, 131);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(240, 26);
            this.txtphone.TabIndex = 1;
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(41, 75);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(240, 26);
            this.txtname.TabIndex = 0;
            // 
            // Setting_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(914, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Setting_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.adduser_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtname;
    }
}