using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAnswers
{
    class Program
    {
        static void Main()
        {
            var oracle = new OracleConnection("userName");
            var comOracle = new DbCommand(oracle);
            oracle.OpenConnection();
            comOracle.Execute("SELECT * FROM table");
            oracle.CloseConnection();

            var sql = new SqlConnection("userName");
            var comSql = new DbCommand(sql);
            sql.OpenConnection();
            comSql.Execute("SELECT * FROM table");
            sql.CloseConnection();
        }
    }
}
