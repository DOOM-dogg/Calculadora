using System.Data;

namespace calculadora;

class Program
{
 
    static void Main(string[] args){
    
    bool continuar = true;
      
    while(continuar == true){
        
    Console.WriteLine("escreva o calculo, escreva encerar pra parar o programa");
    
    try{
        string calculo = Console.ReadLine();
    
    if(calculo == "encerar"){
          continuar = false;
          break;}
    else if(calculo == "Pow"){
        Console.WriteLine("adicione a base");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine("adicione o expoente");
        double numero2 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo1(numero1, numero2));}
    else if(calculo == "Sqrt"){
        Console.WriteLine("adicione um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo2(numero1));}
    else if(calculo == "Sin"){
        Console.WriteLine("adicione um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo3(numero1));}
    else if(calculo == "Cos"){
        Console.WriteLine("adicione um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo4(numero1));}
    else if(calculo == "Tan"){
        Console.WriteLine("adicione um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo5(numero1));}
    else if(calculo == "Round"){
        Console.WriteLine("adicione um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo6(numero1));}   
    else if(calculo == "Abs"){
        Console.WriteLine("adicione um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo7(numero1));}
    else if(calculo == "Log"){
        Console.WriteLine("digite um numero");
        double numero1 = double.Parse(Console.ReadLine());
        Console.WriteLine(metodo.metodo8(numero1));}   
    else{
    System.Data.DataTable tabela = new System.Data.DataTable();  
    Console.WriteLine(tabela.Compute(calculo, ""));}
        
    }
    catch{
        Console.WriteLine("voce digitou errado seu calculo ou operador");
        continue;}
    
    
       }
    
    }
    
}