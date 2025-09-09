namespace lib_dominio.Entidades
{
    public class Comidas
    {
        public int Id { get; set; }
        public String? Nombre { get; set; }
        public DateTime Tiempo { get; set; }
        public String? Calorias { get; set; }
        public String? Pais { get; set; }
        public decimal Precio { get; set; }
    }
}
