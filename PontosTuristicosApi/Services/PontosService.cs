﻿using Microsoft.EntityFrameworkCore;
using PontosTuristicosApi.Context;
using PontosTuristicosApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PontosTuristicosApi.Services
{
    public class PontosService : IPontoService
    {
        private readonly AppDbContext _context;

        public PontosService (AppDbContext context)
        {
            _context = context;
        }

        //CREATE
        public async Task CreatePonto(Ponto ponto)
        {
            _context.Pontos.Add(ponto);
            await _context.SaveChangesAsync();
        }
        //CREATE

        //DELETE
        public async Task DeletePonto(Ponto ponto)
        {
            _context.Pontos.Remove(ponto);
            await _context.SaveChangesAsync();
        }
        //DELETE

        //GET POR ID
        public async Task<Ponto> GetPonto(int id)
        {
            var ponto = await _context.Pontos.FindAsync(id);
            return ponto;
        }
        //GET POR ID

        //GET
        public async Task<IEnumerable<Ponto>> GetPontos()
        {
            try
            {
                return await _context.Pontos.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
        //GET


        //GET POR NOME
        public async Task<IEnumerable<Ponto>> GetPontosByNome(string nome)
        {
            IEnumerable<Ponto> pontos;
            if (!string.IsNullOrEmpty(nome))
            {
                pontos = await _context.Pontos.Where(e => e.Nome.Contains(nome)).ToListAsync();
            }
            else
            {
                pontos = await GetPontos();
            }
            return pontos;
        }
        //GET POR NOME

        //UPDATE
        public async Task UpdatePonto(Ponto ponto)
        {
            _context.Entry(ponto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        //UPDATE
    }
}
