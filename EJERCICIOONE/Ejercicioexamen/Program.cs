
using System;

class Inventario
{
	// Variable global para el total de productos
	private static int totalProductos = 0;

	// Método para agregar productos
	public static void AgregarProductos(int cantidad)
	{
		if (cantidad <= 0)
		{
			Console.WriteLine("Debe agregar al menos 1 producto.");
			return;
		}
		totalProductos += cantidad;
		Console.WriteLine($"Se agregaron {cantidad} productos. Total actual: {totalProductos}");
	}

	// Método para retirar productos
	public static void RetirarProductos(int cantidad)
	{
		if (cantidad <= 0)
		{
			Console.WriteLine("Debe retirar al menos 1 producto.");
			return;
		}
		if (cantidad > totalProductos)
		{
			Console.WriteLine("No hay suficientes productos para retirar.");
		}
		else
		{
			totalProductos -= cantidad;
			Console.WriteLine($"Se retiraron {cantidad} productos. Total actual: {totalProductos}");
		}
	}

	// Método para consultar el inventario actual
	public static void ConsultarInventario()
	{
		Console.WriteLine($"Inventario actual: {totalProductos} productos.");
	}
}

class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("\nSeleccione una opción:");
			Console.WriteLine("1. Agregar productos");
			Console.WriteLine("2. Retirar productos");
			Console.WriteLine("3. Consultar inventario");
			Console.WriteLine("4. Salir");
			Console.Write("Opción: ");
			string opcion = Console.ReadLine() ?? "";

			switch (opcion)
			{
				case "1":
					Console.Write("Ingrese la cantidad a agregar: ");
					if (int.TryParse(Console.ReadLine(), out int cantidadAgregar))
					{
						Inventario.AgregarProductos(cantidadAgregar);
					}
					else
					{
						Console.WriteLine("Cantidad inválida.");
					}
					break;
				case "2":
					Console.Write("Ingrese la cantidad a retirar: ");
					if (int.TryParse(Console.ReadLine(), out int cantidadRetirar))
					{
						Inventario.RetirarProductos(cantidadRetirar);
					}
					else
					{
						Console.WriteLine("Cantidad inválida.");
					}
					break;
				case "3":
					Inventario.ConsultarInventario();
					break;
				case "4":
					Console.WriteLine("Saliendo...");
					return;
				default:
					Console.WriteLine("Opción no válida.");
					break;
			}
		}
	}
}
