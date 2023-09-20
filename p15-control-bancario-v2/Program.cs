Console.Clear();

Banco mibanco = new Banco("Ricky Ricon SA de CV","La Chingada 2000");
mibanco.AgregarCliente(new Cliente("Nadia" , "Zamarrón"));
mibanco.AgregarCliente(new Cliente("Jose Manuel" , "De Lara"));
mibanco.AgregarCliente(new Cliente("Violeta","Calderón"));
mibanco.AgregarCliente(new Cliente("Luis","Maldonado"));

mibanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(1200,0.30));
mibanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(10000,500));
mibanco.Clientes[1].AgregarCuenta(new CuentaDeAhorro(800,0.40));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(3000,0.50));
mibanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(2000,500));
mibanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(1000,0.40));

mibanco.Clientes[0].Cuentas[0].Retira(1000);
mibanco.Clientes[1].Cuentas[0].Retira(400);
mibanco.Clientes[1].Cuentas[0].Deposita(1000);
mibanco.Clientes[2].Cuentas[1].Retira(3500);

Console.WriteLine("\nReporte del Banco\n");
Console.WriteLine(mibanco.ToString());
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente: {cl.ToString()} - Cuenta:{cl.Cuentas.Count}");
    foreach(CuentaBancaria cta in cl.Cuentas){
        Console.Write((cta is CuentaDeCheques)? "Cheques":"Ahorro");
        if(cta is CuentaDeAhorro) (cta as CuentaDeAhorro).CalcularInteres();
        Console.WriteLine($"-Saldo : {cta.Saldo}");
    }
}