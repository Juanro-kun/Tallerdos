using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Infra;
using Taller_2_Gestor.Domain.Entities;

namespace Taller_2_Gestor.Features.Clientes
{
    internal class ClientesService
    {
        private readonly AppDbContext _db;

        public ClientesService(AppDbContext db)
        {
            _db = db;
        }

        public List<Cliente> ListarClientes()
        {
            return _db.Clientes.ToList();
        }
    }
}
