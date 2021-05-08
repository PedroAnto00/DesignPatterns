namespace Facade
{
    public class ProductFacade
    {
        Product _product;
        Payment _payment;
        Invoice _invoice;

        public ProductFacade()
        {
            _product = new Product();
            _payment = new Payment();
            _invoice = new Invoice();
        }
        public void MakePayment()
        {
            _payment.MakePayment();
        }
        public void GetProductDetails()
        {
            _product.GetProductDetails();
        }
        public void SendInvoice()
        {
            _invoice.SendInvoice();
        }
    }
}