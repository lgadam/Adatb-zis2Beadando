using Adatbazis_beadando.Models.Records;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazis_beadando.Models.Manager
{
    class LaptopokTabla
    {
        OracleConnection GetOracleConnection()
        {
            OracleConnection oc = new OracleConnection();

            string connectionString = @"Data Source=193.225.33.71;User Id=II3VEY;Password=EKE2020;";
            oc.ConnectionString = connectionString;
            return oc;
        }
        public List<Laptopok> Select()
        {
            List<Laptopok> records = new List<Laptopok>();

            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "SELECT l.sorozatszam, l.tipus, gy.nev FROM " +
                "laptopok l INNER JOIN gyartok gy ON gy.id = l.gyarto_id"
            };

            command.Connection = oc;

            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Laptopok laptop = new Laptopok();
                laptop.Sorozatszam = reader["sorozatszam"].ToString();
                laptop.Tipus = reader["tipus"].ToString();
                laptop.Gyartonev = reader["nev"].ToString();
                records.Add(laptop);
            }
            oc.Close();

            return records;
        }
        public int Delete(Laptopok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.Text,
                CommandText = "DELETE FROM laptopok WHERE sorozatszam = :sorozatszam"
            };

            OracleParameter sorozatszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = ":sorozatszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Sorozatszam
            };
            command.Parameters.Add(sorozatszamParameter);

            command.Connection = oc;
            command.Transaction = ot;

            int affectedRows = 0;
            try
            {
                affectedRows = command.ExecuteNonQuery();
                ot.Commit();
            }
            catch (Exception)
            {
                ot.Rollback();
            }
            oc.Close();

            return affectedRows;
        }
        public int Insert(Laptopok record)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleTransaction ot = oc.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "spInsert_laptopok"
            };

            OracleParameter sorozatszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_sorozatszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Sorozatszam
            };
            command.Parameters.Add(sorozatszamParameter);

            OracleParameter tipusParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_tipus",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Tipus
            };
            command.Parameters.Add(tipusParameter);

            OracleParameter gyartonevParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_gyarto",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Gyartonev
            };
            command.Parameters.Add(gyartonevParameter);

            OracleParameter processzorParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_processzor",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Processzor
            };
            command.Parameters.Add(processzorParameter);

            OracleParameter videokartyaParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_videokartya",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Videokartya
            };
            command.Parameters.Add(videokartyaParameter);

            OracleParameter ramParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_ram",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Ram
            };
            command.Parameters.Add(ramParameter);

            OracleParameter kepernyomeretParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_kepernyomeret",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Kepernyomeret
            };
            command.Parameters.Add(kepernyomeretParameter);
            OracleParameter processzororajelParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_processzororajel",
                Direction = System.Data.ParameterDirection.Input,
                Value = record.Processzororajel
            };
            command.Parameters.Add(processzororajelParameter);


            OracleParameter rowcountParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                ParameterName = "p_out_rowcnt",
                Direction = System.Data.ParameterDirection.Output
            };
            command.Parameters.Add(rowcountParameter);

            command.Connection = oc;
            command.Transaction = ot;
            try
            {
                command.ExecuteNonQuery();
                int affectedRows = int.Parse(rowcountParameter.Value.ToString());
                ot.Commit();
                oc.Close();
                return affectedRows;
            }
            catch (Exception)
            {
                ot.Rollback();
                oc.Close();
                return 0;
            }
        }
        public bool CheckSorozatszam(string sorozatszam)
        {
            OracleConnection oc = GetOracleConnection();
            oc.Open();

            OracleCommand command = new OracleCommand()
            {
                CommandType = System.Data.CommandType.StoredProcedure,
                CommandText = "sf_check_sorozatszam"
            };

            OracleParameter correct = new OracleParameter()
            {
                DbType = System.Data.DbType.Int32,
                Direction = System.Data.ParameterDirection.ReturnValue
            };
            command.Parameters.Add(correct);
            OracleParameter sorozatszamParameter = new OracleParameter()
            {
                DbType = System.Data.DbType.String,
                ParameterName = "p_sorozatszam",
                Direction = System.Data.ParameterDirection.Input,
                Value = sorozatszam

            };
            command.Parameters.Add(sorozatszamParameter);
            command.Connection = oc;
            command.ExecuteNonQuery();
            oc.Close();
            try
            {
                int succesful = int.Parse(correct.Value.ToString());

                return succesful != 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
