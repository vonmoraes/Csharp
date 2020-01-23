using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.POO {

    sealed class SemFilho {
        public double valor_fortuna() {
            return 564169816951;
        }
    }

    //public class SouFilho : SemFilho {

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
            return base.HonrarNomeFamilia();
        }
    }

    class FilhoRebelde : Pai {
        public new bool HonrarNomeFamilia() {
            return false;
        }
    }




    class ClasseSealed {
        public static void Executar() {

        }
    }
}
