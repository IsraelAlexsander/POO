using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padrao_Facede
{
    internal class Aprovacao    //Classe Fachada
    {
        private Regular CandidatoRegular = new Regular();
        private MediaGeral MediaGeralCandidato = new MediaGeral();
        private Idade IdadeCandidato = new Idade();
        private BolsaDeEstudos BolsaDeEstudosCandidato = new BolsaDeEstudos();
        private Empregado CandidatoEmpregado = new Empregado();
        private AvaliacoesProfessores AvaliacaoProfessoresCandidato = new AvaliacoesProfessores();

        public bool PodeParticipar()
        {
            bool Altorizado = true;

            if (!CandidatoRegular.ERegular())
                Altorizado = false;
            if (!MediaGeralCandidato.Apta())
                Altorizado = false;
            if (!IdadeCandidato.NaFaixa())
                Altorizado = false;
            if (BolsaDeEstudosCandidato.Tem())
                Altorizado = false;
            if (CandidatoEmpregado.Esta())
                Altorizado = false;
            if (!AvaliacaoProfessoresCandidato.PeloMenosDuas())
                Altorizado = false;

            return Altorizado;
        }
    }
}
