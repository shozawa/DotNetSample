namespace ConsoleApp
{
    public class Currency
    {
        public decimal Value { get; private set; }

        public Currency(decimal value)
        {
            Value = value;
        }

        public Currency Add(Currency currency)
        {
            return new Currency(Value + currency.Value);
        }
    }
}
