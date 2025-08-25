using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Introducion
{
    public class Util
    {
        public enum DiasSemana
        {
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado,
            Domingo
        }

        public enum TiposErro
        {
            ErroLogin,
            ErrodeConta,
            ErroExpection,
            ErroFatal
        }

        public void Log(TiposErro tipoErro)
        {
            Console.WriteLine(String.Concat("Erro no dia", System.DateTime.Now,tipoErro));
        }

        public string RetornarEnderecoPor(string CEP)
        {
            return "TBD";
        }
    }
}
