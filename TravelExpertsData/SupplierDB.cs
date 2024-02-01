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
    /// Includes methods save/delete/add data
    /// </summary>
    /// <param name="Name">Joshua Wijaya</param>
    /// <param name="Version">1.0</param>
    /// <param name="Release_Date">February 15</param>

    // creates basically a template for the Product
    // to know what data needs to be in the parameter
    public class SupplierDB
    {
        private TravelExpertsContext db = new();

        // so on the main form
        // the code should be 
        // SupDB.AddSupplier(currentsupplier)
        public void AddSupplier(Supplier supplier)
        {
            try
            {
                
                db.Suppliers.Add(supplier);
                db.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                throw CreateDataAccessException(ex);
            }
            catch (SqlException ex)
            {
                throw CreateDataAccessException(ex);
            }
        }

        public static List<Supplier> GetSupplier()
        {
            List<Supplier> supplier = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                supplier = db.Suppliers.ToList();
            }
            return supplier;
        }

        public Supplier? FindSupplier(string supplierID)
        {
            try
            {
                return db.Suppliers.Find(Convert.ToInt32(supplierID));
            }
            catch (SqlException ex)
            {
                throw CreateDataAccessException(ex);
            }
        }

        public void UpdateSupplier(Supplier supplier)
        {
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.Single().Reload();
                var state = db.Entry(supplier).State;
                throw CreateDataAccessException(state);
            }
            catch (DbUpdateException ex)
            {
                throw CreateDataAccessException(ex);
            }

            catch (SqlException ex)
            {
                throw CreateDataAccessException(ex);
            }
        }
        // main form code should be:
        //public void EditSupplier(Supplier supplier)
        //{
        //    try
        //    {
        //        AddSuppliers AddModifyForm = new();
        //        {
        //             Supplier = currentSupplier
        //        };
        //        DialogResult result = AddModifyForm.ShowDialog();
        //        
        //        if (result == DialogResult.OK) etc set current sup to db sup and SaveSupplier()
        //    }
        //}

        //public void SaveSupplier(Supplier supplier)
        //{
        //    try
        //    {
        //        db.Suppliers.(supplier);
        //    }
        //    catch (DataAccessException ex)
        //    {
        //        // WORK IN PROGResS
        //    }
        //}
        // Database exception, entity state to check if another user has already touched/edit the selected value
        private DataAccessException CreateDataAccessException(
        EntityState state)
        {
            string msg = "";
            if (state == EntityState.Detached)
                msg = "Another user has deleted that record.";
            else
                msg = "Another user has updated that record.\n" +
                "The current database values will be displayed.";

            return new DataAccessException(msg, "Concurrency Error");
        }

        // databaseexception, DBUpdateException, if there are any exception/errors with the data in the database
        private DataAccessException CreateDataAccessException(
        DbUpdateException ex)
        {
            var sqlException = (SqlException)ex.InnerException!;
            return CreateDataAccessException(sqlException);
        }
        private DataAccessException CreateDataAccessException(SqlException ex)
        {
            string msg = "";
            foreach (SqlError error in ex.Errors)
            {
                msg += $"ERROR CODE {error.Number}: {error.Message}\n";
            }

            return new DataAccessException(msg, "Database Error");
        }
    }

}
