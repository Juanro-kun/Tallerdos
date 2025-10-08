using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Taller_2_Gestor.Domain.Entities;
using Taller_2_Gestor.Infra;

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

        public (bool ok, string? error, Cliente? cliente) Crear(
        string nombre, string apellido, string mail, int telefono, int dni)
        {
            try
            {
                var nuevo = new Cliente
                {
                    Nombre = nombre.Trim(),
                    Apellido = apellido.Trim(),
                    Mail = mail.Trim(),
                    Telefono = telefono,
                    Dni = dni
                };


                _db.Clientes.Add(nuevo);
                _db.SaveChanges(); // completa nuevo.idUsuario

                return (true, null, nuevo);
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar: " + ex.Message, null);
            }
        }

        public (bool ok, string error, Cliente cliente) Actualizar(
        string nombre, string apellido, string mail, int telefono, int dni)
        {
            try
            {
                var c = _db.Clientes.FirstOrDefault(x => x.Dni == dni);
                if (c == null) return (false, "Cliente no encontrado.", null!);
                c.Nombre = nombre.Trim();
                c.Apellido = apellido.Trim();
                c.Mail = mail.Trim();
                c.Telefono = telefono;
                c.Dni = dni;
                _db.SaveChanges();
                return (true, null!, c);
            }
            catch (Exception ex)
            {
                return (false, "Error al guardar: " + ex.Message, null!);
            }
        }
    }
}
