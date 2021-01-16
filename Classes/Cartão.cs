namespace Encapsulamento_POO.Classes
{
    public class Cartão
    {
        //Declaração de varáveis 
        private string numero
        ; 
        public string nNuemero{
            get{return numero;}
            set{numero = value;}
        }

        public string bandeira 
        = "Mastercard";

        public string Bandeira{
             get{ return bandeira;}
             set{bandeira = value;}
        }

        protected string token 
        = "Qwertyui";

        public string Token{
            get{return token;}
        }
        private string cvv
        ;

        public string Cvvv{
            get{ return cvv;}
            set{cvv = value;}
        }

        protected float limitedecompea
        = 5000;

        public float Limitedecompra{
            get {return limitedecompea;}
        }

        //declaração dos metodos 
        public string RegistrarCompra(bool validado){
            return "";
        }

        private bool ValidarCompra(float saldo){
            return true;
        }
        protected string ValidarToken(string token){
            return "";
        }

    }
}