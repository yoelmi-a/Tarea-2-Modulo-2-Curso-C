string opcion;
do
{
    Console.WriteLine("Calculadora");
    Console.WriteLine("1 - Suma");
    Console.WriteLine("2 - Resta");
    Console.WriteLine("3 - Multiplicación");
    Console.WriteLine("4 - División");
    Console.WriteLine("5 - Potencia");
    Console.WriteLine("6 - Salir");

    opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Escriba el primer número");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número");
            float num2 = float.Parse(Console.ReadLine());
            float resultado = SumaOResta(num1, num2, "suma");
            Console.WriteLine($"{num1} + {num2} = {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();
            break;
        case "2":
            Console.Clear();
            Console.WriteLine("Escriba el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número");
            num2 = float.Parse(Console.ReadLine());
            resultado = SumaOResta(num1, num2, "resta");
            Console.WriteLine($"{num1} - {num2} = {resultado}");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();
            break;
        case "3":
            Console.Clear();
            Console.WriteLine("Escriba el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine("Escriba el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo número");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Escriba el número base");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escriba la potencia");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para volver al menú principal");
            Console.ReadKey();
            Console.Clear();
            break;
        default:
            Console.Clear();
            break;
    }
}while (opcion != "6");

static float SumaOResta(float n1, float n2, string operacion)
{
    if(operacion == "suma")
    {
        return n1 + n2;
    }
    else
    {
        return n1 - n2;
    }
}
