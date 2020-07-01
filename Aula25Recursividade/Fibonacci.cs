using System;

namespace Aula25Recursividade
{
    public class Fibonacci
    {
        public void GerarFibonacci(int numero1, int numero2, int vezes)
        {
            //condição obrigatoria para quebrar a recursividade do método
            if(vezes > 0){
                Console.WriteLine(numero1);
                GerarFibonacci(numero2,numero1 + numero2, vezes - 1);
            }
        }

        // Exemplo usando fatorial 
        //5! = 5 * 4 * 3 * 2 * 1
        public int GerarFatorial(int numero){
            
            //Condição para quebra a recursividade do método
            if(numero == 1){
                return 1;
            }else{
                return numero * GerarFatorial(numero - 1);
            }
        }
    }
}