﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace BusinessLayer
{
    public static class DataAddition
    {
        public static void AddEmployee (string name, string surname, string role, string dealership, string login, string password)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                int? deal;
                if (String.IsNullOrEmpty(dealership))
                {
                    deal = null;
                }
                else
                {
                    deal = System.Int32.Parse(dealership);
                }

                var emp = new Employee
                {
                    NAME = name,
                    SURNAME = surname,
                    ROLE_ID = BusinessLayer.DataAcquisition.GetRoleID(role),
                    DEALERSHIP_ID = deal,
                    LOGIN = login,
                    PASSWORD = BusinessLayer.Utility.CalculateMD5Hash(password)
                };
                if (emp.ROLE_ID == 0) throw new System.ArgumentException("Role ID not found!");
                database.Employees.InsertOnSubmit(emp);
                database.SubmitChanges();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AddDealership(string address, string city, string zipcode)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();

                var deal = new Dealership()
                {
                    STREET_ADDRESS = address,
                    CITY = city,
                    ZIPCODE = zipcode              
                };

                database.Dealerships.InsertOnSubmit(deal);
                database.SubmitChanges();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddModel(string name, string price)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                price.Replace('.', ',');
                var model = new Model()
                {
                    NAME = name,
                    BASE_PRICE = Decimal.Parse(price)
                };

                database.Models.InsertOnSubmit(model);
                database.SubmitChanges();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddColor(String name)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var color = new DataLayer.Color()
                {
                    NAME = name
                };

                database.Colors.InsertOnSubmit(color);
                database.SubmitChanges();

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void OpenOrder(String CarVIN, int CustomerID, int SellerID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var Order = new DataLayer.Active_Order
                {
                    CAR_VIN = CarVIN,
                    CUSTOMER_ID = CustomerID,
                    EMPLOYEE_ID = SellerID,
                    OPENED_DATE = DateTime.Now.Date,
                    LAST_UPDATE = DateTime.Now,
                    ORDER_STATUS_ID = 1
                };
                database.Active_Orders.InsertOnSubmit(Order);
                database.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AccessoryInstall(int orderID, int accID)
        {
            try
            {
                var database = DataLayer.Utility.GetContext();
                var install = new DataLayer.Accessories_Install_Order
                {
                    ORDER_ID = orderID,
                    ACCESSORY_ID = accID
                };
                database.Accessories_Install_Orders.InsertOnSubmit(install);
                database.SubmitChanges();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(ex.Message + " " + ex.Number, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
