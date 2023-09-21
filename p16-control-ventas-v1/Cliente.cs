public class Cliente
{
    public string Nombre { get; set; }
    public string RFC { get; set; }
    public string Domicilio { get; set; }
    public string Correo { get; set; }
    public List<Venta> Ventas { get; set; }

    public Cliente(string nombre, string rfc, string domicilio, string correo, Venta ventas) => (Nombre, RFC, Domicilio, Correo, Ventas) = (nombre, rfc, domicilio, correo, new List<Venta> { ventas });

    // Método para agregar una venta a la lista de ventas del cliente
    public void AgregarVenta(Venta venta) => Ventas.Add(venta);

    public override string ToString() => $"Nombre: {Nombre}, RFC: {RFC}, Domicilio: {Domicilio}, Correo: {Correo}";
}