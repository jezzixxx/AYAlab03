using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class task3
    {
        private static void Main()
        {
            Console.WriteLine("Введите курс доллара:");
            double USD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите курс евро:");
            double EUR = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сумму:");
            uint value = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Введите исходную валюту (RUB, EUR, USD)");
            string start = Console.ReadLine();
            Console.WriteLine("Введите валюту для перевода (RUB, EUR, USD)");
            string end = Console.ReadLine();
            try { if ((start != "RUB" && start != "USD" && start != "EUR") || (end != "RUB" && end != "USD" && end != "EUR")) throw new ArgumentException(); }
            catch (ArgumentException) { Console.WriteLine("Введена неизвестная валюта. Попробуйте снова"); Main(); }
            finally
            {
                Currency converted_money;
                if (start == "RUB")
                {
                    CurrencyRUB money = new CurrencyRUB(value, USD, EUR);
                    if (end == "RUB") { Console.WriteLine("Умные мысли преследовали его"); converted_money = money; }
                    else if (end == "USD") converted_money = (CurrencyUSD)money;
                    else converted_money = (CurrencyEUR)money;
                }
                else if (start == "USD")
                {
                    CurrencyUSD money = new CurrencyUSD(value, USD, EUR);
                    if (end == "RUB") converted_money = (CurrencyRUB)money;
                    else if (end == "USD") { Console.WriteLine("Умные мысли преследовали его"); converted_money = money; }
                    else converted_money = (CurrencyEUR)money;
                }
                else
                {
                    CurrencyEUR money = new CurrencyEUR(value, USD, EUR);
                    if (end == "RUB") converted_money = (CurrencyRUB)money;
                    else if (end == "USD") converted_money = (CurrencyUSD)money;
                    else Console.WriteLine("Умные мысли преследовали его"); converted_money = money;
                }
                Console.WriteLine($"Внесено: {value} {start}\nПолучено: {converted_money.Value} {end}");
            }
        }
    }
    public class Currency
    {
        private double _value, _usd, _eur;
        public Currency(double Value, double USD, double EUR) { _value = Value; _eur = EUR; _usd = USD; }
        public double Value { get => _value; }
        public double USD { get => _usd; }
        public double EUR { get => _eur; }
    }
    public class CurrencyUSD : Currency
    {
        public CurrencyUSD(double Value, double USD, double EUR) : base(Value, USD, EUR) { }
        public static explicit operator CurrencyEUR(CurrencyUSD usd) { return new CurrencyEUR(usd.Value * usd.USD / usd.EUR, usd.USD, usd.EUR); }
        public static explicit operator CurrencyRUB(CurrencyUSD usd) { return new CurrencyRUB(usd.Value * usd.USD, usd.USD, usd.EUR); }
    }
    public class CurrencyEUR : Currency
    {
        public CurrencyEUR(double Value, double USD, double EUR) : base(Value, USD, EUR) { }
        public static explicit operator CurrencyUSD(CurrencyEUR eur) { return new CurrencyUSD(eur.Value * eur.EUR / eur.USD, eur.USD, eur.EUR); }
        public static explicit operator CurrencyRUB(CurrencyEUR eur) { return new CurrencyRUB(eur.Value * eur.EUR, eur.USD, eur.EUR); }
    }
    public class CurrencyRUB : Currency
    {
        public CurrencyRUB(double Value, double USD, double EUR) : base(Value, USD, EUR) { }
        public static explicit operator CurrencyUSD(CurrencyRUB rub) { return new CurrencyUSD(rub.Value / rub.USD, rub.USD, rub.EUR); }
        public static explicit operator CurrencyEUR(CurrencyRUB rub) { return new CurrencyEUR(rub.Value / rub.EUR, rub.USD, rub.EUR); }

    }
}
