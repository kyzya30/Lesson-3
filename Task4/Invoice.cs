using System;


namespace Task4
{
    class Invoice
    {
        public Invoice(int account, string custumer, string article, int quantity, double pricePerUnit)
        {
            this.account = account;
            this.customer = custumer;
            this.Article = article;
            this.Quantity = quantity;
            this.PricePerUnit = pricePerUnit;
        }
        private readonly int account;
        private readonly string customer;
        private string _article;
        private int _quantity;
        private double _pricePerUnit;
        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        public double PricePerUnit
        {
            get { return _pricePerUnit; }
            set { _pricePerUnit = value; }
        }

        public void ShowInvoice()
        {
            Console.WriteLine("Покупатель: {0} \nСтатья: {1}\nКоличество {2}\nЦена за 1 единицу: {3}\nСчет без НДС -> {4}", customer, Article, Quantity, PricePerUnit, Quantity * PricePerUnit);
            Console.WriteLine("Счет с НДС -> {0}", Quantity * PricePerUnit * 1.20);
        }
    }
}
