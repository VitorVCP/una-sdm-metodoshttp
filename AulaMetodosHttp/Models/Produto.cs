using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaMetodosHttp.Models
{
    public record Produto
    (
        int Id,
        string Nome,
        decimal Preco
    );
}