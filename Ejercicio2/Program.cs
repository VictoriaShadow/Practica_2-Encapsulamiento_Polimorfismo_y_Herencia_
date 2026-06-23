using FactoryAlert;

List<Sensor> sensores = new List<Sensor>();

sensores.Add(new SensorTemperatura { Id = 1, Estado = "Ok" });
sensores.Add(new SensorTemperatura { Id = 2, Estado = "Ok" });
sensores.Add(new SensorPresion { Id = 3, Estado = "Ok", HistorialLecturas = new List<double>() });
sensores.Add(new SensorPresion { Id = 4, Estado = "Ok", HistorialLecturas = new List<double>() });

double[] lecturas = { 70, 80, 90 };

foreach (double valor in lecturas)
{
    Console.WriteLine($"Lectura: {valor}");

    foreach (var Sensor in sensores)
    {
        string mensaje = Sensor.EvaluarLectura(valor);
        Console.WriteLine(mensaje);
    }

    Console.WriteLine();
}

Console.ReadLine();
