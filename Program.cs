using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Llamar a los métodos de los ejercicios aquí
        Ejercicio1_DimeSiEsPosiONega();
        Ejercicio2_ParODisparate();
        Ejercicio3_MayorDeEdadOChamaquito();
        Ejercicio4_MultiploDe5OQueLoPartaUnRayo();
        Ejercicio5_DescuentoPaLosViejitos();
        Ejercicio6_PasasteOReprobaste();
        Ejercicio7_QueDiaDeLaSemanaEsHoy();
        Ejercicio8_QuienEsElMasGrandeDeLosDos();
        Ejercicio9_QuienEsElMasGrandeDeLosTres();
        Ejercicio10_QueTipoDeAnguloEsEseVaina();
        Ejercicio11_CuantoLeTocaALaDGII();
        Ejercicio12_QueTipoDeNumerosSonEsos();
        Ejercicio13_AñoBisiestoONo();
        Ejercicio14_QueNotaTeSacaste();
        Ejercicio15_SePuedeHacerUnTrianguloConEso();
        Ejercicio16_CuantoTeRebajan();
        Ejercicio17_QueTipoDeTrianguloEsEse();
        Ejercicio18_QueCalorOMasFrioHace();
        Ejercicio19_QueTurnoEsEse();
        Ejercicio20_ComoEstaTuIMC();
    }

    public static void Ejercicio1_DimeSiEsPosiONega()
    {
        // Número positivo, negativo o cero
        Console.Write("Dime un número, a ver si es positivo, negativo o cero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 0)
        {
            Console.WriteLine("Ese número es positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("Ese número es negativo.");
        }
        else
        {
            Console.WriteLine("Ese número es cero, ni fu ni fa.");
        }
    }

    public static void Ejercicio2_ParODisparate()
    {
        // Número par o impar
        Console.Write("Dame un número entero, a ver si es par o disparate: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("Ese número es par.");
        }
        else
        {
            Console.WriteLine("Ese número es impar.");
        }
    }

    public static void Ejercicio3_MayorDeEdadOChamaquito()
    {
        // Mayor de edad
        Console.Write("Dime tu edad, a ver si eres mayor de edad o chamaquito: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }
        else
        {
            Console.WriteLine("Todavía eres un chamaquito.");
        }
    }

    public static void Ejercicio4_MultiploDe5OQueLoPartaUnRayo()
    {
        // Múltiplo de 5
        Console.Write("Dame un número, a ver si es múltiplo de 5 o que lo parta un rayo: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 5 == 0)
        {
            Console.WriteLine("Ese número es múltiplo de 5.");
        }
        else
        {
            Console.WriteLine("Ese número no es múltiplo de 5.");
        }
    }

    public static void Ejercicio5_DescuentoPaLosViejitos()
    {
        // Descuento por edad
        Console.Write("Dime tu edad, a ver si te doy descuento de viejito: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad > 60)
        {
            Console.WriteLine("Tienes descuento, mi viejo.");
        }
        else
        {
            Console.WriteLine("No tienes descuento.");
        }
    }

    public static void Ejercicio6_PasasteOReprobaste()
    {
        // Calificación aprobatoria
        Console.Write("Dime tu calificación (0-100), a ver si pasaste o reprobaste: ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        if (calificacion >= 60)
        {
            Console.WriteLine("Pasaste.");
        }
        else
        {
            Console.WriteLine("Reprobaste.");
        }
    }

    public static void Ejercicio7_QueDiaDeLaSemanaEsHoy()
    {
        // Día de la semana
        Console.Write("Dame un número del 1 al 7, a ver qué día de la semana es hoy: ");
        int numeroDia = Convert.ToInt32(Console.ReadLine());

        switch (numeroDia)
        {
            case 1:
                Console.WriteLine("Lunes, qué chercha.");
                break;
            case 2:
                Console.WriteLine("Martes, otro día más.");
                break;
            case 3:
                Console.WriteLine("Miércoles, mitad de semana.");
                break;
            case 4:
                Console.WriteLine("Jueves, ya casi es viernes.");
                break;
            case 5:
                Console.WriteLine("Viernes, llegó el fin de semana.");
                break;
            case 6:
                Console.WriteLine("Sábado, a disfrutar.");
                break;
            case 7:
                Console.WriteLine("Domingo, a descansar.");
                break;
            default:
                Console.WriteLine("Ese número no existe.");
                break;
        }
    }

    public static void Ejercicio8_QuienEsElMasGrandeDeLosDos()
    {
        // Número mayor entre dos
        Console.Write("Dame dos números, a ver quién es el más grande: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("El primer número es el más grande.");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("El segundo número es el más grande.");
        }
        else
        {
            Console.WriteLine("Son iguales, mi hermano.");
        }
    }

    public static void Ejercicio9_QuienEsElMasGrandeDeLosTres()
    {
        // Mayor entre tres números
        Console.Write("Dame tres números, a ver quién es el más grande: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int numero3 = Convert.ToInt32(Console.ReadLine());

        int mayor = numero1;

        if (numero2 > mayor)
        {
            mayor = numero2;
        }

        if (numero3 > mayor)
        {
            mayor = numero3;
        }

        Console.WriteLine("El número más grande es: " + mayor);
    }

    public static void Ejercicio10_QueTipoDeAnguloEsEseVaina()
    {
        // Clasificación de ángulos
        Console.Write("Dame un ángulo, a ver qué tipo de vaina es: ");
        double angulo = Convert.ToDouble(Console.ReadLine());

        if (angulo < 90)
        {
            Console.WriteLine("Ese ángulo es agudo.");
        }
        else if (angulo == 90)
        {
            Console.WriteLine("Ese ángulo es recto.");
        }
        else if (angulo > 90 && angulo < 180)
        {
            Console.WriteLine("Ese ángulo es obtuso.");
        }
        else if (angulo == 180)
        {
            Console.WriteLine("Ese ángulo es llano.");
        }
        else
        {
            Console.WriteLine("Ese ángulo no existe.");
        }
    }

    public static void Ejercicio11_CuantoLeTocaALaDGII()
    {
        // Cálculo de impuestos
        Console.Write("Dime tu salario, a ver cuánto le toca a la DGII: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        double impuestos = 0;

        if (salario < 10000)
        {
            impuestos = 0;
        }
        else if (salario >= 10000 && salario <= 30000)
        {
            impuestos = salario * 0.10;
        }
        else
        {
            impuestos = salario * 0.20;
        }

        Console.WriteLine("Le toca a la DGII: " + impuestos);
    }

    public static void Ejercicio12_QueTipoDeNumerosSonEsos()
    {
        // Clasificación de números
        Console.Write("Dame tres números, a ver qué tipo de números son: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int numero3 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > 0 && numero2 > 0 && numero3 > 0)
        {
            Console.WriteLine("Todos son positivos, mi hermano.");
        }
        else if (numero1 < 0 && numero2 < 0 && numero3 < 0)
        {
            Console.WriteLine("Todos son negativos, pana.");
        }
        else if (numero1 == 0 || numero2 == 0 || numero3 == 0)
        {
            Console.WriteLine("Hay un cero por ahí, socio.");
        }
        else
        {
            Console.WriteLine("Son mixtos.");
        }
    }

    public static void Ejercicio13_AñoBisiestoONo()
    {
        // Verificación de año bisiesto
        Console.Write("Dame un año, a ver si es bisiesto o no: ");
        int anio = Convert.ToInt32(Console.ReadLine());

        if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
        {
            Console.WriteLine("Ese año es bisiesto.");
        }
        else
        {
            Console.WriteLine("Ese año no es bisiesto.");
        }
    }

    public static void Ejercicio14_QueNotaTeSacaste()
    {
        // Conversión de calificaciones
        Console.Write("Dame tu calificación (0-100), a ver qué nota te sacaste: ");
        int calificacion = Convert.ToInt32(Console.ReadLine());

        if (calificacion >= 90 && calificacion <= 100)
        {
            Console.WriteLine("Te sacaste una A.");
        }
        else if (calificacion >= 80 && calificacion <= 89)
        {
            Console.WriteLine("Te sacaste una B.");
        }
        else if (calificacion >= 70 && calificacion <= 79)
        {
            Console.WriteLine("Te sacaste una C.");
        }
        else if (calificacion >= 60 && calificacion <= 69)
        {
            Console.WriteLine("Te sacaste una D.");
        }
        else if (calificacion >= 0 && calificacion <= 59)
        {
            Console.WriteLine("Te sacaste una F.");
        }
        else
        {
            Console.WriteLine("Esa calificación no existe.");
        }
    }

    public static void Ejercicio15_SePuedeHacerUnTrianguloConEso()
    {
        // Comparación de tres longitudes
        Console.Write("Dame tres longitudes, a ver si se puede hacer un triángulo: ");
        double longitud1 = Convert.ToDouble(Console.ReadLine());
        double longitud2 = Convert.ToDouble(Console.ReadLine());
        double longitud3 = Convert.ToDouble(Console.ReadLine());

        if (longitud1 + longitud2 > longitud3 && longitud1 + longitud3 > longitud2 && longitud2 + longitud3 > longitud1)
        {
            Console.WriteLine("Se puede hacer un triángulo, socio.");
        }
        else
        {
            Console.WriteLine("No se puede hacer un triángulo, mi hermano.");
        }
    }

    public static void Ejercicio16_CuantoTeRebajan()
    {
        // Calculadora de descuentos
        Console.Write("Dame el precio del producto, a ver cuánto te rebajan: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        double descuento = 0;

        if (precio >= 50 && precio <= 100)
        {
            descuento = precio * 0.05;
        }
        else if (precio > 100)
        {
            descuento = precio * 0.10;
        }

        Console.WriteLine("Te rebajan: " + descuento);
        Console.WriteLine("El precio final es: " + (precio - descuento));
    }

    public static void Ejercicio17_QueTipoDeTrianguloEsEse()
    {
        // Tipo de triángulo
        Console.Write("Dame tres longitudes, a ver qué tipo de triángulo es: ");
        double longitud1 = Convert.ToDouble(Console.ReadLine());
        double longitud2 = Convert.ToDouble(Console.ReadLine());
        double longitud3 = Convert.ToDouble(Console.ReadLine());

        if (longitud1 == longitud2 && longitud2 == longitud3)
        {
            Console.WriteLine("Es un triángulo equilátero.");
        }
        else if (longitud1 == longitud2 || longitud1 == longitud3 || longitud2 == longitud3)
        {
            Console.WriteLine("Es un triángulo isósceles.");
        }
        else
        {
            Console.WriteLine("Es un triángulo escaleno.");
        }
    }

    public static void Ejercicio18_QueCalorOMasFrioHace()
    {
        // Evaluación de temperatura
        Console.Write("Dame la temperatura, a ver qué calor o más frío hace: ");
        double temperatura = Convert.ToDouble(Console.ReadLine());

        if (temperatura < 0)
        {
            Console.WriteLine("Hace un frío del diablo, socio.");
        }
        else if (temperatura >= 0 && temperatura <= 20)
        {
            Console.WriteLine("Está fresquito.");
        }
        else if (temperatura >= 21 && temperatura <= 30)
        {
            Console.WriteLine("Está agradable.");
        }
        else
        {
            Console.WriteLine("Hace un calor del carajo, qué vaina.");
        }
    }

    public static void Ejercicio19_QueTurnoEsEse()
    {
        // Conversión de horas a turnos
        Console.Write("Dame la hora (0-23), a ver qué turno es: ");
        int hora = Convert.ToInt32(Console.ReadLine());

        if (hora >= 6 && hora <= 11)
        {
            Console.WriteLine("Es de mañana.");
        }
        else if (hora >= 12 && hora <= 17)
        {
            Console.WriteLine("Es de tarde.");
        }
        else if (hora >= 18 && hora <= 23)
        {
            Console.WriteLine("Es de noche, socio.");
        }
        else
        {
            Console.WriteLine("Es de madrugada.");
        }
    }

    public static void Ejercicio20_ComoEstaTuIMC()
    {
        // Clasificación de IMC
        Console.Write("Dame tu peso (kg) y tu altura (m), a ver cómo está tu IMC: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        if (imc < 18.5)
        {
            Console.WriteLine("Estás bajo de peso, mi hermano.");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Estás normal.");
        }
        else if (imc >= 25 && imc <= 29.9)
        {
            Console.WriteLine("Estás sobrepeso.");
        }
        else
        {
            Console.WriteLine("Estás obeso.");
        }
    }
}
