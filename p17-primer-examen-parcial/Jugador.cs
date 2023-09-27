public class Jugador
{
    public string Nombre { get; set; }
    public int AñoNac { get; set; }
    public char Sexo { get; set; }
    public bool Becado { get; set; }
    public List<Categoria> Categorias { get; set; }

    public Jugador() => Categorias = new List<Categoria>();

    public Jugador(string nombre, int añonac, char sexo, bool becado) : this() =>
        (Nombre, AñoNac, Sexo, Becado) = (nombre, añonac, sexo, becado);

    public void AgregarCategoria(Categoria categoria) => Categorias.Add(categoria);

    public override string ToString() => $"Nombre: {Nombre,-20} AñoNac: {AñoNac,-12} Sexo: {Sexo,-25} Becado: {Becado}";
}