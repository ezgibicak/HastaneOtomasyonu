using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HastaneOtomasyonu.DAL
{
    public class VeriTabaniSaglayicisi
    {

        List<SqlParameter> parametreler = new List<SqlParameter>();

        private SqlCommand SorguOlustur(string Sorgu,CommandType KomutTipi)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BaglantiSaglayicisi.BaglantıOlustur();
            cmd.CommandType = KomutTipi;
            cmd.CommandText = Sorgu;
            return cmd;

        }

        private SqlCommand SorguOlustur(string Sorgu)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = BaglantiSaglayicisi.BaglantıOlustur();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sorgu;
            return cmd;

        }

        public void ParametreEkle(string Parametreİsmi,DbType Tipi,object Degeri)
        {
            SqlParameter sp = new SqlParameter();
            sp.ParameterName = Parametreİsmi;
            sp.DbType = Tipi;
            sp.Value = Degeri;
            parametreler.Add(sp);

        }

        private void ParametreleriKomutaEkle(SqlCommand cmd)
        {
            cmd.Parameters.AddRange(parametreler.ToArray());
        }

        private void ParametreleriTemizle(SqlCommand cmd)
        {
            cmd.Parameters.Clear();
        }

        public int ExecuteNonQueryYap (string sorgu,CommandType KomutTipi)
        {
            SqlCommand cmd = SorguOlustur(sorgu, KomutTipi);
            ParametreleriTemizle(cmd);
            ParametreleriKomutaEkle(cmd);
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            catch(Exception ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public int ExecuteNonQueryYap(string sorgu)
        {
            SqlCommand cmd = SorguOlustur(sorgu);
            ParametreleriTemizle(cmd);
            ParametreleriKomutaEkle(cmd);
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new VeritabaniException(ex.Message);
            }

            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public object ExecuteScalarYap(string sorgu, CommandType KomutTipi)
        {
            SqlCommand cmd = SorguOlustur(sorgu, KomutTipi);
            ParametreleriTemizle(cmd);
            ParametreleriKomutaEkle(cmd);
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public object ExecuteScalarYap(string sorgu)
        {
            SqlCommand cmd = SorguOlustur(sorgu);
            ParametreleriTemizle(cmd);
            ParametreleriKomutaEkle(cmd);
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }

                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new VeritabaniException(ex.Message);
            }
            finally
            {
                if (cmd.Connection.State != ConnectionState.Closed)
                {
                    cmd.Connection.Close();
                }
            }
        }

        public IDataReader ExecuteReaderYap(string sorgu,CommandType KomutTipi)
        {
            SqlCommand cmd = SorguOlustur(sorgu, KomutTipi);
            ParametreleriTemizle(cmd);
            ParametreleriKomutaEkle(cmd);

            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }

            catch (SqlException sqlex)
            {
                throw new VeritabaniException(sqlex.Message);
            }
            catch (Exception sqlex)
            {
                throw new VeritabaniException(sqlex.Message);
            }
            //finally
            //{

            //    if (cmd.Connection.State != ConnectionState.Closed)
            //    {
            //        cmd.Connection.Close();
            //    }

            //}
        }

        public IDataReader ExecuteReaderYap(string sorgu)
        {
            SqlCommand cmd = SorguOlustur(sorgu);
            ParametreleriTemizle(cmd);
            ParametreleriKomutaEkle(cmd);
            try
            {
                if (cmd.Connection.State != ConnectionState.Open)
                {
                    cmd.Connection.Open();
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }

            catch (SqlException sqlex)
            {
                throw new VeritabaniException(sqlex.Message);
            }
            catch (Exception ex)
            {

                throw new VeritabaniException(ex.Message);
            }
            //finally
            //{

            //    if (cmd.Connection.State != ConnectionState.Closed)
            //    {
            //        cmd.Connection.Close();
            //    }

            //}
        }


        public object ParametreleriGetir(string Parametreİsmi)
        {
            foreach (SqlParameter item in parametreler)
            {
                if (item.ParameterName == Parametreİsmi)
                {
                    return item.Value;
                }

               
            }
            return null;

        }

        public DataSet DataSetYap(string sorgu,CommandType KomutTipi,string datatableismi)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(SorguOlustur(sorgu,KomutTipi));
            try
            {

                if (string.IsNullOrEmpty(datatableismi))
                {
                    da.Fill(ds);
                }
                else
                {
                    DataTable dt = new DataTable(datatableismi);
                    ds.Tables.Add(dt);
                    da.Fill(ds, datatableismi);
                }
                return ds;

            }
            catch (SqlException ex)
            {

                throw new VeritabaniException(ex.Message);
            }
            catch(Exception ex)
            {
                throw new VeritabaniException(ex.Message); 
            }

        }

        public DataSet DataSetYap(string sorgu,string datatableismi)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(SorguOlustur(sorgu));
            try
            {

                if (string.IsNullOrEmpty(datatableismi))
                {
                    da.Fill(ds);
                }
                else
                {
                    DataTable dt = new DataTable(datatableismi);
                    ds.Tables.Add(dt);
                    da.Fill(ds, datatableismi);
                }
                return ds;

            }
            catch (SqlException ex)
            {

                throw new VeritabaniException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new VeritabaniException(ex.Message);
            }

        }

        public DataSet DataSetYap(string sorgu)
        {
            return this.DataSetYap(sorgu, CommandType.Text, null);
        }

        public DataSet DataSetYap(string sorgu, CommandType KomutTipi)
        {
             return this.DataSetYap(sorgu, CommandType.StoredProcedure, null);

        }

        public DataTable DataTableYap(string sorgu,CommandType KomutTipi)
        {
            return this.DataSetYap(sorgu, KomutTipi).Tables[0];
        }

        public DataTable DataTableYap(string sorgu, CommandType KomutTipi,string Tableİsmi)
        {
            return this.DataSetYap(sorgu, KomutTipi, Tableİsmi).Tables[Tableİsmi];
        }


    }
}
