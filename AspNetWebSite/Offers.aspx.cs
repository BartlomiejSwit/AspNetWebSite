using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BenchmarkDotNet.Code;
using static AspNetWebSite.Offers;


namespace AspNetWebSite
{
    public partial class Offers : Page
    {
        public int rowIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        protected void Bt1_Click(object sender, EventArgs e)
        {
            BindData();
        }

        protected void Bt2_Click(object sender, EventArgs e)
        {
            AddData();
        }

        protected void Bt3_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        protected void Bt4_Click(object sender, EventArgs e)
        {
            AlterData();
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

                using (connection = new SqlConnection(ConnectionString()))
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
            public void InsertData(string param1, string param2, string param3, string param4)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("InsertData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@param1", param1);
                        command.Parameters.AddWithValue("@param2", param2);
                        command.Parameters.AddWithValue("@param3", param3);
                        command.Parameters.AddWithValue("@param4", param4);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            public void DeleteData(int id)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("DeleteData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            public void EditData(int id, string param1, string param2, string param3, string param4)
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand("EditData", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@param1", param1);
                        command.Parameters.AddWithValue("@param2", param2);
                        command.Parameters.AddWithValue("@param3", param3);
                        command.Parameters.AddWithValue("@param4", param4);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }

        }

        GridView obj_GridView = new GridView();
        public void BindData()
        {
            DataTable dataTable = null;
            dataTable = obj_GridView.GetData();
            if (dataTable.Rows.Count > 0)
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
        public void AddData()
        {
            string name = txNewOffer1.Text;
            string path = TxOfferPath.Text;
            string ansver = TxAnsver.Text;
            string date = TxDate.Text;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(path) && !string.IsNullOrEmpty(ansver) && !string.IsNullOrEmpty(date))
            {
                obj_GridView.InsertData(name, path, ansver, date);
                txNewOffer1.Text = string.Empty;
                TxOfferPath.Text = string.Empty;
                TxAnsver.Text = string.Empty;
                TxDate.Text = string.Empty;
            }
            else
            {

            }

        }
        public void DeleteData()
        {
            //int rowNumber;
            //int.TryParse(TxDelete.Text, out rowNumber);
            //obj_GridView.DeleteData(rowNumber);
            //rowIndex = Tabela.SelectedIndex;
            rowIndex = Convert.ToInt32(Tabela.DataKeys[Tabela.SelectedIndex].Values["OfferId"]);
            obj_GridView.DeleteData(rowIndex);

        }
        public void AlterData()
        {
            //int rowNumber;
            //int.TryParse(TxDelete.Text, out rowNumber);
            rowIndex = Convert.ToInt32(Tabela.DataKeys[Tabela.SelectedIndex].Values["OfferId"]);
            //rowIndex = Tabela.SelectedIndex;
            string name = txNewOffer1.Text;
            string path = TxOfferPath.Text;
            string ansver = TxAnsver.Text;
            string date = TxDate.Text;
            //obj_GridView.EditData(rowNumber, name, path, ansver, date);
            obj_GridView.EditData(rowIndex, name, path, ansver, date);

        }
        protected void Tabela_SelectedIndexChanged(object sender, EventArgs e)
        {
            //rowIndex = Tabela.SelectedIndex;
            rowIndex = Convert.ToInt32(Tabela.DataKeys[Tabela.SelectedIndex].Values["OfferId"]);
            TxDelete.Text = Tabela.DataKeys[Tabela.SelectedIndex]["OfferId"].ToString();
            txNewOffer1.Text = Tabela.Rows[Tabela.SelectedIndex].Cells[2].Text;
            TxOfferPath.Text = Tabela.Rows[Tabela.SelectedIndex].Cells[3].Text;
            TxAnsver.Text = Tabela.Rows[Tabela.SelectedIndex].Cells[4].Text;
            TxDate.Text = Tabela.Rows[Tabela.SelectedIndex].Cells[5].Text;
        }
        


        protected void Tabela_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //rowIndex = Tabela.SelectedIndex;
            rowIndex = Convert.ToInt32(Tabela.DataKeys[Tabela.SelectedIndex].Values["OfferId"]);
        }

        protected void ButTabelaUp_Click(object sender, EventArgs e)
        {
            Tabela.SelectedIndex -= 1;
        }

        protected void ButTabelaDown_Click(object sender, EventArgs e)
        {
            Tabela.SelectedIndex += 1;
        }

        protected void Tabela_RowEditing(object sender, GridViewEditEventArgs e)
        {
            AlterData();
        }

        protected void Tabela_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            AlterData();

        }
    }
}