using System;


namespace META_QUESTAO2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region META QUESTAO 2
            string str1, str2, str3, str4, str5;
            string result;
            Console.WriteLine("Exemplo de entrada -> { [ () ] }");
            Console.WriteLine("Entre com 5 caracteres");
            Console.WriteLine("Sendo que a cada espaço conta um ou seja -> Ex () é igual a 1, e ( ) é igual a 2");
         
            string[] linha = Console.ReadLine().Split(' ');
            str1 = linha[0];
            str2 = linha[1];
            str3 = linha[2];
            str4 = linha[3];
            str5 = linha[4];

            result = string.Join(" ", str1 + str2 + str3 + str4 + str5);


            Console.WriteLine("STRING É BALANCEADA?");

            if(str1 == "{" && str5 == "}" && str2 == "[" && str4 == "]" && str3 == "()")
            {
                Console.WriteLine("SIM");
            }

            else
            {
                Console.WriteLine("NÃO");
            }

            Console.WriteLine(result);

            #endregion
        }
    }
}
