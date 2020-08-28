using AppAndev.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppAndev.IService
{
    public interface IProjetoService
    {
        [Get("/Contador")]
        Task<ProjetoModel> Salvar();
        Task<ProjetoModel> Get();
    }
}
