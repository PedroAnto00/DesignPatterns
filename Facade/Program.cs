using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFacade facade = new ProductFacade();

            facade.MakePayment();
            facade.SendInvoice();
            facade.GetProductDetails();
        }
    }
}
