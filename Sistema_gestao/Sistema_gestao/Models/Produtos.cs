using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_gestao.Models
{
    public class Produtos
    {
        [Key]
        public int Id_uni { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public DateTime Ultimacompra { get; set; }
        public float Estoque{ get; set; }

    }
}