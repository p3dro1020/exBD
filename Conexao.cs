using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace exBD
{
    public class Conexao
    {
        private string conexao = "Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=exBD;";
        private NpgsqlConnection con = null;

        public void Conectar()
        {
            con = new NpgsqlConnection(conexao);
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }

        public DataTable AtualizarDGV()
        {
            DataTable dt = new DataTable();
            NpgsqlCommand cmd = null;
            try
            {
                Conectar();
                cmd = new NpgsqlCommand("SELECT id cod, nome, numero FROM contato ORDER BY id;", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
            
        }



        public void AdicionarContato(string nome, string numero)
        {
            NpgsqlCommand cmd = null;
            try
            {
                Conectar();
                cmd = new NpgsqlCommand("INSERT INTO contato (nome, numero) VALUES (@nome, @numero);", con);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }


        // remove contato pelo id
        public void RemoverContato(int id)
        {
            NpgsqlCommand cmd = null;
            try
            {
                Conectar();
                cmd = new NpgsqlCommand("DELETE FROM contato WHERE id = @id;", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar comando: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

        public void AlterarContato(int id, string nome, string numero)
        {
            NpgsqlCommand cmd = null;
            try
            {
                Conectar();
                cmd = new NpgsqlCommand("UPDATE contato SET nome = @nome, numero = @numero WHERE id = @id;", con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@numero", numero);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar número: " + ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }

    }
}
