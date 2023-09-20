public class Cliente {
public String Nombre {get; set;}
public String Apeido {get; set;}
public List<CuentaBancaria> Cuentas {get; set;}
public Cliente() => Cuentas = new List<CuentaBancaria>();
public Cliente(string nombre, string apeido) : this() => (Nombre,Apeido) = (nombre, apeido);
public void AgregarCuenta(CuentaBancaria cuenta) => Cuentas.Add(cuenta);
public override string ToString() => $"{Nombre}, {Apeido}";
}