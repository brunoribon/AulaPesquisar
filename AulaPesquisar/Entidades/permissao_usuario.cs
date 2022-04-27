using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPesquisar.Entidades
{
    public class permissao_usuario
    {
       public int Id { get; set; }
       public int UsuarioId { get; set; }
       public int PermissaoId { get; set; }
       public permissao permissao { get; set; }
       public usuarios usuario { get; set; }

    }
}
