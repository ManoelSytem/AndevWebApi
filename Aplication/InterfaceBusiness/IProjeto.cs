using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interface
{
    public interface IProjeto
    {
        List<Projeto> ObterProjetoPorIdCliente(int IdUser);
    }
}
