using System.Data;

namespace calculadora;

class Program
{
 
    static void Main(string[] args){
    
    bool continuar = true;
      
    while(continuar == true){
        
    Console.WriteLine("escreva o calculo ou encerrar pra parar o programa");
    
    double numero1 = 0;
    double numero2 = 0;
    string entrada1 = "entrada1";
    string entrada2 = "entrada2";
    
    while(entrada1 != "voltar" && entrada2 != "voltar"){
        
    try{
        string calculo = Console.ReadLine();
        
    if(calculo == "encerrar"){
          continuar = false;
          break;}
          
    else if (calculo == "Pow"){
        Console.WriteLine("adicione a base, voltar");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine("adicione o expoente");
        
        entrada2 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero2 = double.Parse(entrada2);
        Console.WriteLine(metodo.metodo1(numero1, numero2));
        Historico.AdicionarHistorico2(numero1, "Pow", numero2, metodo.metodo1(numero1, numero2));}
    else if(calculo == "Sqrt"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);   
        Console.WriteLine(metodo.metodo2(numero1));
        Historico.AdicionarHistorico(numero1, "Sqrt", metodo.metodo2(numero1));}
    else if(calculo == "Sin"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.metodo3(numero1));
        Historico.AdicionarHistorico(numero1, "Sin", metodo.metodo3(numero1));}
    else if(calculo == "Cos"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.metodo4(numero1));
        Historico.AdicionarHistorico(numero1, "Cos", metodo.metodo4(numero1));}
    else if(calculo == "Tan"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.metodo5(numero1));
        Historico.AdicionarHistorico(numero1, "Tan", metodo.metodo5(numero1));}
    else if(calculo == "Round"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.metodo6(numero1));
        Historico.AdicionarHistorico(numero1, "Round", metodo.metodo6(numero1));}   
    else if(calculo == "Abs"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.metodo7(numero1));
        Historico.AdicionarHistorico(numero1, "Abs", metodo.metodo7(numero1));}
    else if(calculo == "Log"){
        Console.WriteLine("digite um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.metodo8(numero1));
        Historico.AdicionarHistorico(numero1, "Log", metodo.metodo8(numero1));}
    
    else if(calculo == "Paridade"){
        Console.WriteLine("adicione um numero");
        entrada1 = (Console.ReadLine());
            if(entrada1 == "voltar"){
            continue;}
            if(entrada1 == "encerrar"){
            break;}
        numero1 = double.Parse(entrada1);
        Console.WriteLine(metodo.Paridade(numero1));
        Historico.AdicionarHistorico3("paridade", numero1, metodo.Paridade(numero1));}
        
    else if(calculo == "historico"){
        foreach (string calc in Historico.historico)
        Console.WriteLine(calc);}
        
    else{
    System.Data.DataTable tabela = new System.Data.DataTable();  
    Console.WriteLine(tabela.Compute(calculo, ""));
    Historico.AdicionarHistorico4(calculo, Convert.ToDouble(tabela.Compute(calculo, "")));}
    }
    catch{
        Console.WriteLine("voce digitou errado");
        break;}
            }
            
       }
    
    }
    
}