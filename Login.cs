using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1_making_simple_login_page
{
    public class Login
    {
        //field
        string uName = "";
        int pass = 0;

        public Login() //default constructor
        {

        }

        public Login(string username, int password)//overload constructor
        { 
        uName = username;
        pass = password;
        }
        //property
        public string UserName
        { 
        get { return uName; }
        set { uName = value; }
        
        }
        public int Password
        {
            get { return pass; }
            set { pass = value; }
        }

        public void submit()
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-MMFNRAG; Database = studentInfo;Trusted_Connection= true;");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into signin (UserName,Passwords)" +
                "values ('"+UserName+"','"+Password+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

       
       

    }
}
