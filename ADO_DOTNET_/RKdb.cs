using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_DOTNET_
{
    public class RKdb
    {
        // 1. Select All RKDB
        public List<RKdb> AllRKdb()
        {
            List<RK> allRKdb = new List<RK>();

         string ConnectionStrings = "server =.\\sqlexpress;database=B22ADONET;integrated security=true;";


            // SqlConnection con = new SqlConnection();

            //con.ConnectionString = ConnectionStrings;

            SqlConnection con = new SqlConnection(ConnectionStrings);
            con.Open();

            string cmdText = "Select ID, Name ,City,Experience from RK";
            SqlCommand cmd = new SqlCommand(cmdText, con);

           SqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while (reader.Read())
                {
                    RK rK = new RK();
                    rK.Id = (int) reader["ID"];
                    rK.Name = (string)reader["Name"];
                    rK. city = (string)reader["City"];
                    rK.experience = (int)reader["experience"];

                    RK.Add(rK);
                }
            }
            con.Close();

            return RK;
        }
         
    

    
    



        // 2.Select A RKDB BY ID

        // 3.Creat a new RDDB

        // 4.Update Existing RKDB BY ID

        // 5.Delete A Existing RKDB BY ID
    }
}



