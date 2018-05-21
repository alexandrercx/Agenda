using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using Acesso.Infra;
using Microsoft.Win32;
//using System.Data.Sql;
//using System.Data.Odbc;

namespace Belagricola.Infra
{
    public class ConectaDB
    {
        public static DataTable retornarDataTable(string strSql)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlDataAdapter da = new SqlDataAdapter(strSql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.Source);
            }
        }

        public static DataTable retornarDataTableProgress(string strSql)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlDataAdapter da = new SqlDataAdapter(strSql, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
            catch 
            {
                // Criado para o monitor de Contratos não parar o seu processamento;
                return new DataTable();
            }
        }

        public static DataSet retornarDataSet(string strSql)
        {
            try
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlDataAdapter da = new SqlDataAdapter(strSql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.Source);
            }
        }

        public static DataSet retornarDataSetDeExcel(string strSql, string nomeArquivo)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(nomeArquivo);
                OleDbDataAdapter da = new OleDbDataAdapter(strSql, cn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cn.Close();
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.Source);
            }
        }

        public static int executarComando(string strSql)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            int resultado = 0;
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = strSql;
                cn.Open();
                resultado = cmd.ExecuteNonQuery();
                cn.Close();
                return resultado;
            }
            catch (SqlException ex)
            {
                throw new Exception("DB Erro: " + ex.Message + " " + ex.ErrorCode);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + " " + ex.Source);
            }
        }

        public enum NomeBancoDados
        {
            EMS2CUSTOM,
            EMS2CORP,
            EMS2UNIT,
            MOV2UNIT,
            EMS506,
            EMSGRA,
            HCM210
        }
        
        public enum AmbienteBancoDados
        {
            TESTE,
            OFICIAL
        }


        public static string GetConnectionString(NomeBancoDados nomeBanco)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            AmbienteBancoDados ambiente = new AmbienteBancoDados();
            if (cn.Database.ToUpper().Equals("BELAGRICOLA"))
            {
                ambiente = AmbienteBancoDados.OFICIAL;
                
            }
            else
            {
                ambiente = AmbienteBancoDados.TESTE;
            }
            return GetConnectionString(nomeBanco, ambiente);
        }


        public static string GetDriverProgress()
        {
            string[] odbcDriverNames = null;
            using (RegistryKey localMachineHive = Registry.LocalMachine)
            using (RegistryKey odbcDriversKey = localMachineHive.OpenSubKey(@"SOFTWARE\ODBC\ODBCINST.INI\ODBC Drivers"))
            {
                if (odbcDriversKey != null)
                {
                    odbcDriverNames = odbcDriversKey.GetValueNames();
                }
            }

            foreach (string valor in odbcDriverNames)
            {
                if (valor.Contains("Progress"))
                    return valor;

            }

            return null;
        }

        public static string GetConnectionString(NomeBancoDados NomeBancoDados, AmbienteBancoDados ambienteBancoDados)
        {
            string driverProgress = GetDriverProgress();
            string servidor = "";
            switch (ambienteBancoDados)
            {
                case AmbienteBancoDados.TESTE:
                    servidor = "192.168.0.169";
                    switch (NomeBancoDados)
                    {
                        case NomeBancoDados.EMS2CUSTOM:
                            return "Driver={" + driverProgress + "}; HostName=" +servidor + ";PortNumber=50000;DatabaseName=ems2custom;LogonID=sysprogress;Password=sysprogress";
                        case NomeBancoDados.EMS2CORP:
                            return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=50002;DatabaseName=ems2corp;LogonID=sysprogress;Password=sysprogress";
                        case NomeBancoDados.EMS2UNIT:
                            return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=50003;DatabaseName=ems2unit;LogonID=sysprogress;Password=sysprogress";
                        case NomeBancoDados.MOV2UNIT:
                            return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=50006;DatabaseName=mov2unit;LogonID=sysprogress;Password=sysprogress";
                        case NomeBancoDados.EMSGRA:
                            return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=50007;DatabaseName=emsgra;LogonID=sysprogress;Password=sysprogress";
                        case NomeBancoDados.HCM210:
                            throw new NotImplementedException("Conexão não configurada");
                        case NomeBancoDados.EMS506:
                            return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=50100;DatabaseName=ems506;LogonID=sysprogress;Password=sysprogress";
                        default:
                            throw new NotImplementedException("Conexão não configurada");
                    }
                    break;
                case AmbienteBancoDados.OFICIAL:
                    servidor = "192.168.0.7";
            switch (NomeBancoDados)
            {
                case NomeBancoDados.EMS2CUSTOM:
                    return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=30019;DatabaseName=ems2custom;LogonID=sysprogress;Password=sysprogress";
                case NomeBancoDados.EMS2CORP:
                    return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=30017;DatabaseName=ems2corp;LogonID=sysprogress;Password=sysprogress";
                case NomeBancoDados.EMS2UNIT:
                    return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=30016;DatabaseName=ems2unit;LogonID=sysprogress;Password=sysprogress";
                case NomeBancoDados.MOV2UNIT:
                    return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=30013;DatabaseName=mov2unit;LogonID=sysprogress;Password=sysprogress";
                case NomeBancoDados.EMSGRA:
                    return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=30012;DatabaseName=emsgra;LogonID=sysprogress;Password=sysprogress";
                case NomeBancoDados.HCM210:
                    throw new NotImplementedException("Conexão não configurada");
                case NomeBancoDados.EMS506:
                    return "Driver={" + driverProgress + "}; HostName=" + servidor + ";PortNumber=30110;DatabaseName=ems506;LogonID=sysprogress;Password=sysprogress";
                default:
                    throw new NotImplementedException("Conexão não configurada");
            }
                    break;
            }
            return "";
      
        }
    }
}