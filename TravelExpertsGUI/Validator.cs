using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelExpertsData;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelExpertsGUI
{
    /// <summary>
    /// a repository of validation methods
    /// </summary>
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsValidID(System.Windows.Forms.TextBox textBox) // FOR SUPPLIERS
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = "";
                if (context.Suppliers.Any(s => s.SupplierId == int.Parse(textBox.Text)))
                {
                    msg = $"{textBox.Tag} is already taken.{LineEnd}";
                }
                return msg;


            }
            
        }

        public static string IsExistingProductID(System.Windows.Forms.TextBox textBox)
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = $"{textBox.Tag} doesn't exist.{LineEnd}";
                if (context.Products.Any(s => s.ProductId == int.Parse(textBox.Text)))
                {
                    msg = "";
                }
                return msg;
            }

        }

        public static string IsExistingSupplierID(System.Windows.Forms.TextBox textBox)
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = $"{textBox.Tag} doesn't exist.{LineEnd}";
                if (context.Suppliers.Any(s => s.SupplierId == int.Parse(textBox.Text)))
                {
                    msg = "";
                }
                return msg;
            }

        }

        public static string IsValidProductID(System.Windows.Forms.TextBox textBox) // FOR PRODUCTS
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = "";
                if (context.Products.Any(s => s.ProductId == int.Parse(textBox.Text))) // it already exists
                {
                    msg = $"{textBox.Tag} is already taken.{LineEnd}";
                }
                return msg;
            }

        }

        public static string IsValidProdSupID(System.Windows.Forms.TextBox textBox) // FOR PRODUCT SUPPLIER ID
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = "";
                if (context.ProductsSuppliers.Any(s => s.ProductSupplierId == int.Parse(textBox.Text)))
                {
                    msg = $"{textBox.Tag} is already taken.{LineEnd}";
                }
                return msg;
            }

        }

        public static string IsValidPackageID(System.Windows.Forms.TextBox textBox) // FOR PACKAGE ID
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = "";

                if (context.Packages.Any(s => s.PackageId == int.Parse(textBox.Text)))
                {
                    msg = $"{textBox.Tag} is already taken.{LineEnd}";
                }
                return msg;
            }

        }

        public static string IsValidSupplierID(System.Windows.Forms.TextBox textBox) // FOR SUPPLIERS
        {
            using (var context = new TravelExpertsContext())
            {
                string msg = "";
                if (context.Suppliers.Any(s => s.SupplierId == int.Parse(textBox.Text)))
                {
                    msg = $"{textBox.Tag} is already taken.{LineEnd}";
                }
                return msg;

            }

        }

        public static string IsValidDate(DateTimePicker dateTimePicker, DateTimePicker dateTimerPicker2)
        {
            string msg = "";
            if (dateTimePicker.Value > dateTimerPicker2.Value ) // start date before end date
            {
                msg = "Start date can't be before end date";
            }
            else if (dateTimePicker.Value == dateTimerPicker2.Value) // start date the same as end date
            {
                msg = "Start date can't be the same as end date";
            }
            return msg;
        }
        public static string IsPresent(System.Windows.Forms.TextBox textBox)
        {
            string msg = "";
            if(textBox.Text == "")
            {
                msg = $"{textBox.Tag} is a required field.{LineEnd}";
            }
            return msg;
        }
       
        /// <summary>
        /// tests if a text box contains int that is >= 0
        /// </summary>
        /// <param name="textBox">text box to check</param>
        /// <returns>true is valid and false if not</returns>
        public static string IsNonNegativeInt(System.Windows.Forms.TextBox textBox)
        {
            string msg = "";
            int value; // parsed value if successful
            if(!Int32.TryParse(textBox.Text, out value)) // not an int
            {
                msg = $"{textBox.Tag} must be a valid integer value.{LineEnd}";
            }
            else if (value < 0) // an int, but negative
            {
                msg = $"{textBox.Tag} must be a positive integer.{LineEnd}";
            }
            return msg;
        }


    } // class
} // namespace

