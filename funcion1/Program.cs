//Crear un menu de opciones para el usuario, 
//donde pueda elegir entre las siguiente opciones:
// 1. Sumar dos numeros
// 2. Restar dos numeros
// 3. Multiplicar dos numeros
// 4. Dividir dos numeros
// 5. Salir

int num1, num2, resultado = 0, opcion;

while (true)
{
    
    //menu de opciones

    Console.WriteLine("\nMenu de opciones:");
    Console.WriteLine("1. Sumar dos numeros");
    Console.WriteLine("2. Restar dos numeros");
    Console.WriteLine("3. Multiplicar dos numeros");
    Console.WriteLine("4. Dividir dos numeros");
    Console.WriteLine("5. Salir");
    Console.WriteLine("Ingrese una opcion:");
    opcion = int.Parse(Console.ReadLine()!);


    if (opcion >= 1 && opcion <= 4)
    {
            Console.WriteLine("Ingrese el primer numero:");
            num1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese el segundo numero:");
        num2 = int.Parse(Console.ReadLine()!);

        switch (opcion)
        {
            case 1:
                resultado = suma(num1, num2);
                break;
            case 2:
                resultado = resta(num1, num2);
                break;
            case 3:
                resultado = multiplicacion(num1, num2);
                break;
            case 4:

                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    continue;
                }
                resultado = division(num1, num2);
                break;
        }
        Console.WriteLine($"Resultado: {resultado}");
        Console.WriteLine("Presiona Enter para continuar...");
        Console.ReadLine();
    }
        
    else if (opcion == 5)
    {
        salir();
        break;
    }

    else
    {
        Console.WriteLine("Opcion no valida");
    }
}

//suma

int suma(int a, int b)
{
    return a + b;
}


//resta

int resta (int a, int b)
{
    return a - b;
}

//multiplicacion

int multiplicacion (int a, int b)
{
    return a * b;
}

//division

int division (int a, int b)
 {

    return a / b;

 }

 //salir

void salir()
{
    Console.WriteLine("Gracias por usar el programa");
}