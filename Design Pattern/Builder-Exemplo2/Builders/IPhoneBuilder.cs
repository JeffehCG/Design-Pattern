using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Exemplo2
{
    class IPhoneBuilder : ICelular
    {
        Celular celular;
        public Celular Celular
        {
            get { return this.celular; }
        }
        public IPhoneBuilder()
        {
            celular = new Celular("IPhone");
        }
        public void BuildBateria()
        {
            this.celular.Bateria = "MAH_2000";
        }

        public void BuildCamera()
        {
            this.celular.Camera = "16 MP";
        }

        public void BuildSistema()
        {
            this.celular.Sistema = "iOS 11";
        }

        public void BuildTela()
        {
            this.celular.Tela = "9";
        }

    }
}
