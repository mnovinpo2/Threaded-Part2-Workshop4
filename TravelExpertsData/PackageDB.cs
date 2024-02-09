using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
	public static class PackageDB
	{
		public static List<Package> GetPackages()
		{
			List<Package> packages = null!;
			try
			{
				using (TravelExpertsContext db = new())
				{
					packages = db.Packages.ToList();
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

			return packages;
		}
	}
}
