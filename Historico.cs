using System;

namespace calculadora;

public class Historico
{
    public static List<string> historico = new List<string>();
    
    public static void AdicionarHistorico(double numero1, string operacao, double resultado){
        historico.Add(numero1 + " " + operacao + " " + "=" + " " + resultado);}
    public static void AdicionarHistorico2(double numero1, string operacao, double numero2, double resultado){
        historico.Add(numero1 + " " + operacao + " " + numero2 + " " + "=" + " " + resultado);}
    public static void AdicionarHistorico3(string operacao, double numero1, string resultado){
        historico.Add(operacao + " " + numero1 + " " + "=" + " " + resultado);}
    public static void AdicionarHistorico4(string operacao, double resultado){
        historico.Add(operacao + " " + "=" + " " + resultado);}                
}