using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface ILugarRepositorio
    {
        //Firmas de nuestros metodos

        Task<Lugar> GetLugarAsync(int id);

        //solamente lectura
        Task<IReadOnlyList<Lugar>> GetLugaresAsync();


    }
}
