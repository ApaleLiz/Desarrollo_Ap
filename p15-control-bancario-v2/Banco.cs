//CLASE BANCO
public class Banco {
    public string Nombre {get; private set;}
    public string Domicilio {get; private set;}
    public List<Cliente> Clientes {get; private set;}
    public Banco() => Clientes = new List<Cliente>();
    public Banco(string nombre, string domicilio) : this() => (Nombre,Domicilio) = (nombre,domicilio);
    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);
    public override string ToString() => $"{Nombre}, {Domicilio}";
}