// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Hello, World!"); // HICE UN .NET GENERATE ASSETS AND DEBUGG PARA PODER GENERAR LA CARPETA .vscode PARA CONFIGURAR EL JSON
// int a = 1;
// int b;
// Console.WriteLine("El valor de a es: "+a);
// Console.WriteLine("El valor de b es: "+b);

string Ingresar;
Console.WriteLine("Ingrese un numero: ");
Ingresar = Console.ReadLine();
int NumeroInvertido = Invertir(Ingresar);
Console.WriteLine("Numero invertido: "+NumeroInvertido);
Console.WriteLine("Resultado: "+Calculadora(2, -10));



static int Invertir(string s){
    int Aux, NumeroInvertido = 0;
    if(int.TryParse(s, out Aux) && Aux > 0)
    {
        while(Aux != 0)
        {
            NumeroInvertido = NumeroInvertido*10 + Aux%10;
            Aux/=10;
        }
    }else{
        Console.WriteLine("Lo que se ingreso no es un numero o es cero");
    }
    return NumeroInvertido;
}

static double Calculadora(int opcion, double num){
    double resultado;
    switch(opcion){
        case 1:
            resultado = Math.Abs(num);
            break;
        case 2:
            resultado = Math.Pow(num, 2);
            break;
        case 3:
            resultado = Math.Sqrt(num);
            break;
        case 4:
            resultado = Math.Sin(num);
            break;
        case 5:
            resultado = Math.Cos(num);
            break;
        case 6:
            resultado = (double)Math.Truncate((decimal)num);
            break;
        default:
            resultado = 0;
            break;
    }
    return resultado;
}