using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace _57_Projeto_Academia
{
    internal class Banco
    {
        private static SQLiteConnection conexao;
        //Funçoes genericas
        private static SQLiteConnection ConexaoBanco()
        {
                                                        //C:\\Users\\ricar\\OneDrive\\Ambiente de Trabalho\\Rep.GitHub\\C#\\57_Projeto_Academia\\Banco\\banco_academia.db"
            conexao = new SQLiteConnection("Data Source=" + Globais.caminhoBanco + Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static DataTable dql(string sql)    //dql = data query language (select)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();    
                return dt;
                
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        public static void dml(string q, string msgOk = null, string msgErro = null)   //data manipulation language(insert, delete, update
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                if(msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }

            }
            catch (Exception ex)
            {
                if(msgErro != null)
                {
                    MessageBox.Show(msgErro + "\n" + ex.Message);
                }
                throw ex;
            }
        }
        public static DataTable ObterTodosUsuarios()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();    
                return dt;
                
            }
            catch(Exception ex)
            {
                
                throw ex;
            }
        }
        
        //Funções do FORM F_GestaoUsuarios

        public static DataTable ObterUsuariosIdNome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT N_IDUSUARIO as 'ID USUARIO', T_NOMEUSUARIO as 'NOME USUARIO' FROM tb_usuarios";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable ObterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuarios where N_IDUSUARIO =" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO = '"+u.nome+ "', T_USERNAME = '"+u.username+"', T_SENHAUSUARIO = '"+u.senha+"', T_STATUSUSUARIO = '"+u.status+"', N_NIVELUSUARIO = "+u.nivel+" WHERE N_IDUSUARIO = "+u.id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void DeletarUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO = " + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //FIM - Funções do FORM F_GestaoUsuarios
        //Funçoes do FORM F_NovoUsuario

        public static void NovoUsuario(Usuario u)
        {
            if (existeUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO, T_USERNAME, T_SENHAUSUARIO, T_STATUSUSUARIO, N_NIVELUSUARIO) VALUES(@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuario inserido");
                vcon.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Erro ao gravar novo usuario");
            }
        }

        //FIM - Funçoes do FORM F_NovoUsuario
        //Rotinas Gerais

        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var vcon = ConexaoBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_usuarios WHERE T_USERNAME = '" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            vcon.Close();
            return res;
        }
    }
}
