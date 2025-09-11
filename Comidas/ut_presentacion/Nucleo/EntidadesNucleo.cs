using lib_dominio.Entidades;
namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Comidas? Comidas()
        {
            var entidad = new Comidas();
            entidad.Nombre = "Pruebas-";
            entidad.Tiempo = DateTime.Now;
            entidad.Calorias = "Prueba";
            entidad.Pais = "Prueba";
            entidad.Precio = 3.8m;
            return entidad;
        }
    }
}