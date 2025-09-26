using System;

class Cajero
{
    static double saldo = 0; // global

    public static void Depositar(double monto)
    {
        saldo += monto;
        Console.WriteLine($"Depósito realizado. Saldo: {saldo}");
    }

    public static void Retirar(double monto)
    {
        if (monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro exitoso. Saldo: {saldo}");
        }
        else
        {
            Console.WriteLine("Fondos insuficientes.");
        }
    }

    public static void ConsultarSaldo()
    {
        Console.WriteLine($"Saldo disponible: {saldo}");
    }
}