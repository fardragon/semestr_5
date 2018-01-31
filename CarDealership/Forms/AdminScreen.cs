﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace CarDealership.Forms
{
    public partial class AdminScreen : ScreenForm
    {
        public AdminScreen(int employeeID)
        {
            InitializeComponent();
            this.EmployeeID = employeeID;
            this.NextScreen = Screens.Exit;
            this.roleSelector1.AllowNull();
            this.carsView1.SetShowOrderedCars(true);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            BusinessLayer.DataAcquisition.DEBUG_RESET();       
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.NextScreen = Screens.LoginScreen;
            this.Close();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    this.employeesView1.View();
                    this.textBoxNameEmp.Clear();
                    this.textBoxSurnameEmp.Clear();
                    this.roleSelector1.Initialize();
                    this.roleSelector1.AllowNull();
                    this.roleSelector1.SelectedIndex = 0;
                    this.dealershipSelector1.Initialize();
                    this.dealershipSelector1.SelectedIndex = 0;                 
                    break;
                case 2:
                    this.dealershipsView1.View();
                    break;
                case 3:
                    this.modelsView1.View();
                    break;
                case 4:
                    this.colorsView.View();
                    break;
                case 5:
                    this.carsView1.View();
                    break;
                case 6:
                    this.customersView.View(null,null);
                    break;
                default:
                    break;
            }
        }

        private void buttonEDIT_Click(object sender, EventArgs e)
        {
            var id = this.employeesView1.CurrentID();
            var dialog = new EmployeeEdit(id);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesView1.View();
        }

        private void buttonDelEmp_Click(object sender, EventArgs e)
        {
            var id = this.employeesView1.CurrentID();
            if (id == this.EmployeeID)
            {
                System.Windows.Forms.MessageBox.Show("Cannot delete yourself");
                System.Media.SystemSounds.Asterisk.Play();
                return;
            }
            BusinessLayer.DataDeletion.DeleteEmployee(id);
            this.employeesView1.View();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            var dialog = new EmployeeAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.employeesView1.View();
        }

        private void buttonFilerEmp_Click(object sender, EventArgs e)
        {
            this.employeesView1.Filter(this.textBoxNameEmp.Text, this.textBoxSurnameEmp.Text, this.dealershipSelector1.SelectedItem.ToString(), this.roleSelector1.SelectedItem.ToString());
        }

        private void buttonResetEmp_Click(object sender, EventArgs e)
        {
            this.textBoxNameEmp.Clear();
            this.textBoxSurnameEmp.Clear();
            this.roleSelector1.SelectedIndex = 0;
            this.dealershipSelector1.SelectedIndex = 0;
            this.employeesView1.View();
        }

        private void buttonAddDeal_Click(object sender, EventArgs e)
        {
            var dialog = new DealershipAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.dealershipsView1.View();

        }

        private void buttonEditDeal_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.DealershipEdit(this.dealershipsView1.CurrentID());
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.dealershipsView1.View();
        }

        private void ChPwdButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDealership.Forms.PasswordChange(this.EmployeeID);
            dialog.ShowDialog(this);
        }

        private void ModelAddButton_Click(object sender, EventArgs e)
        {
            var dialog = new Forms.ModelAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes)
            {
                this.modelsView1.View();
            }
        }

        private void AddClrButton_Click(object sender, EventArgs e)
        {
            var dialog = new CarDealership.Forms.ColorAdd();
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.Yes) this.colorsView.View();
        }
    }
}