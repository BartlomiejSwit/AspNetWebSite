using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNetWebSite
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn1_Click(object sender, EventArgs e)
        {
            Lb1.Text = "nowy tekst";
        }
        protected void Btn2_Click(object sender, EventArgs e)
        {
            Lb2.Text = Btn2.Text;
        }
    }
}