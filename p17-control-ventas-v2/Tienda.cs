public class Tienda{
    public string Nombre {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}   
    public List<Cliente> Clientes {get; set;} 
    
    public Tienda() => Clientes = new List<Cliente>();
    public Tienda(string nombre, string propietario, string domicilio) : this() => (Nombre, Propietario, Domicilio) = (nombre, propietario, domicilio);
    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);
    public double Total(){
        double total=0;
        foreach(Cliente cliente in Clientes)
            total = total + cliente.SubTotal();
        return total;
    }
    public double TotalVentas(){
        int total=0;
        foreach(Cliente cliente in Clientes)
            total = total + cliente.Ventas.Count();
        return total;
    }
    public override string ToString() => $"Nombre de la Tienda: {Nombre}\nPropietario de la Tienda: {Propietario}\nDomicilio de la tienda: {Domicilio}\n";
}