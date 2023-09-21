﻿// Control Ventas V1

// Probar Clase Cliente
Venta venta01 = new Venta("Articulo 15", 5, 19.99);
Cliente cliente01 = new Cliente("Lizbeth Apale", "LAR902809R7", "Angeles 18","rr@gmail.com", venta01);
Console.WriteLine($"\nDatos del Cliente : {cliente01.ToString()}");

Venta venta02 = new Venta("Articulo 22", 1, 45.50);
Cliente cliente02 = new Cliente("Mare Duran", "MADU921219M1", "Av. México 198","san@gmail.com", venta02);
Console.WriteLine($"Datos del Cliente : {cliente02.ToString()}");

Venta venta03 = new Venta("Articulo 13", 3, 30.00);
Cliente cliente03 = new Cliente("Lulu Valle", "VAVL000811H6", "CNOP 13","luluvalle@gmail.com", venta03);
Console.WriteLine($"Datos del Cliente : {cliente03.ToString()}");

// Probar la Clase Tienda
Tienda mitienda = new Tienda("Papeleria", "Violeta Calde", "la mezquita");
mitienda.AgregarCliente(cliente01);
mitienda.AgregarCliente(cliente02);
mitienda.AgregarCliente(cliente03);
Venta venta04 = new Venta("Articulo 2", 2, 9.50);
mitienda.AgregarCliente(new Cliente ("Pepe Perez", "PEPP800315H3", "La Florida 106","pepep@gmail.com", venta04)); //new Venta()));
Console.WriteLine(mitienda.ToString());

// Probar la Clase Venta
mitienda.GenerarReporte();