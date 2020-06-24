namespace Aula23POO
{
    public class Cartao
    {
        public string Titular { get; set;}
        public int Numero { get; set;}
        public string Bandeira { get; set;}
        public int Vencimento { get; set; }

        public Cartao(){

        }

        public Cartao(string _Titular, int _Numero, string _bandeira, int _vencimento){

            this.Titular = _Titular;
            this.Numero = _Numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
        }


    }
}