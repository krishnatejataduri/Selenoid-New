
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
    class KeyTaskManager
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["orconnstrng"].ConnectionString;
        public DataTable getKeyTaskData()
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "SELECT KEY_TSK_NAME ,KEY_TSK_DESCR FROM tbl_Keytask";
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

        //Method to get KeyTask ID using KeyTask Name
        public string getKeyTaskID(string KeytaskName)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "Select KEY_TSK_ID from tbl_Keytask where KEY_TSK_NAME = '" + KeytaskName + "'";
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

            return dt.Rows[0]["KEY_TSK_ID"].ToString();
        }


        //Method to update the key task row in database
        public void updateKeyTaskTable(string KeyTaskName, string KeyTaskDesc, string KeyTaskID)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "UPDATE tbl_Keytask SET KEY_TSK_NAME = '" + KeyTaskName + "', KEY_TSK_DESCR = '" + KeyTaskDesc + "' WHERE KEY_TSK_ID = " + int.Parse(KeyTaskID);
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

        public void addKeyTask(string KeytaskName, string KeytaskDesc)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Writing SQL Query
                string sql = "INSERT INTO tbl_Keytask(KEY_TSK_NAME,KEY_TSK_DESCR) VALUES('" + KeytaskName + "','" + KeytaskDesc + "')";
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

        public void deleteKeyTask(string KeytaskID)
        {
            //Connect to database
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Query to delete the keytask
                string sql = "DELETE FROM tbl_Keytask WHERE KEY_TSK_ID = " + int.Parse(KeytaskID);
                //Create command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Execute delete statement (Non query)                              
                conn.Open();
                cmd.ExecuteNonQuery();
                //Deleting all the steps of that keytask
 //Update this  sql = "DELETE FROM tbl_Objects WHERE ScreenID = " + int.Parse(ScreenID);
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

    }
}
