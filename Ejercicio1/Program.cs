using SmartToll;

List<Vehiculo> vehiculos  = new List<Vehiculo>();

vehiculos.Add(new Particular { Patente = "016SY", SaldoEnCuenta = 500 });
vehiculos.Add(new Particular { Patente = "NVZ087", SaldoEnCuenta = 50 });
vehiculos.Add(new Camion { Patente = "AB123CD", SaldoEnCuenta = 1000, Ejes = 4 });
vehiculos.Add(new Camion { Patente = "AA094YA", SaldoEnCuenta = 100, Ejes = 6 });

decimal tarifaBase = 100;

foreach (var Vehiculo in vehiculos)
{
    string mensaje = Vehiculo.PagarPeaje(tarifaBase);
    Console.WriteLine($"{Vehiculo.Patente}: {mensaje}");
}
Console.ReadLine();