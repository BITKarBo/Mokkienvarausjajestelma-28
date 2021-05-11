using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mökinvarausjärjestelmä
{
    class SQLdataset
    {
        // Tällänen nopee pikkunen kirjasto lyhentämään koodia. (ei tarkoitettu ulkoiseen käyttöön)
        private OdbcConnection connection = new OdbcConnection("Dsn=Village Newbies");

        public DataSet Getdataset(string Query)
        {
            DataSet ds = new DataSet();

            try
            {
                
                OdbcDataAdapter adapter = new OdbcDataAdapter(Query, connection);

                connection.Open();
                adapter.Fill(ds);

                connection.Close();
            }
            catch (Exception exx)
            {
                Console.Write(exx.Message);
            }

            return ds;
        }

        public DataTable Getdatatable(string Query)
        {
            DataTable dt = new DataTable();

            try
            {
                OdbcDataAdapter adapter = new OdbcDataAdapter(Query, connection);

                connection.Open();
                adapter.Fill(dt);

                connection.Close();
            }
            catch (Exception exx)
            {
                Console.Write(exx.Message);
            }

            return dt;
        }

        public OdbcDataAdapter Getdataadapter(string Query)
        {
            return new OdbcDataAdapter(Query, connection);
        }
    }
}
