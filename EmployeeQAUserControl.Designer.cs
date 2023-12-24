namespace WindowsFormsApp1
{
    partial class EmployeeQAUserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(717, 305);
            this.dataGridView1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter Car ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.YellowGreen;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(509, 382);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(168, 61);
            this.Search.TabIndex = 21;
            this.Search.Text = "Search";
            this.toolTip1.SetToolTip(this.Search, "Modification Histroy");
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(231, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 22);
            this.textBox6.TabIndex = 20;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.YellowGreen;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(252, 708);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(168, 61);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(509, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 61);
            this.button1.TabIndex = 26;
            this.button1.Text = "Search";
            this.toolTip1.SetToolTip(this.button1, "Service Histroy");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 603);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Enter Car ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipTitle = "User Help";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // EmployeeQAUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeQAUserControl";
            this.Size = new System.Drawing.Size(722, 818);
            this.Load += new System.EventHandler(this.EmployeeQAUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
