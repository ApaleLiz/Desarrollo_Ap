﻿// Control Ventas V2

Tienda mitienda = new Tienda{Nombre="Panadería", Propietario="Lizbeth A", Domicilio="Av.Mex"};

//Agregar cliente a la tienda
mitienda.AgregarCliente(new Cliente {Nombre="Paola Roque",RFC="TERE800315T6",Domicilio="Gavilanes",Correo="Paolap@gmail.com"});
mitienda.AgregarCliente(new Cliente {Nombre="Amelia CRuz",RFC="MANI921219D3",Domicilio="Lomas",Correo="Amelia@gmail.com"});
mitienda.AgregarCliente(new Cliente {Nombre="Lourdes Vazques",RFC="MILK000811L8",Domicilio="Minas",Correo="Lourdes@gmail.com"});
mitienda.AgregarCliente(new Cliente {Nombre="Karla Vega",RFC="LOLI860911G4",Domicilio="Toronto",Correo="Kar@gmail.com"});

// Agregar ventas a los Clientes 
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo=" Dona de Chocolate", Cantidad=45, Precio=10});
mitienda.Clientes[0].AgregarVenta(new Venta {Articulo="Dona Glaseada", Cantidad=25, Precio=12});
mitienda.Clientes[1].AgregarVenta(new Venta {Articulo="Canelas", Cantidad=20, Precio=17});
mitienda.Clientes[2].AgregarVenta(new Venta {Articulo="Conchas", Cantidad=30, Precio=15});
mitienda.Clientes[3].AgregarVenta(new Venta {Articulo="Varquillo", Cantidad=25, Precio=20});
mitienda.Clientes[3].AgregarVenta(new Venta {Articulo="Orjitas", Cantidad=15, Precio=18});

// Reporte
Console.Clear();
Console.WriteLine("Reporte de Ventas de la Tienda\n");
Console.WriteLine(mitienda.ToString());
Console.WriteLine($"Total de Clietes: {mitienda.Clientes.Count()}");
Console.WriteLine($"Total de Ventas : {mitienda.TotalVentas()}");

Console.WriteLine("\n>> Datos generales de los Clientes: \n");
foreach (Cliente cliente in mitienda.Clientes){
    Console.WriteLine(cliente.ToString());
}

Console.WriteLine("\n>> Ventas de los clientes: \n");
foreach (Cliente cliente in mitienda.Clientes){
    Console.WriteLine($"\n> {cliente.Nombre} - {cliente.RFC} - ({cliente.Ventas.Count()})\n");
    foreach (Venta venta in cliente.Ventas)
        Console.WriteLine(venta.ToString());
    Console.WriteLine($"\n- Subtotal : {cliente.SubTotal(),46:c2}\n");
}
Console.WriteLine($"\n\n- Total : {mitienda.Total(), 51:c2}\n");