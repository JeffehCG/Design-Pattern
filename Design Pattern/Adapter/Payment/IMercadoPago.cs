using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    interface IMercadoPago
    {
        Token AuthToken();
        void MercadoPagoPayment();
        void MercadoPagoReceive();
    }
}
