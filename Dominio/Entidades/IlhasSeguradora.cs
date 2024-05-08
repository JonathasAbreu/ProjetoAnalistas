using System.ComponentModel;

namespace Analistas.Entidades
{
    public class IlhasSeguradora
    {
        public virtual int ID { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual List<Analista> Analistas { get; protected set; }
        public virtual string Seguradora { get; protected set; }

        public IlhasSeguradora(string nome, string seguradora)
        {
            SetNome(nome);
            SetSeguradora(seguradora);
        }

        public virtual void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("O nome não pode ser nulo ou vazio.");

            if (nome.Length > 50)
                throw new Exception("O nome não pode conter mais do que 50 caracteres.");

            Nome = nome;
        }

        public virtual void SetSeguradora(string seguradora)
        {
            List<string> seguradorasValidas = new List<string>();
            string portoSeguro = "Porto Seguro";
            string azul = "Azul";
            seguradorasValidas.Add(portoSeguro);
            seguradorasValidas.Add(azul);

            if(!seguradorasValidas.Contains(seguradora))
                throw new Exception("Seguradora Inválida");

            Seguradora = seguradora;
        }

        public IlhasSeguradora()
        {
        }
    }
}