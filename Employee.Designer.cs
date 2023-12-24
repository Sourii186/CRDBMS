namespace WindowsFormsApp1
{
    partial class Employee
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
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.Retail = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.Button();
            this.CarMod = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.SlidingPanelToggleButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.Controls.Add(this.Retail);
            this.SlidingPanel.Controls.Add(this.Service);
            this.SlidingPanel.Controls.Add(this.CarMod);
            this.SlidingPanel.Controls.Add(this.Cars);
            this.SlidingPanel.Controls.Add(this.SlidingPanelToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(293, 818);
            this.SlidingPanel.TabIndex = 1;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.car_service2;
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(279, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(722, 818);
            this.ControlPanel.TabIndex = 2;
            // 
            // Retail
            // 
            this.Retail.BackColor = System.Drawing.Color.Transparent;
            this.Retail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Retail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retail.Image = global::WindowsFormsApp1.Properties.Resources.digital_assurance_for_retail_1;
            this.Retail.Location = new System.Drawing.Point(0, 419);
            this.Retail.Name = "Retail";
            this.Retail.Size = new System.Drawing.Size(277, 98);
            this.Retail.TabIndex = 4;
            this.toolTip1.SetToolTip(this.Retail, "Click For Retail Parts Tab");
            this.Retail.UseVisualStyleBackColor = false;
            this.Retail.Click += new System.EventHandler(this.Retail_Click);
            // 
            // Service
            // 
            this.Service.BackColor = System.Drawing.Color.Transparent;
            this.Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Service.Image = global::WindowsFormsApp1.Properties.Resources.service;
            this.Service.Location = new System.Drawing.Point(3, 211);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(274, 98);
            this.Service.TabIndex = 3;
            this.toolTip1.SetToolTip(this.Service, "Click For Service Record Tab");
            this.Service.UseVisualStyleBackColor = false;
            this.Service.Click += new System.EventHandler(this.Service_Click);
            // 
            // CarMod
            // 
            this.CarMod.BackColor = System.Drawing.Color.Transparent;
            this.CarMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarMod.Image = global::WindowsFormsApp1.Properties.Resources.modi;
            this.CarMod.Location = new System.Drawing.Point(3, 315);
            this.CarMod.Name = "CarMod";
            this.CarMod.Size = new System.Drawing.Size(274, 98);
            this.CarMod.TabIndex = 2;
            this.toolTip1.SetToolTip(this.CarMod, "Click For Car Modification Tab");
            this.CarMod.UseVisualStyleBackColor = false;
            this.CarMod.Click += new System.EventHandler(this.CarMod_Click);
            // 
            // Cars
            // 
            this.Cars.BackColor = System.Drawing.Color.Transparent;
            this.Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cars.Image = global::WindowsFormsApp1.Properties.Resources.car_logo_clip_art_4;
            this.Cars.Location = new System.Drawing.Point(0, 107);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(277, 98);
            this.Cars.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Cars, "Click For Main Tab");
            this.Cars.UseVisualStyleBackColor = false;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // SlidingPanelToggleButton
            // 
            this.SlidingPanelToggleButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.SlidingPanelToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanelToggleButton.Name = "SlidingPanelToggleButton";
            this.SlidingPanelToggleButton.Size = new System.Drawing.Size(277, 111);
            this.SlidingPanelToggleButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.SlidingPanelToggleButton, "Click For Quick Access Tab");
            this.SlidingPanelToggleButton.Click += new System.EventHandler(this.SlidingPanelToggleButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 5;
            this.toolTip1.AutoPopDelay = 50000;
            this.toolTip1.InitialDelay = 5;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 1;
            this.toolTip1.ToolTipTitle = "User Help";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1001, 818);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.SlidingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanelToggleButton;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Button Retail;
        private System.Windows.Forms.Button Service;
        private System.Windows.Forms.Button CarMod;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}