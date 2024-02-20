using System;
using System.Collections.Generic;

namespace Laba1Sharp1 {
    /// <summary>
    /// класс для библиотеки
    /// </summary>
    class Library
    {


        private static int _increment = 0;


        private string _id;


        private string _name = "Не определено";

        private int _quantityOfBooks = 0;


        private string _phone = "Не определено";


        private string _address = "Не определено";


        private float _square = 0;


        private int _avgNumberOfVisitors = 0;


        private float _rate = 0;

        private static List<Library> libraries = new List<Library>();


        public string ID
        {
            get => _id;
            set => _id = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _name
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        /// <summary>
        /// свойство для получения и изменения поля _quantityOfBooks
        /// </summary>

        public int QuantityOfBooks
        {
            get => _quantityOfBooks;
            set => _quantityOfBooks = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _phone
        /// </summary>
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        /// <summary>
        /// свойство для получения и изменения поля _address
        /// </summary>

        public string Address
        {
            get => _address;
            set => _address = value;
        }
        /// <summary>
        /// свойство для получения и изменения поля _square
        /// </summary>

        public float Square
        {
            get => _square;
            set => _square = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _avgNumberOfVisitors
        /// </summary>
        public int AvgNumberOfVisitors
        {
            get => _avgNumberOfVisitors;
            set => _avgNumberOfVisitors = value;
        }

        /// <summary>
        /// свойство для получения и изменения поля _rate
        /// </summary>
        public float Rate
        {
            get => _rate;
            set => _rate = value;
        }

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Library()
        {
            Name = $"Библиотека {_increment}";
            _increment++;
        }

        /// <summary>
        /// Конструктор, устанавливающий название библиотеки
        /// </summary>
        /// <param name="name">Название библотеки</param>
        public Library(string name) : this()
        {
            _name = name;
        }
        /// <summary>
        /// Конструктор, устанавливающий название библиотеки и библиотечный фонд
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        /// <param name="quantityOfBooks">Библиотечный фонд</param>

        public Library(string name, int quantityOfBooks) : this(name)
        {
            _quantityOfBooks = quantityOfBooks;
        }
        /// <summary>
        /// Конструктор, устанавливающий название библиотеки, библиотечный фонд, номер телефона, адрес, площадь, среднее число
    /// посетителей, рейтинг
    /// </summary>
    /// <param name="name">Название библиотеки</param>
    /// <param name="quantityOfBooks">Библиотечный фонд</param>
    /// <param name="phone">Номер телефона</param>
    /// <param name="address">Адрес</param>
    /// <param name="square">Площадь</param>
    /// <param name="avgNumberOfVisitors">Среднее число посетителей</param>
    /// <param name="profit">Рейтинг</param>

        public Library(string name, int quantityOfBooks, string phone, string address,
            float square, int avgNumberOfVisitors, float profit) : this(name, quantityOfBooks)
        {
            _avgNumberOfVisitors = avgNumberOfVisitors;
            _phone = phone;
            _address = address;
            _square = square;
            _rate = profit;
        }
        /// <summary>
        /// свойство для получения _increment
        /// </summary>

        public static int ObjectCounter
        {
            get { return _increment; }
        }
        /// <summary>
        /// свойство для получения libraries
        /// </summary>
        public static List<Library> Libraries
        {
            get => libraries;
        }

        /// <summary>
        /// метод добавления в список библиотек
        /// </summary>
        /// <param name="library">Библиотека</param>
        public static void AddInList( Library library)
        {
            libraries.Add(library);
        }
        /// <summary>
        /// Метод для вывода всех полей
        /// </summary>
        /// <returns>Название библиотеки, библиотечный фонд, номер телефона, адрес, площадь, среднее число посетителей,
    /// рейтинг</returns>
        public override string ToString()
        {
            return $"Название: {_name}\n" +
                   $"Библиотечный фонд: {_quantityOfBooks}\n" +
                   $"Номер телефона: {_phone}\n" +
                   $"Адрес: {_address}\n" +
                   $"Площадь библиотеки: {_square}\n" +
                   $"Среднее число посетителей: {_avgNumberOfVisitors}\n" +
                   $"Рейтинг: {_rate}\n";
        }

        /// <summary>
        /// метод для преобразования в 16-ричную СС
        /// </summary>
        /// <param name="value">Значение</param>
        /// <returns>Значение в 16-ричной СС</returns>

        public string Hex(int value)
        {
            return Convert.ToString(value, 16);
        }

    }
}