using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3D241.DTO
{
    public class DTO
    {
        private int id, quantidade, tbl_categoria_id, tbl_fornecedor_id;
        private String nomeProduto, descricao;
        private double preco, peso;

        public int Id { get => id; set => id = value; }
        public int Tbl_categoria_id { get => tbl_categoria_id; set => tbl_categoria_id = value; }
        public int Tbl_fornecedor_id { get => tbl_fornecedor_id; set => tbl_fornecedor_id = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Peso { get => peso; set => peso = value; }

        public string NomeProduto
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeProduto = value;
                }
                else
                {
                    throw new Exception("O campo Nome do Produto é obrigatório.");
                }

            }
            get { return this.nomeProduto; }
        }
    }
}