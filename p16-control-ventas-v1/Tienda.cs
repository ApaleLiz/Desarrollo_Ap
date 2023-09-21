public class Tienda{
    public string Nombre { get; set; }
    public string Propietario { get; set; }
    public string Domicilio { get; set; }    
    public List<Cliente>Clientes{ get; set;}

    public Tienda() => Clientes = new List<Cliente>();
    public Tienda(string nombre, string propietario, string domicilio) : this() => (Nombre, Propietario, Domicilio) = (nombre, propietario, domicilio);

    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);   

    public override string ToString() => $"Nombre de la Tienda: {Nombre}, Propietario de la Tienda: {Propietario}, Domicilio de la tienda: {Domicilio}\n";

     // Método para generar el informe de la tienda con todos los datos 
    public void GenerarReporte()
    {
        Console.WriteLine("**********      Reporte de la Tienda      **********\n");

        Console.WriteLine("Los datos de la tienda son:");
        Console.WriteLine(this.ToString());
        Console.WriteLine($"La Tienda Tiene: {Clientes.Count} clientes\n");

        // Ciclo para mostrar el cliente, la venta y el subtotal de la compra 
        decimal totalVentasTienda = 0;
        foreach (Cliente cl in Clientes)
        {
            Console.WriteLine($"Cliente: {cl.ToString()}");

            decimal subtotalCliente = 0;
            foreach (Venta venta in cl.Ventas)
            {
                Console.WriteLine($"Venta: {venta.ToString()}");
                subtotalCliente += venta.CalcularTotal();
            }
            Console.WriteLine($"Subtotal Cliente: ${subtotalCliente}\n");
            totalVentasTienda += subtotalCliente;
        }
        Console.WriteLine($"--------------------------------------------------");
        Console.WriteLine($"\nTotal de Ventas de la Tienda: ${totalVentasTienda}");
    }
}