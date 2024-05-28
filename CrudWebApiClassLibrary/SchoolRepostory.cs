using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CrudWebApiClassLibrary;
using Dapper;



namespace CrudWebApiClassLibrary
{
 
    
   public class RegisterRepository
   {
            string connectionstring = "Data Source=DESKTOP-CC47JG8\\SQLEXPRESS;Initial Catalog=CRUD Operation;User Id=sa;Password=Anaiyaan@123";
              
            SqlConnection objj;
            public RegisterRepository()
            {
                objj = new SqlConnection(connectionstring);
            }
            public void SchoolLogin(SchoolEntity obj)
            {
                try
                {
                    var insert = ($"exec SchoolLogin'{obj.SchoolName}',{obj.ContactNo},'{obj.Email}','{obj.Address}',{obj.Pincode}");
                    objj.Open();
                    objj.Execute(insert);
                    objj.Close();
                }
                catch(SqlException)
                {
                    throw;
                }
                catch(Exception)
                {
                    throw;
                }
        }
        public IEnumerable<SchoolEntity> Showall()
        {
            try
            {
                var selectquery = $"select *from SchoolDetails";
                objj.Open();
                var result = objj.Query<SchoolEntity>(selectquery);
                objj.Close();
                return result;


            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EditorUpdate(int SchoolID, long ContactNo, String Email)
        {
            try
            {
                var Update = $" exec EditorUpdate {SchoolID}, {ContactNo},'{Email}'";
                objj.Open();
                objj.Execute(Update);
                objj.Close();

            }
            catch (SqlException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void DeleteDetails(int SchoolID)
            {
                try
                {
                    var Remove = $"exec DeleteDetails {SchoolID}";
                    objj.Open();
                    objj.Execute(Remove);
                    objj.Close();

                }
                catch(SqlException)
                {
                    throw;
                }
                catch(Exception)
                {
                    throw;

                }
            }
        
    }
}


