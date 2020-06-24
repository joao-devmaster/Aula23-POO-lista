using System;
using System.Collections.Generic;

namespace Aula23POO
{
    class Program
    {
        static void Main(string[] args)
        {

            //para criar uma nova lista tipo "Produti"
            List<Produto> produtos = new List<Produto>();
            

            //criamos um produto atravez do metodo construtor padrão
            Produto produto777 = new Produto();
            produto777.Codigo = 777;
            produto777.Nome = "Relogio cassio";
            produto777.Preco = 1000f;


            //agora temos que adicionar as propriedades do produto(codigo,nome,preco)
            produtos.Add(produto777);


            //vamos adicionar mais produtos com um novo metodo construtor
            produtos.Add( new Produto(2, "Relogio gucci", 5000f));
            produtos.Add(new Produto ( 3, "Perfume Puruvudoo", 15f));
            produtos.Add(new Produto (4, "Relogio Armani", 4200f)) ;
            produtos.Add(new Produto(5, "Escova de dente supreme", 400f))  ;
            produtos.Add(new Produto(6, "Figurinha supreme", 250f)) ;
            produtos.Add(new Produto(7, "Bolacha Oreo supreme", 150 ));

            //varremos a lista com o foreach / "item esta no contexto do foreach"
            foreach(Produto item in produtos){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine( $"R$ {item.Preco} - {item.Nome} ");
                Console.ResetColor();
            }


            //remover item passando o objeto como argumento
            produtos.Remove(produto777);


            //remover item pelo indice
            produtos.RemoveAt(3);

            // usamos expressao lambda para eliminar um registro
            produtos.RemoveAll(k => k.Nome == "Relogio Gucci");

            //varremos nossa lista depois que foi alterada
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome} ");
                Console.ResetColor();
            }


            // podemos encontrar um produto especifico utilizando lambda
            Produto iphone777 = produtos.Find( w => w.Codigo == 6);

            System.Console.WriteLine("iphone777 - R$" + iphone777.Preco);

            // aplicar complemento da atividade
            List<Cartao> cartoes = new List<Cartao>();

            Cartao card = new Cartao();
            card.Titular = "João vitor";
            card.Numero = 777777777;
            card.Bandeira = "Mastercard";
            card.Vencimento = 7;
            
            

             cartoes.Add( new Cartao("Joao Vitor",7777777,"MasterCard",7));
           

            foreach(Cartao item in cartoes )
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                System.Console.WriteLine($"{item.Titular} / {item.Numero} / {item.Bandeira} / {item.Vencimento}");

            }
            


//Cartao.add(cartoes);





            
        }
    }
}
