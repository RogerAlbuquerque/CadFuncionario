using System;
using System.Collections.Generic;

class funcionario{

    public int id {get;set;}
    public string nome {get;set;}
    public double salario{get; private set;}

    public funcionario(int id, string nome, double salario){
       
        this.id      = id;
        this.nome    = nome;
        this.salario = salario;

    }


    public double aumento(double salario){
       return this.salario += salario;

    }

    public override string ToString(){

        return id + "," + nome + "," + salario;

    }

}



class principal{

    static void Main(string[] args){

        List<funcionario> empregados = new List<funcionario>();

        Console.WriteLine("Quantos funcionários serão adicionados ?");
        int newFun = int.Parse(Console.ReadLine());

        for(int i = 0; i < newFun ; i++){
        
        Console.WriteLine("Dados do " + (i+1) + "º empregado:");
        
        Console.Write("ID: ");
         int id = int.Parse(Console.ReadLine());

         Console.Write("Nome: ");
         string nome = Console.ReadLine();

         Console.Write("Salário: ");
         double salario = double.Parse(Console.ReadLine());
            
         empregados.Add(new funcionario(id, nome, salario));
         Console.WriteLine("-----------------------------------------------------\n");

        }

        Console.WriteLine("entre com o ID do funcionário que ganhará um aumento: ");
        int procurarID = int.Parse(Console.ReadLine());

        funcionario aumentoSalFun = empregados.Find(x => x.id == procurarID);
         if(aumentoSalFun != null){
             
             Console.WriteLine("Entre com o valor que será adicionado no salário");
             double aumentoSAL = double.Parse(Console.ReadLine());

             aumentoSalFun.aumento(aumentoSAL);         

             

         }

         else {
             Console.WriteLine("ID inexistente tente outro");
         }



            Console.WriteLine("\nLista Atualizada------------------------------------------------------------");

        foreach(funcionario obj in empregados){
            Console.WriteLine(obj);

        }

    }
}