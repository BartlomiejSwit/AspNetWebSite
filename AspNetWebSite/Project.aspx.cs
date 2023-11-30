using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebSite
{


    public partial class Project : Page
    {
        public decimal result;
        public decimal number1;
        public decimal number2;
        public int operation;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            Label1.Text = "nowy tekst";
        }
        protected void Btn2_Click(object sender, EventArgs e)
        {
            Label2.Text = Button2.Text;
        }

        protected void CalBt1_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt1.Text;
        }

        protected void CalBt2_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt2.Text;
        }

        protected void CalBt3_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt3.Text;
        }

        protected void CalBt4_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt4.Text;
        }

        protected void CalBt5_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt5.Text;
        }

        protected void CalBt6_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt6.Text;
        }

        protected void CalBt7_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt7.Text;
        }

        protected void CalBt8_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt8.Text;
        }

        protected void CalBt9_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt9.Text;
        }

        protected void CalBt0_Click(object sender, EventArgs e)
        {
            TxEqual.Text += CalBt0.Text;
        }

        protected void CalBtPlus_Click(object sender, EventArgs e)
        {            
            TextBoxOperations.Text = "1";
            TextBoxHidden1.Text = TxEqual.Text;
            TxEqual.Text = "";
        }

        protected void CalBtMinus_Click(object sender, EventArgs e)
        {
            TextBoxOperations.Text = "2";
            TextBoxHidden1.Text = TxEqual.Text;
            TxEqual.Text = "";
        }

        protected void CalBtDivision_Click(object sender, EventArgs e)
        {
            TextBoxOperations.Text = "3";
            TextBoxHidden1.Text = TxEqual.Text;
            TxEqual.Text = "";
        }

        protected void CalBtmultiplication_Click(object sender, EventArgs e)
        {
            TextBoxOperations.Text = "4";
            TextBoxHidden1.Text = TxEqual.Text;
            TxEqual.Text = "";
        }

        protected void CalBtequal_Click(object sender, EventArgs e)
        {
            //if (decimal.TryParse(TxEqual.Text, out number2))
            //{

            // }
            TextBoxHidden2.Text = TxEqual.Text;
            decimal.TryParse(TextBoxHidden1.Text, out number1);
            decimal.TryParse(TextBoxHidden2.Text, out number2);
            int.TryParse(TextBoxOperations.Text, out operation);
            switch (operation)
            {
                case 1:
                    result = number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 / number2;
                    break;
                case 4:
                    result = number1 * number2;
                    break;
            }
            TxEqual.Text = result.ToString();

        }

        protected void CalBtClear_Click(object sender, EventArgs e)
        {
            TxEqual.Text = "";
        }
    }
}