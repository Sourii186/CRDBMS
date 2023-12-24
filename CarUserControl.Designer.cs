namespace WindowsFormsApp1
{
    partial class CarUserControl
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
            this.components = new System.ComponentModel.Container();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.IDin = new System.Windows.Forms.Label();
            this.makein = new System.Windows.Forms.Label();
            this.namein = new System.Windows.Forms.Label();
            this.costin = new System.Windows.Forms.Label();
            this.safetyin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.YellowGreen;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(8, 392);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(168, 61);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.YellowGreen;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(259, 392);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(168, 61);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.YellowGreen;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(530, 392);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(168, 61);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // IDin
            // 
            this.IDin.BackColor = System.Drawing.Color.LemonChiffon;
            this.IDin.Location = new System.Drawing.Point(87, 471);
            this.IDin.Name = "IDin";
            this.IDin.Size = new System.Drawing.Size(100, 23);
            this.IDin.TabIndex = 4;
            this.IDin.Text = "Car ID";
            this.IDin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IDin.Click += new System.EventHandler(this.IDin_Click);
            // 
            // makein
            // 
            this.makein.BackColor = System.Drawing.Color.LemonChiffon;
            this.makein.Location = new System.Drawing.Point(87, 599);
            this.makein.Name = "makein";
            this.makein.Size = new System.Drawing.Size(111, 25);
            this.makein.TabIndex = 5;
            this.makein.Text = "Make/Model";
            this.makein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.makein.Click += new System.EventHandler(this.makein_Click);
            // 
            // namein
            // 
            this.namein.BackColor = System.Drawing.Color.LemonChiffon;
            this.namein.Location = new System.Drawing.Point(496, 469);
            this.namein.Name = "namein";
            this.namein.Size = new System.Drawing.Size(75, 25);
            this.namein.TabIndex = 6;
            this.namein.Text = "Car Name";
            this.namein.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.namein.Click += new System.EventHandler(this.namein_Click);
            // 
            // costin
            // 
            this.costin.BackColor = System.Drawing.Color.LemonChiffon;
            this.costin.Location = new System.Drawing.Point(496, 599);
            this.costin.Name = "costin";
            this.costin.Size = new System.Drawing.Size(75, 25);
            this.costin.TabIndex = 7;
            this.costin.Text = "Cost";
            this.costin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.costin.Click += new System.EventHandler(this.costin_Click);
            // 
            // safetyin
            // 
            this.safetyin.AutoSize = true;
            this.safetyin.BackColor = System.Drawing.Color.LemonChiffon;
            this.safetyin.Location = new System.Drawing.Point(286, 672);
            this.safetyin.Name = "safetyin";
            this.safetyin.Size = new System.Drawing.Size(87, 16);
            this.safetyin.TabIndex = 8;
            this.safetyin.Text = "Safety Rating";
            this.safetyin.Click += new System.EventHandler(this.safetyin_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 523);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 22);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(467, 523);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 22);
            this.textBox2.TabIndex = 10;
            this.textBox2.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 648);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(143, 22);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(467, 648);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(143, 22);
            this.textBox4.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(259, 720);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(143, 22);
            this.textBox5.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 305);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.YellowGreen;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(530, 14);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 61);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Enter Car ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(238, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 22);
            this.textBox6.TabIndex = 17;
            this.toolTip1.SetToolTip(this.textBox6, "Enter Car ID");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "User Help";
            // 
            // CarUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.safetyin);
            this.Controls.Add(this.costin);
            this.Controls.Add(this.namein);
            this.Controls.Add(this.makein);
            this.Controls.Add(this.IDin);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "CarUserControl";
            this.Size = new System.Drawing.Size(720, 818);
            this.Load += new System.EventHandler(this.CarUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label IDin;
        private System.Windows.Forms.Label makein;
        private System.Windows.Forms.Label namein;
        private System.Windows.Forms.Label costin;
        private System.Windows.Forms.Label safetyin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
