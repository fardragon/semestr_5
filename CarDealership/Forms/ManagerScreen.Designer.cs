﻿namespace CarDealership.Forms
{
    partial class ManagerScreen
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.employeesManagerView1 = new CarDealership.Controls.EmployeesManagerView();
            this.CarsTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.carsView1 = new CarDealership.Controls.CarsView();
            this.CarDetailsButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CarsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.HomeTab);
            this.tabControl1.Controls.Add(this.EmployeesTab);
            this.tabControl1.Controls.Add(this.CarsTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 451);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // HomeTab
            // 
            this.HomeTab.Location = new System.Drawing.Point(4, 22);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(823, 425);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.splitContainer1);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 22);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeesTab.Size = new System.Drawing.Size(823, 425);
            this.EmployeesTab.TabIndex = 1;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel2.Controls.Add(this.employeesManagerView1);
            this.splitContainer1.Size = new System.Drawing.Size(817, 419);
            this.splitContainer1.SplitterDistance = 170;
            this.splitContainer1.TabIndex = 0;
            // 
            // employeesManagerView1
            // 
            this.employeesManagerView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeesManagerView1.Location = new System.Drawing.Point(0, 0);
            this.employeesManagerView1.Name = "employeesManagerView1";
            this.employeesManagerView1.Size = new System.Drawing.Size(643, 419);
            this.employeesManagerView1.TabIndex = 0;
            // 
            // CarsTab
            // 
            this.CarsTab.Controls.Add(this.splitContainer2);
            this.CarsTab.Location = new System.Drawing.Point(4, 22);
            this.CarsTab.Name = "CarsTab";
            this.CarsTab.Size = new System.Drawing.Size(823, 425);
            this.CarsTab.TabIndex = 2;
            this.CarsTab.Text = "Cars";
            this.CarsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer2.Panel1.Controls.Add(this.CarDetailsButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.carsView1);
            this.splitContainer2.Size = new System.Drawing.Size(823, 425);
            this.splitContainer2.SplitterDistance = 207;
            this.splitContainer2.TabIndex = 0;
            // 
            // carsView1
            // 
            this.carsView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carsView1.Location = new System.Drawing.Point(0, 0);
            this.carsView1.Name = "carsView1";
            this.carsView1.Size = new System.Drawing.Size(612, 425);
            this.carsView1.TabIndex = 0;
            // 
            // CarDetailsButton
            // 
            this.CarDetailsButton.Location = new System.Drawing.Point(52, 156);
            this.CarDetailsButton.Name = "CarDetailsButton";
            this.CarDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.CarDetailsButton.TabIndex = 0;
            this.CarDetailsButton.Text = "Details...";
            this.CarDetailsButton.UseVisualStyleBackColor = true;
            this.CarDetailsButton.Click += new System.EventHandler(this.CarDetailsButton_Click);
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 451);
            this.Controls.Add(this.tabControl1);
            this.Name = "ManagerScreen";
            this.Text = "ManagerScreencs";
            this.tabControl1.ResumeLayout(false);
            this.EmployeesTab.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CarsTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Controls.EmployeesManagerView employeesManagerView1;
        private System.Windows.Forms.TabPage CarsTab;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Controls.CarsView carsView1;
        private System.Windows.Forms.Button CarDetailsButton;
    }
}