using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Exemplo2
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
        public Celular Celular
        {
            get { return this.celular; }
        }
        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }
        public void BuildBateria()
        {
            this.celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.Camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.celular.Sistema = "Android 4.5";
        }

        public void BuildTela()
        {
            this.celular.Tela = "7";
        }

    }
}
