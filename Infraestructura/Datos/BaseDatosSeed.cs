using Core.Entidades;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infraestructura.Datos
{
    public class BaseDatosSeed
    {
        public static async Task SeedAsync(ApplicationDbContext context, ILoggerFactory loggerFactory) {
            try
            {
                //Si no hay datos...
                if (!context.Pais.Any()) {
                    var paisData = File.ReadAllText("../Infraestructura/Datos/SeedData/paises.json");
                    var paises = JsonSerializer.Deserialize<List<Pais>>(paisData);

                    foreach (var item in paises) {
                        await context.Pais.AddAsync(item); //agrega item a la BD
                    }

                    await context.SaveChangesAsync();

                }

                if (!context.Categoria.Any())
                {
                    var categoriaData = File.ReadAllText("../Infraestructura/Datos/SeedData/categorias.json");
                    var categorias = JsonSerializer.Deserialize<List<Categoria>>(categoriaData);

                    foreach (var item in categorias)
                    {
                        await context.Categoria.AddAsync(item); //agrega item a la BD
                    }

                    await context.SaveChangesAsync();

                }

                if (!context.Lugar.Any())
                {
                    var lugaresData = File.ReadAllText("../Infraestructura/Datos/SeedData/lugares.json");
                    var lugares = JsonSerializer.Deserialize<List<Lugar>>(lugaresData);

                    foreach (var item in lugares)
                    {
                        await context.Lugar.AddAsync(item); //agrega item a la BD
                    }

                    await context.SaveChangesAsync();

                }

            }
            catch (System.Exception ex) {
                var logger = loggerFactory.CreateLogger<BaseDatosSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}
