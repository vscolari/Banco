using System;
using System.Linq;

namespace ConexionDB.Data
{
    public class CiudadService
    {
        private readonly BancoContext _context;

        public CiudadService()
        {
            _context = new BancoContext();
        }

        public void CrearCiudad(Ciudad ciudad)
        {
            _context.Ciudades.Add(ciudad);
            _context.SaveChanges();
        }

        public Ciudad ObtenerCiudadPorId(int id)
        {
            return _context.Ciudades.FirstOrDefault(c => c.Id == id);
        }

        public void ActualizarCiudad(Ciudad ciudad)
        {
            _context.Ciudades.Update(ciudad);
            _context.SaveChanges();
        }

        public void EliminarCiudad(int id)
        {
            var ciudad = _context.Ciudades.FirstOrDefault(c => c.Id == id);
            if (ciudad != null)
            {
                _context.Ciudades.Remove(ciudad);
                _context.SaveChanges();
            }
        }
    }
}
