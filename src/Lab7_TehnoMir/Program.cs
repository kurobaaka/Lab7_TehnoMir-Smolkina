
using System;

namespace Lab7_TehnoMir
{
    /// <summary>
    /// Класс для расчёта скидок компании «ТехноМир».
    /// </summary>
    public class DiscountCalculator
    {
        /// <summary>
        /// Название компании.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Размер скидки в процентах.
        /// </summary>
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// Создаёт объект для расчёта скидок.
        /// </summary>
        public DiscountCalculator()
        {
            CompanyName = "ТехноМир";
            DiscountPercent = 20;
        }

        /// <summary>
        /// Проверяет наличие права на скидку.
        /// </summary>
        /// <param name="hasOrdersLastMonth">Были ли заказы в прошлом месяце.</param>
        /// <returns>True, если заказов не было.</returns>
        public bool HasDiscount(bool hasOrdersLastMonth)
        {
            return !hasOrdersLastMonth;
        }

        /// <summary>
        /// Рассчитывает цену товара с учётом скидки.
        /// </summary>
        /// <param name="basePrice">Начальная цена товара.</param>
        /// <param name="hasOrdersLastMonth">Наличие заказов в прошлом месяце.</param>
        /// <returns>Итоговая стоимость товара.</returns>
        public decimal GetDiscountedPrice(
            decimal basePrice,
            bool hasOrdersLastMonth)
        {
            if (hasOrdersLastMonth)
            {
                return basePrice;
            }

            return basePrice * (100 - DiscountPercent) / 100;
        }
    }

    /// <summary>
    /// Главный класс запуска программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            DiscountCalculator calculator = new DiscountCalculator();

            decimal price = 50000m;

            decimal result = calculator.GetDiscountedPrice(price, false);

            Console.WriteLine("================================");
            Console.WriteLine("       КОМПАНИЯ ТЕХНОМИР");
            Console.WriteLine("================================");
            Console.WriteLine("Автор: Смолкина Марина");
            Console.WriteLine("Группа: И-42");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Товар: Ноутбук");
            Console.WriteLine("Базовая цена: " + price + " руб.");
            Console.WriteLine("Скидка: " + calculator.DiscountPercent + "%");
            Console.WriteLine("Итоговая цена: " + result + " руб.");
            Console.WriteLine("================================");

            Console.ReadKey();
        }
    }
}
