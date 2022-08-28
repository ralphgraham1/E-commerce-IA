using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory_Management
{
    public class Category
    {
        public Category()
        {

        }

        public void InsertCategory(string name, string description)
        {
            //connect my code to the db and insert the category into the db
            try
            {
                string cs = "server=localhost;uid=root;pwd=;database='shoprite db'";
                MySqlConnection con = new MySqlConnection(cs);
                con.Open();


                //Remember!!!: change the sqlStatement to insert a product category
                string sqlStatement = $"INSERT INTO category('category name','category description') VALUES ('{name}','{description}')";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("You have inserted the category to the db");

            }
            catch (Exception e)
            {
                Console.WriteLine($"You encountered an error {e.StackTrace}");
            }
        }

        public void UpdateCategory(string id, string name, string description)
        {
            //establish db connection, update the category details

            try
            {

                string cs = "server=localhost;uid=root;pwd=;database='shoprite db'";

                MySqlConnection con = new MySqlConnection(cs);
                con.Open();

                // change the sqlStatement to update the category details
                string sqlStatement = $"UPDATE `category` SET `category name` = '{name}','category description'='{description}' WHERE `category`.`category id` = {id}";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Category updated");

            }
            catch (Exception e)
            {
                Console.WriteLine($"You encountered an error{e.StackTrace}");
            }
        }

        public void DeleteCategory(string id)
        {
            //Delete category

            try
            {

                string cs = "server=localhost;uid=root;pwd=;database='shoprite db";

                MySqlConnection con = new MySqlConnection(cs);
                con.Open();

                //TODO: change the sqlStatement to delete the product category
                string sqlStatement = $"DELETE FROM category WHERE `category`.`category id` = {id}";
                MySqlCommand cmd = new MySqlCommand(sqlStatement, con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Category Deleted");

            }
            catch (Exception e)
            {
                Console.WriteLine($"You encountered an error {e.StackTrace}");
            }
        }
    }
}
