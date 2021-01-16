namespace Encapsulamento_POO.Classes
{
    public class MasterCard
    {
        
        //Declaração dos atributos 
        private int parcela;

        //Get e Set 
        public int Parcela {
            get {return parcela;}//Pegar dados - leitura
            set {parcela = value;}//Inserir Dados - escrita
        }

        public bool Bandeira { get; internal set; }

        //Métodos 
        public string ComprarComDesconto(){
            return "";
        }
    }
}