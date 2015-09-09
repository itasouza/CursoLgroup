using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LGROUP.SisCadastro.Web.UI.Models
{
    public class ProdutosMOD
    {
        public Int32 id { get; set; }
        public String Nome { get; set; }
        public String Peso { get; set; }
        public Int32 Quantidade { get; set; }
        public DateTime DataVencimento { get; set; }
        public CategoriaMOD Categoria { get;set; }

    }
}