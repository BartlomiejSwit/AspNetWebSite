using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace AspNetWebSite
{
    public partial class Offers : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void Bt1_Click(object sender, EventArgs e)
        {

        }

        protected void Bt2_Click(object sender, EventArgs e)
        {

        }

        protected void Bt3_Click(object sender, EventArgs e)
        {

        }

        protected void Bt4_Click(object sender, EventArgs e)
        {

        }

        public class GridView
        {
            public static string ConnectionString()
            {
                string cstring = string.Empty;
                cstring = ConfigurationManager.ConnectionStrings["myConnectionString"].ToString();
                return cstring;
            }
            public DataTable GetData()
            {
                SqlConnection connection = null;
                SqlCommand command = null;
                SqlDataAdapter adapter = null;
                DataTable dataTable = null;

                using(connection = new SqlConnection(ConnectionString()))
                {
                    command = connection.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TakeData";
                    adapter = new SqlDataAdapter(command);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
                return dataTable;
            }

        }

        GridView obj_GridView = new GridView();
         public void BindData()
        {
            DataTable dataTable = null;
            dataTable = obj_GridView.GetData();
            if (dataTable.Rows.Count>0)
            {
                Tabela.DataSource = dataTable;
                Tabela.DataBind();

            }
            else
            {
                dataTable.Rows.Add(dataTable.NewRow());
                Tabela.DataSource = dataTable;
                Tabela.DataBind();
                Tabela.Rows[0].Cells.Clear();
                Tabela.Rows[0].Cells.Add(new TableCell());
                Tabela.Rows[0].Cells[0].ColumnSpan = Tabela.Columns.Count;
                Tabela.Rows[0].Cells[0].Text = "Brak danych.....!";
                Tabela.Rows[0].Cells[0].HorizontalAlign = HorizontalAlign.Center;

            }


        }

    }
}