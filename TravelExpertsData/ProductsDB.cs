using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// Static Class For Database methods
    /// Has a Get all Products Method 
    /// Edit Products Method
    /// Add Products Method
    /// </summary>
    public static class ProductsDB
    {
        /// <summary>
        /// Method for gettin data from products table
        /// </summary>
        /// <returns> a List of products from the databse</returns>
        public static List<Product> GetProducts()
        {
            List<Product> products = null!; 

            try
            {
                using (TravelExpertsContext db = new())
                {
                    products = db.Products.ToList();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uncaught error {ex.Message}");
            }

            return products;
        }public static Product GetProductByID(int id)
        {
            Product product = null!; 

            try
            {
                using (TravelExpertsContext db = new())
                {
                    product = db.Products.Find(id)!;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uncaught error {ex.Message}");
            }

            return product;
        }
        /// <summary>
        /// Method that Adds a new product
        /// </summary>
        /// <param name="newProduct">Takes in a paramter of type product</param>
        public static void AddProduct(Product newProduct) 
        {
            try
            {
                using(TravelExpertsContext db = new())
                {
                    db.Products.Add(newProduct);
                    db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (DbUpdateException ex) 
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uncaught error {ex.Message}");
            }
        }
        /// <summary>
        /// Method to edit an existing product
        /// </summary>
        /// <param name="modifiedProduct">Takes in a product of type Product to modify</param>
        public static void EditProduct(Product modifiedProduct)
        {
            try
            {
                using(TravelExpertsContext db = new())
                {
                    db.Products.Update(modifiedProduct);
                    db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (DbUpdateException ex) 
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uncaught error {ex.Message}");
            }
        }
        public static void DeleteProduct(Product modifiedProduct)
        {
            try
            {
                using(TravelExpertsContext db = new())
                {
                    db.Products.Remove(modifiedProduct);
                    db.SaveChanges();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (DbUpdateException ex) 
            {
                Console.WriteLine($"Database Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uncaught error {ex.Message}");
            }
        }
        
    }
}
