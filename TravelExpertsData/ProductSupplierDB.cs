using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
	public static class ProductSupplierDB
	{
		public static List<ProductsSupplier> GetProductSuppliers()
		{
			List<ProductsSupplier> prodSup = null!;

			try
			{
				using (TravelExpertsContext db = new())
				{
					prodSup = db.ProductsSuppliers.ToList();
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

			return prodSup;
		}

	}
}