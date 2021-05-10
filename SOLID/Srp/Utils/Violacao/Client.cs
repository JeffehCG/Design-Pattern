using System;

// Como pode ser visto, esta ocorrendo uma violação no principio SRP nessa classe, onde a mesma
// contem mais de uma responsabilidade, relacionado ao tratamento de um CRUD de cliente, e tambem a notificações (Email, sms, etc...)
// Dessa forma pode ser visto que o metodo "NotifyClient()" deveria estar em outra classe

namespace Srp.Utils.Violacao
{
    class Client
    {
        public void CreateClient()
        {

        }

        public void ReadClient()
        {

        }

        public void UpdateClient()
        {

        }

        public void DeleteClient()
        {

        }

        public void NotifyClient()
        {

        }
    }
}
