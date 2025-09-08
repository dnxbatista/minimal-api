using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Dominio.Entidades;
using minimal_api.Dominio.Interfaces;
using minimal_api.Infraestrutura.Db;
using minimal_api.Dominio.DTOs;

namespace minimal_api.Dominio.Servicos
{
    public class AdminstradorServico : IAdministradorServico
    {
        private readonly DbContexto _contexto;

        public AdminstradorServico(DbContexto contexto)
        {
            _contexto = contexto;
        }

        public Administrador? Login(LoginDTO loginDTO)
        {
            return _contexto.Administradores.Where(a => a.Email == loginDTO.Email && a.Senha == loginDTO.Senha).FirstOrDefault();
        }
    }
}