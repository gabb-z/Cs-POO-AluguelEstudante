using System;
using System.Collections.Generic;
using System.Text;

namespace AluguelEstudante
{
    class Estudante
    {
        //Atributos da Classe - Estudante
        public string NomeEstudante { get; set; }
        public string EmailEstudante { get; set; }

        //Construtor - Estudante
        public Estudante(string nomeEstudante, string emailEstudante)
        {
            NomeEstudante = nomeEstudante;
            EmailEstudante = emailEstudante;
        }

        //ToString - Infos Estudante
        public override string ToString()
        {
            return NomeEstudante + ", " + EmailEstudante;
        }
    }
}
