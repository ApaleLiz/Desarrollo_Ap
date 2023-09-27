public class Categoria
{
    public string Nombre { get; set; }
    public int RangoInicial { get; set; }
    public int RangoFinal { get; set; }
    public double Costo { get; set; }

    public override string ToString() => $"{Nombre,-20} Rango: {RangoInicial}-{RangoFinal} Costo: ${Costo:F2}";
}