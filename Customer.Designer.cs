namespace WindowsFormsApp1
{
    partial class Customer
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Cars = new System.Windows.Forms.Button();
            this.SlidingPanelToggleButton = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.Controls.Add(this.button4);
            this.SlidingPanel.Controls.Add(this.button3);
            this.SlidingPanel.Controls.Add(this.button2);
            this.SlidingPanel.Controls.Add(this.button1);
            this.SlidingPanel.Controls.Add(this.Cars);
            this.SlidingPanel.Controls.Add(this.SlidingPanelToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(239, 818);
            this.SlidingPanel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources.rto_1635833121;
            this.button3.Location = new System.Drawing.Point(0, 272);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(233, 89);
            this.button3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button3, "Click For Rental  Tab");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.unnamed;
            this.button2.Location = new System.Drawing.Point(13, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 76);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.lower_rent;
            this.button1.Location = new System.Drawing.Point(0, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 89);
            this.button1.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button1, "Click For Rental  Tab");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cars
            // 
            this.Cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cars.Image = global::WindowsFormsApp1.Properties.Resources.car_logo_clip_art_4;
            this.Cars.Location = new System.Drawing.Point(0, 177);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(239, 89);
            this.Cars.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Cars, "Click For Main Tab");
            this.Cars.UseVisualStyleBackColor = true;
            this.Cars.Click += new System.EventHandler(this.Cars_Click);
            // 
            // SlidingPanelToggleButton
            // 
            this.SlidingPanelToggleButton.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.SlidingPanelToggleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanelToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanelToggleButton.Name = "SlidingPanelToggleButton";
            this.SlidingPanelToggleButton.Size = new System.Drawing.Size(239, 89);
            this.SlidingPanelToggleButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.SlidingPanelToggleButton, "Click For Quick Access Tab");
            this.SlidingPanelToggleButton.Click += new System.EventHandler(this.SlidingPanelToggleButton_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.res;
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(244, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(720, 818);
            this.ControlPanel.TabIndex = 2;
            this.ControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ControlPanel_Paint);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "User Help";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 89);
            this.button4.TabIndex = 9;
            this.button4.Text = "LOG OUTT";
            this.toolTip1.SetToolTip(this.button4, "Click For Rental  Tab");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(964, 818);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.SlidingPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Customer";
            this.Text = "Customer";
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanelToggleButton;
        private System.Windows.Forms.Button Cars;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}