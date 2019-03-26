using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using AddressBookEntity;
namespace AddressBoolWithDissconnectedNTier
{
    public class DALayer
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        SqlCommandBuilder sb;

        SqlConnection GetConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["con"].ToString();
            con = new SqlConnection(connection);
            return con;
        }
        void fill_Dtaset()
        {
            con = GetConnection();
            sda = new SqlDataAdapter("select *from AddressBook", con);
            sb = new SqlCommandBuilder(sda);
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sda.Fill(ds);
        }
        public int InsertAddress(AddressBook ab)
        {
            fill_Dtaset();
            DataRow dr = ds.Tables[0].NewRow();
            dr["Address_ID"] = ab.id;
            dr["FirstName"] = ab.Fname;
            dr["LastName"] = ab.Lname;
            dr["Email"] = ab.email;
            dr["PhoneNo"] = ab.PhonNo;
            dr["Country"] = ab.Country;
            ds.Tables[0].Rows.Add(dr);
            sb = new SqlCommandBuilder(sda);
            int flag = sda.Update(ds);
            return flag;
        }
        public int DeleteAddress(int aid)
        {
            fill_Dtaset();
            ds.Tables[0].Rows.Find(Convert.ToInt32(aid)).Delete();
            sb = new SqlCommandBuilder(sda);
            int flag = sda.Update(ds);
            return flag;
        }
        public int UpdateAddress(int id, AddressBook ab)
        {
            fill_Dtaset();
            DataRow dr = ds.Tables[0].Rows.Find(Convert.ToInt32(id));

            dr["FirstName"] = ab.Fname;
            dr["LastName"] = ab.Lname;
            dr["Email"] = ab.email;
            dr["PhoneNo"] = ab.PhonNo;
            sb = new SqlCommandBuilder(sda);
            int flag = sda.Update(ds);
            return flag;

        }
        public AddressBook SearchAddress(int Address_id)
        {
            //Emp emp = null;
            fill_Dtaset();
            DataRow dr = ds.Tables[0].Rows.Find(Address_id);
            AddressBook ab = new AddressBook();
            ab.Fname = Convert.ToString(dr["FirstName"]);
            ab.Lname = Convert.ToString(dr["LastName"]);
            ab.email= Convert.ToString(dr["Email"]);
            ab.PhonNo = Convert.ToString(dr["PhoneNo"]);
            ab.Country = Convert.ToString(dr["Country"]);
            //emp.salary = Convert.ToInt32(dr["salary"]);
            return ab;
        }
    }
}
