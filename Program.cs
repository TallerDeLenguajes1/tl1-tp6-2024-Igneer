// See https://aka.ms/new-console-template for more information
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
int resultado = Calculadora(1, 10, 20);
Console.WriteLine("Resultado: "+resultado);




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

static int Calculadora(int opcion, int num1, int num2){
    int resultado;
    switch(opcion){
        case 1:
            resultado = num1+num2;
            break;
        case 2:
            resultado = num1-num2;
            break;
        case 3:
            resultado = num1*num2;
            break;
        case 4:
            resultado = num1/num2;
            break;
        default:
            resultado = 0;
            break;
    }
    return resultado;
}