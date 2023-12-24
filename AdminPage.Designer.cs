namespace WindowsFormsApp1
{
    partial class AdminPage
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.QuickAccess = new System.Windows.Forms.Button();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Retail = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.RTOReg = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.Button();
            this.Rent = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuickAccess
            // 
            this.QuickAccess.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.QuickAccess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuickAccess.Location = new System.Drawing.Point(0, 0);
            this.QuickAccess.Name = "QuickAccess";
            this.QuickAccess.Size = new System.Drawing.Size(224, 92);
            this.QuickAccess.TabIndex = 7;
            this.toolTip1.SetToolTip(this.QuickAccess, "Click For Quick Access Tab");
            this.QuickAccess.Click += new System.EventHandler(this.QuickAccess_Click);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.Controls.Add(this.button1);
            this.SlidingPanel.Controls.Add(this.Retail);
            this.SlidingPanel.Controls.Add(this.Cars);
            this.SlidingPanel.Controls.Add(this.RTOReg);
            this.SlidingPanel.Controls.Add(this.Service);
            this.SlidingPanel.Controls.Add(this.Rent);
            this.SlidingPanel.Controls.Add(this.QuickAccess);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(223, 818);
            this.SlidingPanel.TabIndex = 0;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SlidingPanel_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.unnamed;
            this.button1.Location = new System.Drawing.Point(4, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 76);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Click For Customer Information Tab");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Retail
            // 
            this.Retail.BackColor = System.Drawing.Color.Transparent;
            this.Retail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retail.Image = global::WindowsFormsApp1.Properties.Resources.digital_assurance_for_retail_1;
            this.Retail.Location = new System.Drawing.Point(0, 498);
            this.Retail.Name = "Retail";
            this.Retail.Size = new System.Drawing.Size(220, 76);
            this.Retail.TabIndex = 5;
            this.toolTip1.SetToolTip(this.Retail, "Click for Retail Tab");
            this.Retail.UseVisualStyleBackColor = false;
            this.Retail.Click += new System.EventHandler(this.Retail_Click);
            // 
            // Cars
            // 
            this.Cars.BackColor = System.Drawing.Color.Transparent;
            this.Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cars.Image = global::WindowsFormsApp1.Properties.Resources.car_logo_clip_art_4;
            this.Cars.Location = new System.Drawing.Point(3, 85);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(221, 79);
            this.Cars.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Cars, "Click For Main Tab");
            this.Cars.UseVisualStyleBackColor = false;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // RTOReg
            // 
            this.RTOReg.BackColor = System.Drawing.Color.Transparent;
            this.RTOReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RTOReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTOReg.Image = global::WindowsFormsApp1.Properties.Resources.rto_1635833121;
            this.RTOReg.Location = new System.Drawing.Point(0, 416);
            this.RTOReg.Name = "RTOReg";
            this.RTOReg.Size = new System.Drawing.Size(220, 76);
            this.RTOReg.TabIndex = 4;
            this.toolTip1.SetToolTip(this.RTOReg, "Click For RTO Details Tab");
            this.RTOReg.UseVisualStyleBackColor = false;
            this.RTOReg.Click += new System.EventHandler(this.RTOReg_Click);
            // 
            // Service
            // 
            this.Service.BackColor = System.Drawing.Color.Transparent;
            this.Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.Image = global::WindowsFormsApp1.Properties.Resources.service;
            this.Service.Location = new System.Drawing.Point(3, 334);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(220, 76);
            this.Service.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Service, "Click For Service Record Tab");
            this.Service.UseVisualStyleBackColor = false;
            this.Service.Click += new System.EventHandler(this.Service_Click);
            // 
            // Rent
            // 
            this.Rent.BackColor = System.Drawing.Color.Transparent;
            this.Rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rent.Image = global::WindowsFormsApp1.Properties.Resources.lower_rent;
            this.Rent.Location = new System.Drawing.Point(4, 252);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(220, 76);
            this.Rent.TabIndex = 2;
            this.toolTip1.SetToolTip(this.Rent, "Click For Rental Tab");
            this.Rent.UseVisualStyleBackColor = false;
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Dbms2;
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(229, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(722, 818);
            this.ContentPanel.TabIndex = 1;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "User Help";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(951, 818);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ContentPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button QuickAccess;
        private System.Windows.Forms.Button Rent;
        private System.Windows.Forms.Button Service;
        private System.Windows.Forms.Button RTOReg;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Retail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}