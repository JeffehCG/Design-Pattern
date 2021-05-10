using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.MercadoPagoPayment();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.MercadoPagoReceive();
        }
    }
}
