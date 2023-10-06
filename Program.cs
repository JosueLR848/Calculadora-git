class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora básica");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Por favor, elige una opción (1-5): ");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingresa el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: División por cero no permitida.");
                            continue;
                        }
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);
            }
            else if (opcion == 5)
            {
                Console.WriteLine("¡Hasta luego!");
                break;
            }
            else
            {
                Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
            }
        }
    }
}