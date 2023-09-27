public class Academia
{
    public string Nombre { get; set; }
    public string Propietario { get; set; }
    public string Domicilio { get; set; }
    public List<Jugador> Jugadores { get; set; }
    public List<Categoria> Categorias { get; set; }

    public Academia()
    {
        Jugadores = new List<Jugador>();
        Categorias = new List<Categoria>();
    }

    public Academia(string nombre, string propietario, string domicilio) => 
    (Nombre, Propietario, Domicilio) = (nombre, propietario, domicilio);

    public void AgregarJugador(Jugador jugador) => Jugadores.Add(jugador);
    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public void AsignarJugadoresACategorias()
    {
        foreach (var jugador in Jugadores)
        {
            foreach (var categoria in Categorias)
            {
                if (jugador.AñoNac >= categoria.RangoInicial && jugador.AñoNac <= categoria.RangoFinal)
                {
                    jugador.AgregarCategoria(categoria);
                }
            }
        }
    }
}
