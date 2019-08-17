using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Cantina.Models
{
    public class Produto
    {
        private string nome;
        private int id_produto;
        private int quantidade;
        private float preco;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public float Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }

        public int Id_produto
        {
            get
            {
                return id_produto;
            }

            set
            {
                id_produto = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }

        public static List<Produto> ListaProdutos()
        {
            List<Produto> lista = new List<Produto>();
            SqlConnection con = new SqlConnection("Data Source = ESN509VMSSQL;Initial Catalog=myCanteen;Persist Security Info=True; User Id=aluno;Password=Senai1234;");
            try
            {
                con.Open();
                SqlCommand query =
                    new SqlCommand("SELECT * FROM Estoques", con);
                SqlDataReader leitor = query.ExecuteReader();

                while (leitor.Read())
                {
                    Produto p = new Produto();
                    p.Id_produto = int.Parse(leitor["id_produto"].ToString());
                    p.Nome = leitor["nome"].ToString();
                    p.Preco = float.Parse(leitor["preco_venda"].ToString());

                    lista.Add(p);
                }
            }
            catch (Exception e)
            {
                lista = new List<Produto>();
            }

            if (con.State == ConnectionState.Open)
                con.Close();

            return lista;
        }

  

        public static Produto BuscaProduto(string id_produto)
        {
            Produto p = new Produto();
            SqlConnection con =
                new SqlConnection("Data Source = ESN509VMSSQL;Initial Catalog=myCanteen;Persist Security Info=True; User Id=aluno;Password=Senai1234;");
            try
            {
                con.Open();
                SqlCommand query =
                    new SqlCommand("SELECT * FROM Estoques WHERE Codigo = @cod", con);
                query.Parameters.AddWithValue("@cod", id_produto);
                SqlDataReader leitor = query.ExecuteReader();

                while (leitor.Read())
                {
                    p.Id_produto = int.Parse(leitor["id_produto"].ToString());
                    p.Nome = leitor["nome"].ToString();
                    p.Preco = float.Parse(leitor["preco_venda"].ToString());
                }
            }
            catch (Exception e)
            {
                p = null;
            }

            if (con.State == ConnectionState.Open)
                con.Close();

            return p;
        }
    }
}