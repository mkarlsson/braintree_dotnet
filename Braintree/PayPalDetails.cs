using System;

namespace Braintree
{
    public class PayPalDetails
    {
        public String PayerEmail { get; protected set; }
        public String PaymentId { get; protected set; }
        public String AuthorizationId { get; protected set; }
        public String Token { get; protected set; }
        public String ImageUrl { get; protected set; }
        public String DebugId { get; protected set; }
        public String PayeeEmail { get; protected set; }
        public String CustomField { get; protected set; }

        protected internal PayPalDetails(NodeWrapper node)
        {
            PayerEmail = node.GetString("payer-email");
            PaymentId = node.GetString("payment-id");
            AuthorizationId = node.GetString("authorization-id");
            Token = node.GetString("token");
            ImageUrl = node.GetString("image-url");
            DebugId = node.GetString("debug-id");
            PayeeEmail = node.GetString("payee-email");
            CustomField = node.GetString("custom-field");
        }
    }
}
