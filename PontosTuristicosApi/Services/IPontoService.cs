using PontosTuristicosApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicosApi.Services
{
    public interface IPontoService
    {
        Task<IEnumerable<Ponto>> GetPontos();
        Task<Ponto> GetPonto(int id);
        Task<IEnumerable<Ponto>> GetPontosByNome(string nome);
        Task CreatePonto(Ponto ponto);
        Task UpdatePonto(Ponto ponto);
        Task DeletePonto(Ponto ponto);



    }
}
