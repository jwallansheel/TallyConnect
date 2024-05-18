using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Odbc;
using HoltecTallyConn.View_Models;
using System.Web.UI.WebControls;

namespace HoltecTallyConn.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Tally(int Id)
        {
            
                // Create an ODBC connection string.
                string connectionString = "Driver={Tally ODBC Driver64};Server=localhost;Database=10000;User ID=xxxxx;Password=xxxxxx;";
            GridView gridView = new GridView();

            // Create an OdbcConnection object.
            using (OdbcConnection connection = new OdbcConnection(connectionString))
            {
                if (Id == 1)
                {
                    // Create an OdbcCommand object.
                    using (OdbcCommand command = new OdbcCommand("SELECT * FROM employees", connection))
                    {
                        // Create an OdbcDataAdapter object.
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                        {
                            // Open the database connection.
                            connection.Open();

                            // Fill a DataTable object with the data from the Tally database.
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Close the database connection.
                            connection.Close();

                            // Bind the data from the DataTable object to a grid control.
                            gridView.DataSource = dataTable;
                            gridView.DataBind();

                            // Return the grid control to the view.
                            //return View(gridView);
                        }
                    }
                }
                if (Id == 2)
                {
                    // Create an OdbcCommand object.
                    using (OdbcCommand command = new OdbcCommand("SELECT * FROM POStockGroup", connection))
                    {
                        // Create an OdbcDataAdapter object.
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                        {
                            // Open the database connection.
                            connection.Open();

                            // Fill a DataTable object with the data from the Tally database.
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Close the database connection.
                            connection.Close();

                            // Bind the data from the DataTable object to a grid control.
                            gridView.DataSource = dataTable;
                            gridView.DataBind();

                            // Return the grid control to the view.
                            //return View(gridView);
                        }
                    }
                }
                if (Id == 3)
                {
                    // Create an OdbcCommand object.
                    using (OdbcCommand command = new OdbcCommand("SELECT * FROM POStockItem", connection))
                    {
                        // Create an OdbcDataAdapter object.
                        using (OdbcDataAdapter adapter = new OdbcDataAdapter(command))
                        {
                            // Open the database connection.
                            connection.Open();

                            // Fill a DataTable object with the data from the Tally database.
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Close the database connection.
                            connection.Close();

                            // Bind the data from the DataTable object to a grid control.
                            gridView.DataSource = dataTable;
                            gridView.DataBind();

                            // Return the grid control to the view.
                        }
                    }
                }
                
            }
            return View(gridView);

        }



        public ActionResult Tallyemployees()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}