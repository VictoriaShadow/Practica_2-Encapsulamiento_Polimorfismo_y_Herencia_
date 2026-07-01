using MarketCraft;

List <ItemMercado> itemMercados = new List<ItemMercado>();

itemMercados.Add(new Pocion() { Nombre = "Poción Vida", PrecioBase = 50, Stock = 10 });
itemMercados.Add(new Pocion() { Nombre = "Poción Mana", PrecioBase = 30, Stock = 4 });
itemMercados.Add(new MineralRaro() { Nombre = "Rubí", PrecioBase = 100, Stock = 8, FactorEscasez = 2 });
itemMercados.Add(new MineralRaro() { Nombre = "Diamante", PrecioBase = 200, Stock = 3, FactorEscasez = 2 });

int[] cantidades = { 3, 6, 2, 2};

for (int i = 0; i < itemMercados.Count; i++)
{
    string mensaje = itemMercados[i].CotizarVenta(cantidades[i]);
    Console.WriteLine(mensaje);
}

Console.ReadLine();