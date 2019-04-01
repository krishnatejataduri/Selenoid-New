using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenoid.SelenoidClasses
{
    class ObjectManager
    {
        //Getter Setter Methods
        //Acts as data provider for the application

        public string ScreenName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string LocatorType { get; set; }
        public string LocatorValue { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["orconnstrng"].ConnectionString;

        //SqlConnection conn = new SqlConnection(myconnstrng);

        //Retrieving data from database
        public DataTable getScreenData()
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "select [ScreenName],[ScreenDescription] from tbl_Screens";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable getObjectData(string ScreenName)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "SELECT ObjectName, ObjectType, ObjectDescription, LocatorType, LocatorValue FROM tbl_Objects WHERE ScreenID = (Select ScreenID from tbl_Screens where ScreenName = '"+ ScreenName+"')";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public string getScreenID(string ScreenName)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "Select ScreenID from tbl_Screens where ScreenName = '" + ScreenName + "'";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
           
            return dt.Rows[0]["ScreenID"].ToString();
        }

        public void updateScreenTable(string ScreenName, string ScreenDesc, string ScreenID)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "UPDATE tbl_Screens SET ScreenName = '"+ ScreenName + "', ScreenDescription = '"+ ScreenDesc + "' WHERE ScreenID = "+ int.Parse(ScreenID) ;
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute Update statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            
        }

        public void addScreenTable(string ScreenName, string ScreenDesc)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "INSERT INTO tbl_Screens(ScreenName,ScreenDescription) VALUES('"+ ScreenName + "','"+ ScreenDesc + "')";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute Update statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        public void deleteRowInScreenTable(string ScreenID)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Query to delete the screen
                string sql = "DELETE FROM tbl_Screens WHERE ScreenID = " + int.Parse(ScreenID);
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute delete statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();
                //Deleting all the objects of that screen
                sql = "DELETE FROM tbl_Objects WHERE ScreenID = " + int.Parse(ScreenID);
                cmd = new SqlCommand(sql, conn);
                //Execute delete statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        public void updateObjectTable(string ScreenID, string OldObjectName, string NewObjectName, string ObjectType, string ObjectDesc, string LocatorType, string LocatorValue)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "IF NOT EXISTS(SELECT* FROM tbl_Objects WHERE ScreenID = "+ ScreenID+
                    " AND ObjectName = '"+NewObjectName+"')UPDATE tbl_Objects SET ObjectName = '" 
                    + NewObjectName + "', ObjectType = '" + ObjectType + "', ObjectDescription = '" 
                    + ObjectDesc + "', LocatorType = '" + LocatorType + "', LocatorValue = '" 
                    + LocatorValue + "' WHERE ScreenID = " + int.Parse(ScreenID)+
                    " AND ObjectName = '"+OldObjectName+"'";
                
                //string sql = "UPDATE tbl_Objects SET ObjectName = '" + NewObjectName + "', ObjectType = '" + ObjectType + "', ObjectDescription = '" + ObjectDesc + "', LocatorType = '" + LocatorType + "', LocatorValue = '" + LocatorValue + "' WHERE ScreenID = " + int.Parse(ScreenID) + " AND ObjectName = '" + OldObjectName + "'";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute Update statement (Non query)                              
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        public void addRowInObjectTable(string ScreenID, string ObjectName, string ObjectType, string ObjectDesc, string LocatorType, string LocatorValue)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "INSERT INTO tbl_Objects(ScreenID,ObjectName,ObjectType,ObjectDescription,LocatorType,LocatorValue) VALUES('" + ScreenID + "','" + ObjectName + "','" + ObjectType + "','" + ObjectDesc + "','" + LocatorType + "','" + LocatorValue + "')";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute Update statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

        public void deleteRowInObjectTable(string ScreenID, string ObjectName)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "DELETE FROM tbl_Objects WHERE ScreenID = " + int.Parse(ScreenID) + "AND ObjectName = '" + ObjectName + "'";
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute Update statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

        }

    }
}
