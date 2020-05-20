using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Pessoa
    {
        public string Nome { get; protected set; }
        public string Apelido { get; protected set; }
    }
    public class Funcionario: Pessoa
    {
        public double Salario { get; private set; }
        public NivelProfisional NivelProfisional { get; set; }
        public IList<string> Habilidades { get; private set; }

        public Funcionario(string nome, double salario)
        {
            Nome = string.IsNullOrEmpty(nome) ? "Fulano" : nome;
            DefinirSalario(salario);
            DefinirHabilidades();
        }

        

        public void DefinirSalario(double salario)
        {
            if (salario < 500) throw new Exception("Salario inferior ao permitido");

            Salario = salario;
            if (salario < 2000) NivelProfisional = NivelProfisional.Junior;
            else if (salario >= 2000 && salario < 8000) NivelProfisional = NivelProfisional.Pleno;
            else if (salario >= 8000) NivelProfisional = NivelProfisional.Senior;
            
        }
        private void DefinirHabilidades()
        {
            var habilidadesBasicas = new List<string>()
            {
                "Lógica de Programação",
                "OOP"
            };

            Habilidades = habilidadesBasicas;

            switch (NivelProfisional)
            {
                case NivelProfisional.Pleno:
                    Habilidades.Add("Testes");
                    break;
                case NivelProfisional.Senior:
                    Habilidades.Add("Testes");
                    Habilidades.Add("Microservices");
                    break;
            }
        }
    }
    public enum NivelProfisional
    {
        Junior,
        Pleno,
        Senior
    }
    public class FunctionalFactory
    {
        public static Funcionario Criar(string nome, double salario)
        {
            return new Funcionario(nome, salario);
        }
    }
}
