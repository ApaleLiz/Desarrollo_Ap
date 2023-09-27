Academia miacademia = new Academia
{
    Nombre = "Academia Santos Laguna",
    Propietario = "Lizbeth Apale",
    Domicilio = "Av. Mexico"
};

// Agregar jugadores a la academia
miacademia.AgregarJugador(new Jugador { Nombre = "Erick Sanchez", AñoNac = 2006, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Paola Roque", AñoNac = 2009, Sexo = 'M', Becado = false });
miacademia.AgregarJugador(new Jugador { Nombre = "Fatima Castro", AñoNac = 2006, Sexo = 'M', Becado = false });
miacademia.AgregarJugador(new Jugador { Nombre = "Andres Flores", AñoNac = 2009, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Melida Matias", AñoNac = 2006, Sexo = 'M', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Felipe de Jesus", AñoNac = 2010, Sexo = 'H', Becado = true });
miacademia.AgregarJugador(new Jugador { Nombre = "Mauricio Lopez", AñoNac = 2012, Sexo = 'H', Becado = false });


// Agregar categorías a los jugadores
miacademia.AgregarCategoria(new Categoria { Nombre = "Junior A", RangoInicial = 2006, RangoFinal = 2008, Costo = 1250 });
miacademia.AgregarCategoria(new Categoria { Nombre = "Junior B", RangoInicial = 2009, RangoFinal = 2011, Costo = 850 });
miacademia.AgregarCategoria(new Categoria { Nombre = "Pony A", RangoInicial = 2012, RangoFinal = 2014, Costo = 700 });

// Asignar jugadores a categorías
miacademia.AsignarJugadoresACategorias();

// Generar el reporte
Console.WriteLine("-----------REPORTE DEL CLUB DEPORTIVO-------\n");
Console.WriteLine($"Nombre: {miacademia.Nombre}");
Console.WriteLine($"Propietario: {miacademia.Propietario}");
Console.WriteLine($"Domicilio: {miacademia.Domicilio}");

Console.WriteLine($"\nTotal de Categorias: {miacademia.Categorias.Count}");
Console.WriteLine($"Total de Hombres: {miacademia.Jugadores.Count(j => j.Sexo == 'H')}");
Console.WriteLine($"Total de Mujeres: {miacademia.Jugadores.Count(j => j.Sexo == 'M')}");

Console.WriteLine("\n>> Datos generales de las Categorias");
foreach (var categoria in miacademia.Categorias)
{
    Console.WriteLine(categoria.ToString());
}

Console.WriteLine("\n>> Jugadores por Categoria:\n");
foreach (var categoria in miacademia.Categorias)
{
    Console.WriteLine($"> {categoria.Nombre} - {categoria.RangoInicial}-{categoria.RangoFinal}");

    foreach (var jugador in miacademia.Jugadores)
    {
        if (jugador.Categorias.Any(c => c.Nombre == categoria.Nombre))
        {
            Console.WriteLine(jugador.ToString());
        }
    }

    var subtotal = miacademia.Jugadores
        .Where(j => j.Categorias.Any(c => c.Nombre == categoria.Nombre) && !j.Becado)
        .Sum(j => categoria.Costo);

    Console.WriteLine($"- Subtotal : ${subtotal:F2}\n");
}

var totalIngresos = miacademia.Jugadores
    .Where(j => !j.Becado)
    .Sum(j => j.Categorias.Sum(c => c.Costo));

Console.WriteLine($">> Total : ${totalIngresos:F2}\n");