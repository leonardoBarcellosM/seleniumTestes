using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;

namespace AutomacaoFuncional.tests.utils
{
    class UpdateStatusDB
    {
        public static string CpfFixo = "";
        public static string id = "";
        string db = "faserv22:1521/homolog";
        //string db = "faserv22:1521/teste1";

        public static void Cpf(string cpf)
        {
            CpfFixo = cpf;
        }

        public static string PegarCpf()
        {
            return CpfFixo;
        }

        public void Consulta()
        {

            OracleConnection con = new OracleConnection();

            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "paris";
            ocsb.UserID = "sgcred";
            ocsb.DataSource = db;

            con.ConnectionString = ocsb.ConnectionString;

            string queryString =
                "select sol.id from SOLICITACOES_WEB sol, USUARIOS_WEB usu where sol.USR_ID = usu.id and cpf =:cpf";


            OracleCommand command = con.CreateCommand();
            command.CommandText = queryString;
            command.Parameters.Add(new OracleParameter("cpf", CpfFixo));

            try
            {
                con.Open();
                Console.WriteLine("Connection established (" + con.ServerVersion + ")");

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = reader[0].ToString();
                    Console.WriteLine(id);
                    UpdatePDC(id);

                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            con.Dispose();
            
        }

            public void UpdatePDC(string IdUser)
            {
            OracleConnection con = new OracleConnection();

            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "paris";
            ocsb.UserID = "sgcred";
            ocsb.DataSource = db;

            con.ConnectionString = ocsb.ConnectionString;

            string queryString =
                "update SOLICITACOES_WEB set STATUS = 'PDC' where id =:param1";


            OracleCommand command = con.CreateCommand();
            command.CommandText = queryString;
            command.Parameters.Add(new OracleParameter("param1", IdUser));

            try
            {
                con.Open();
                Console.WriteLine("Connection established (" + con.ServerVersion + ")");

                command.ExecuteNonQuery();
                UpdatePIES(IdUser);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Dispose();
           
        }

        public void UpdatePIES(string IdUser)
        {
            OracleConnection con = new OracleConnection();

            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "paris";
            ocsb.UserID = "sgcred";
            ocsb.DataSource = db;

            con.ConnectionString = ocsb.ConnectionString;

            string queryString =
                "update SOLICITACOES_WEB set STATUS = 'PIES' where id =:param1";


            OracleCommand command = con.CreateCommand();
            command.CommandText = queryString;
            command.Parameters.Add(new OracleParameter("param1", IdUser));

            try
            {
                con.Open();
                Console.WriteLine("Connection established (" + con.ServerVersion + ")");

                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public bool ValidarUpdate()
        {
            string teste = "PIES";
            bool _result = false;
            string stat = "";

            OracleConnection con = new OracleConnection();

            OracleConnectionStringBuilder ocsb = new OracleConnectionStringBuilder();
            ocsb.Password = "paris";
            ocsb.UserID = "sgcred";
            ocsb.DataSource = db;

            con.ConnectionString = ocsb.ConnectionString;

            string queryString =
                "select sol.STATUS from SOLICITACOES_WEB sol, USUARIOS_WEB usu where sol.USR_ID = usu.id and cpf = :cpf";


            OracleCommand command = con.CreateCommand();
            command.CommandText = queryString;
            command.Parameters.Add(new OracleParameter("cpf", CpfFixo));

            try
            {
                con.Open();
                Console.WriteLine("Connection established (" + con.ServerVersion + ")");

                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    stat = reader[0].ToString();
                }
                reader.Close();

                if (stat == teste)
                {
                    _result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Dispose();
            return _result;
        }
    }
}

