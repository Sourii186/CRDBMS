namespace WindowsFormsApp1
{
    partial class RTOUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.safetyin = new System.Windows.Forms.Label();
            this.costin = new System.Windows.Forms.Label();
            this.namein = new System.Windows.Forms.Label();
            this.makein = new System.Windows.Forms.Label();
            this.IDin = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Car Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // safetyin
            // 
            this.safetyin.BackColor = System.Drawing.Color.LemonChiffon;
            this.safetyin.Location = new System.Drawing.Point(306, 703);
            this.safetyin.Name = "safetyin";
            this.safetyin.Size = new System.Drawing.Size(133, 25);
            this.safetyin.TabIndex = 27;
            this.safetyin.Text = "Registration Cost";
            this.safetyin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costin
            // 
            this.costin.BackColor = System.Drawing.Color.LemonChiffon;
            this.costin.Location = new System.Drawing.Point(501, 633);
            this.costin.Name = "costin";
            this.costin.Size = new System.Drawing.Size(153, 25);
            this.costin.TabIndex = 26;
            this.costin.Text = "Car Number Alloted";
            this.costin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namein
            // 
            this.namein.BackColor = System.Drawing.Color.LemonChiffon;
            this.namein.Location = new System.Drawing.Point(501, 504);
            this.namein.Name = "namein";
            this.namein.Size = new System.Drawing.Size(132, 25);
            this.namein.TabIndex = 25;
            this.namein.Text = "Registration Agent";
            this.namein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // makein
            // 
            this.makein.BackColor = System.Drawing.Color.LemonChiffon;
            this.makein.Location = new System.Drawing.Point(129, 633);
            this.makein.Name = "makein";
            this.makein.Size = new System.Drawing.Size(111, 25);
            this.makein.TabIndex = 24;
            this.makein.Text = "Validity";
            this.makein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDin
            // 
            this.IDin.BackColor = System.Drawing.Color.LemonChiffon;
            this.IDin.Location = new System.Drawing.Point(129, 505);
            this.IDin.Name = "IDin";
            this.IDin.Size = new System.Drawing.Size(100, 23);
            this.IDin.TabIndex = 23;
            this.IDin.Text = "Car ID";
            this.IDin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(296, 740);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 22);
            this.textBox5.TabIndex = 35;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(504, 668);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 34;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(504, 543);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 543);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 31;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(251, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 22);
            this.textBox6.TabIndex = 30;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.YellowGreen;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(516, 15);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 61);
            this.Search.TabIndex = 41;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.YellowGreen;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(547, 401);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(168, 61);
            this.Clear.TabIndex = 40;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.YellowGreen;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(25, 401);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(168, 61);
            this.Add.TabIndex = 37;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 299);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(110, 683);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(143, 22);
            this.textBox7.TabIndex = 42;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.YellowGreen;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(280, 401);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(168, 61);
            this.Delete.TabIndex = 38;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // RTOUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.safetyin);
            this.Controls.Add(this.costin);
            this.Controls.Add(this.namein);
            this.Controls.Add(this.makein);
            this.Controls.Add(this.IDin);
            this.Name = "RTOUserControl";
            this.Size = new System.Drawing.Size(722, 818);
            this.Load += new System.EventHandler(this.RTOUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label safetyin;
        private System.Windows.Forms.Label costin;
        private System.Windows.Forms.Label namein;
        private System.Windows.Forms.Label makein;
        private System.Windows.Forms.Label IDin;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Delete;
    }
}
