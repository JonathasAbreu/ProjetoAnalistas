
using Analistas.Entidades;
using Analistas.Utils;
using Analistas.Utils.Enumeradores;

namespace Analistas
{
    public class Analista
    {
        public virtual int ID { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual CargoEnum Cargo { get; protected set; }
        public virtual ScriptEnum Script { get; protected set; }
        public virtual IlhasSeguradora IdSeguradora { get; protected set; }

        // Contrutor constrói a entidade
        public Analista(string nome, CargoEnum cargo, ScriptEnum script, IlhasSeguradora idSeguradora)
        {
            SetNome(nome);
            SetCargo(CargoEnum.AnalistaUm);
            SetScript(ScriptEnum.NaoDefinido);
            SetIdSeguradora(idSeguradora);
        }

        private void SetIdSeguradora(IlhasSeguradora idSeguradora)
        {
            IdSeguradora = idSeguradora;
        }

        public virtual void SetScript(ScriptEnum script)
        {
            Script = script;
        }

        public virtual void SetCargo(CargoEnum cargo)
        {
            Cargo = cargo;
        }

        public virtual void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("O nome não pode ser nulo ou vazio.");

            if (nome.Length > 50)
                throw new Exception("O nome não pode conter mais do que 50 caracteres.");

            Nome = nome;
        }

        //construtor para o nhibernate
        private Analista()
        {
        }
    }
}