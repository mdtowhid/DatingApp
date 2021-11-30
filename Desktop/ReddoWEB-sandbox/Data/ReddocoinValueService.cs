using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Reddocoin.Models;

namespace Reddocoin.Data
{
    public class ReddocoinValueService
    {
        private readonly IConfiguration _configuration;
        public ReddocoinValueService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public ReddocoinValue GetReddocoinValue()
        {
            ReddocoinValue obj = new ReddocoinValue();
            try
            {
                using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DBConnection")))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("sp_GetReddocoinValues", conn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            obj.RValues = Convert.ToDecimal(rdr["RValues"].ToString());
                            obj.Circulating = Convert.ToDecimal(rdr["Circulating"].ToString());
                            obj.MarketCaps = Convert.ToDecimal(rdr["MarketCaps"].ToString());
                            obj.Holders = Convert.ToDecimal(rdr["Holders"].ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
            }

            return obj;
        }
    }
}
