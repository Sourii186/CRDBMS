namespace WindowsFormsApp1
{
    partial class CustomerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costin = new System.Windows.Forms.Label();
            this.namein = new System.Windows.Forms.Label();
            this.makein = new System.Windows.Forms.Label();
            this.IDin = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 306);
            this.dataGridView1.TabIndex = 15;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.YellowGreen;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(519, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 61);
            this.Search.TabIndex = 20;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.YellowGreen;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(540, 386);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(168, 61);
            this.Clear.TabIndex = 19;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.YellowGreen;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(263, 386);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(168, 61);
            this.Delete.TabIndex = 17;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.YellowGreen;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(18, 386);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(168, 61);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(243, 34);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 22);
            this.textBox6.TabIndex = 26;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(477, 656);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 656);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 531);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 531);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 32;
            this.label1.Text = "Enter Car ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // costin
            // 
            this.costin.BackColor = System.Drawing.Color.LemonChiffon;
            this.costin.Location = new System.Drawing.Point(505, 617);
            this.costin.Name = "costin";
            this.costin.Size = new System.Drawing.Size(75, 25);
            this.costin.TabIndex = 30;
            this.costin.Text = "Address";
            this.costin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namein
            // 
            this.namein.BackColor = System.Drawing.Color.LemonChiffon;
            this.namein.Location = new System.Drawing.Point(483, 487);
            this.namein.Name = "namein";
            this.namein.Size = new System.Drawing.Size(120, 25);
            this.namein.TabIndex = 29;
            this.namein.Text = "Customer ID";
            this.namein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makein
            // 
            this.makein.BackColor = System.Drawing.Color.LemonChiffon;
            this.makein.Location = new System.Drawing.Point(80, 617);
            this.makein.Name = "makein";
            this.makein.Size = new System.Drawing.Size(130, 25);
            this.makein.TabIndex = 28;
            this.makein.Text = "Customer Name";
            this.makein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDin
            // 
            this.IDin.BackColor = System.Drawing.Color.LemonChiffon;
            this.IDin.Location = new System.Drawing.Point(96, 489);
            this.IDin.Name = "IDin";
            this.IDin.Size = new System.Drawing.Size(100, 23);
            this.IDin.TabIndex = 27;
            this.IDin.Text = "Car ID";
            this.IDin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(263, 738);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(156, 22);
            this.textBox5.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Location = new System.Drawing.Point(276, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mode OF Payment";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costin);
            this.Controls.Add(this.namein);
            this.Controls.Add(this.makein);
            this.Controls.Add(this.IDin);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(722, 818);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label costin;
        private System.Windows.Forms.Label namein;
        private System.Windows.Forms.Label makein;
        private System.Windows.Forms.Label IDin;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
    }
}
