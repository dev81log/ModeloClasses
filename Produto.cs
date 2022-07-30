using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class Produto
    {
        // atributos da classe
        public int codito { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }

        // metodos construtores
        public Produto() { }

        public Produto(int codito, string nome, decimal preco)
        {
            this.codito = codito;
            this.nome = nome;
            this.preco = preco;
        }

        // metodos acessores
        public virtual void SetCodito(int codito)
        {
            this.codito = codito;
        }
        public virtual int GetCodito()
        {
            return this.codito;
        }

        public virtual void SetNome(string nome)
        {
            this.nome = nome;
        }
        public virtual string GetNome()
        {
            return this.nome;
        }

        public virtual void SetPreco(decimal preco)
        {
            this.preco = preco;
        }
        public virtual decimal GetPreco()
        {
            return this.preco;
        }

    }
}