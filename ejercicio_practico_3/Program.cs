using System;

// Juego de Adivinanza Mejorado
// Usa variables globales para el número secreto y el contador de intentos
class Program
{
    static int numeroSecreto; // Variable global para el número secreto
    static int intentos = 0; // Variable global para contar los intentos

    static void Main(string[] args)
    {
        // Genera un número secreto aleatorio entre 1 y 100
        Random rnd = new Random();
        numeroSecreto = rnd.Next(1, 101); // Número secreto entre 1 y 100
        Console.WriteLine("¡Bienvenido al juego de adivinanza!");
        // Llama al método que pide la adivinanza al usuario
        PedirAdivinanza();
    }

    // Método que pide al usuario que adivine el número
    static void PedirAdivinanza()
    {
        while (true)
        {
            Console.Write("Adivina el número (entre 1 y 100): ");
            // Variable local para guardar el intento del usuario
            int intentoUsuario = Convert.ToInt32(Console.ReadLine());
            // Llama al método que verifica el intento y muestra mensajes
            VerificarIntento(intentoUsuario);
            // Si el usuario adivinó, termina el ciclo
            if (intentoUsuario == numeroSecreto)
                break;
        }
    }

    // Método que verifica el intento y muestra mensajes de acierto o error
    static void VerificarIntento(int intento)
    {
        intentos++; // Aumenta el contador global de intentos
        if (intento == numeroSecreto)
        {
            Console.WriteLine($"¡Correcto! Adivinaste el número en {intentos} intentos.");
        }
        else if (intento < numeroSecreto)
        {
            Console.WriteLine("Incorrecto. El número secreto es mayor.");
        }
        else
        {
            Console.WriteLine("Incorrecto. El número secreto es menor.");
        }
    }
}
