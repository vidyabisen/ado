using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AddressBookEntity;
using BALeyar;
namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL b = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Insert_Click(object sender, EventArgs e)
        {
            AddressBook ab = new AddressBook();
            ab.id = Convert.ToInt32(TextBox1.Text);
            ab.Fname = TextBox2.Text;
            ab.Lname = TextBox3.Text;
            ab.email = TextBox4.Text;
            ab.PhonNo = TextBox5.Text;
            ab.Country = TextBox6.Text;
            int flag = b.InsertAddress(ab);
            if (flag > 0)
            {
                Label1.Text = "Record is inserted";
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int flag = b.DeleteAddress(Convert.ToInt32(TextBox1.Text));
            if (flag > 0)
            {
                Label1.Text = "Record is Deleted";
            }
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            AddressBook ab = new AddressBook();
           // ab.id = Convert.ToInt32(TextBox1.Text);
            ab.Fname = TextBox2.Text;
            ab.Lname = TextBox3.Text;
            ab.email = TextBox4.Text;
            ab.PhonNo = TextBox5.Text;
            int flag = b.UpdateAddress(Convert.ToInt32(TextBox1.Text), ab);
            if (flag > 0)
            {
                Label1.Text = "Record is Updated";
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            AddressBook ab = b.SearchAddress(Convert.ToInt32(TextBox1.Text));
           // if (!string.IsNullOrEmpty(ab.id.ToString()))
            if(ab!=null)
            {
                TextBox2.Text = ab.Fname;
                TextBox3.Text = ab.Lname;
                TextBox4.Text = ab.email;
                TextBox5.Text = ab.PhonNo;
                TextBox6.Text = ab.Country;
            }
            else
            {
                Label1.Text = "Such Course do not exist";
            }
        }

        
    }
}