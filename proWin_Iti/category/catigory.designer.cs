namespace proWin_Iti
{
    partial class catigory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNamePro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXderbation = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(467, 30);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add Category";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNamePro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXderbation);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 127);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TEXT FORM";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtNamePro
            // 
            this.TxtNamePro.Location = new System.Drawing.Point(192, 30);
            this.TxtNamePro.Name = "TxtNamePro";
            this.TxtNamePro.Size = new System.Drawing.Size(250, 20);
            this.TxtNamePro.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "category Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Description";
            // 
            // TXderbation
            // 
            this.TXderbation.Location = new System.Drawing.Point(192, 87);
            this.TXderbation.Multiline = true;
            this.TXderbation.Name = "TXderbation";
            this.TXderbation.Size = new System.Drawing.Size(250, 20);
            this.TXderbation.TabIndex = 9;
            this.TXderbation.TextChanged += new System.EventHandler(this.TXderbation_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(500, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 276);
            this.panel1.TabIndex = 18;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(365, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(467, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "Remove category";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(467, 30);
            this.button3.TabIndex = 20;
            this.button3.Text = "Edit Category";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(766, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 33);
            this.button4.TabIndex = 21;
            this.button4.Text = "store";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(633, 308);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 34);
            this.button5.TabIndex = 22;
            this.button5.Text = "Add Product";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(500, 308);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(102, 34);
            this.button6.TabIndex = 23;
            this.button6.Text = "add supplier";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // catigory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(880, 359);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "catigory";
            this.Text = "catigory";
            this.Load += new System.EventHandler(this.catigory_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNamePro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXderbation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}