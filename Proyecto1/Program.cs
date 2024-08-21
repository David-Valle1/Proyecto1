// See https://aka.ms/new-console-template for more information

using System;

class Mercadito
{
    static void Main()
    {
        Console.WriteLine("Bienvenido");
        Console.WriteLine("Por favor ingrese su nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Por favor ingrese su edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elija la categoria del producto");
        Console.WriteLine("1. Bebidas");
        Console.WriteLine("2. Snacks");
        Console.WriteLine("3. Lacteos");
        string Categoria=Console.ReadLine();  
        if (Categoria == "1")
        {
            Console.WriteLine("1. Coca cola");
            Console.WriteLine("2. Pepsi");
            Console.WriteLine("3. Fanta");
            Console.WriteLine("4. Fresca");
            Console.WriteLine("5. Big Cola");
            string Bebida=Console.ReadLine();

            if (Bebida == "1")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_bebida = Console.ReadLine();
                if (T_bebida == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Coca cola Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();

                }
                else if (T_bebida == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Coca cola Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Coca cola Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            else if (Bebida == "2")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_bebida = Console.ReadLine();

                if (T_bebida == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de pepsi Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de pepsi Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 29;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de pepsi Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 38;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }
            else if (Bebida == "3")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_bebida = Console.ReadLine();
                if (T_bebida == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Fanta Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Fanta Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Fanta Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }
            else if (Bebida == "4")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_bebida = Console.ReadLine();
                if (T_bebida == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Fresca Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Fresca Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 37;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Fresca Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 48;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }
            else if (Bebida == "5")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_bebida = Console.ReadLine();
                if (T_bebida == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Big Cola Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Big Cola Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 22;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_bebida == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Big Cola Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal1 = Cantidad * 28;
                    Console.WriteLine($"Subtotal:  {SubTotal1:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal1 * 0.30;
                        double Total_D = SubTotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }


        }
        else if (Categoria == "2")
        {
            Console.WriteLine("1. Doritos");
            Console.WriteLine("2. Cheetos");
            Console.WriteLine("3. Zambos");
            Console.WriteLine("4. Yummies");
            Console.WriteLine("5. Yuquitas");
            string Snacks = Console.ReadLine();

            if (Snacks == "1")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_Snack = Console.ReadLine();
                if (T_Snack == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Doritos Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 5;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Doritos Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 10;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Doritos Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2- Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }

            }
            else if (Snacks == "2")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_Snack = Console.ReadLine();

                if (T_Snack == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Cheetos Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 8;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Cheetos Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Cheetos Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 22;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }
            else if (Snacks == "3")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_Snack = Console.ReadLine();
                if (T_Snack == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Zambos Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 5;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Zambos Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Zambos Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }
            else if (Snacks == "4")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_Snack = Console.ReadLine();
                if (T_Snack == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Yummies Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 12;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Yummies Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Yummies Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 48;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }


            }
            else if (Snacks == "5")
            {
                Console.WriteLine("1. Normal");
                Console.WriteLine("2. Medio");
                Console.WriteLine("3. Grande");
                string T_Snack = Console.ReadLine();
                if (T_Snack == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de Yuquitas Normal acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 3;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de Yuquitas Medio acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 12;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Snack == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de Yuquitas Grande acomprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal2 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {SubTotal2:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal2 * 0.30;
                        double Total_D = SubTotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();

                }


            }


        }
        else if (Categoria == "3")
        {
            Console.WriteLine("1. Leche");
            Console.WriteLine("2. Queso");
            Console.WriteLine("3. Yogur");
            Console.WriteLine("4. Mantequilla");
            Console.WriteLine("5. Crema");
            string Lacteos = Console.ReadLine();

            if (Lacteos == "1")
            {
                Console.WriteLine("1. Litro");
                Console.WriteLine("2. Medio Litro");
                Console.WriteLine("3. Cuarto de Litro");
                string T_Lacteo = Console.ReadLine();
                if (T_Lacteo == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de litros de Leche a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de medios litros de Leche a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 12;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de cuartos de litro de Leche a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 7;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            else if (Lacteos == "2")
            {
                Console.WriteLine("1. Libra");
                Console.WriteLine("2. Media Libra");
                Console.WriteLine("3. Cuarto de Libra");
                string T_Lacteo = Console.ReadLine();
                if (T_Lacteo == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de libras de Queso a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 50;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de medias libras de Queso a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 28;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de cuartos de libra de Queso a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            else if (Lacteos == "3")
            {
                Console.WriteLine("1. Litro");
                Console.WriteLine("2. Medio Litro");
                Console.WriteLine("3. Cuarto de Litro");
                string T_Lacteo = Console.ReadLine();
                if (T_Lacteo == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de litros de Yogur a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de medios litros de Yogur a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 17;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de cuartos de litro de Yogur a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 9;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            else if (Lacteos == "4")
            {
                Console.WriteLine("1. Libra");
                Console.WriteLine("2. Media Libra");
                Console.WriteLine("3. Cuarto de Libra");
                string T_Lacteo = Console.ReadLine();
                if (T_Lacteo == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de libras de Mantequilla a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de medias libras de Mantequilla a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de cuartos de libra de Mantequilla a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 12;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
            else if (Lacteos == "5")
            {
                Console.WriteLine("1. Litro");
                Console.WriteLine("2. Medio Litro");
                Console.WriteLine("3. Cuarto de Litro");
                string T_Lacteo = Console.ReadLine();
                if (T_Lacteo == "1")
                {
                    Console.WriteLine("Ingrese la cantidad de litros de Crema a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "2")
                {
                    Console.WriteLine("Ingrese la cantidad de medios litros de Crema a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
                else if (T_Lacteo == "3")
                {
                    Console.WriteLine("Ingrese la cantidad de cuartos de litro de Crema a comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int SubTotal3 = Cantidad * 13;
                    Console.WriteLine($"Subtotal:  {SubTotal3:F2}");
                    if (Edad > 59)
                    {
                        double Descuento = SubTotal3 * 0.30;
                        double Total_D = SubTotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad:  {Total_D:F2}");
                    }
                    Console.ReadKey();
                }
            }
        }

    }
}
