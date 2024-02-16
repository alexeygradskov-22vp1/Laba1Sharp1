using System;
using System.Collections.Generic;


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

   
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    
    public int QuantityOfBooks
    {
        get => _quantityOfBooks;
        set => _quantityOfBooks = value;
    }

    
    public string Phone
    {
        get => _phone;
        set => _phone = value;
    }

    
    public string Address
    {
        get => _address;
        set => _address = value;
    }

    
    public float Square
    {
        get => _square;
        set => _square = value;
    }

    
    public int AvgNumberOfVisitors
    {
        get => _avgNumberOfVisitors;
        set => _avgNumberOfVisitors = value;
    }

    
    public float Rate
    {
        get => _rate;
        set => _rate = value;
    }

    
    public Library()
    {
        Name = $"Библиотека {_increment}";
        _increment++;
    }

   
    public Library(string name) : this()
    {
        _name = name;
    }

    
    public Library(string name, int quantityOfBooks) : this(name)
    {
        _quantityOfBooks = quantityOfBooks;
    }

    
    public Library(string name, int quantityOfBooks, string phone, string address,
        float square, int avgNumberOfVisitors, float profit) : this(name, quantityOfBooks)
    {
        _avgNumberOfVisitors = avgNumberOfVisitors;
        _phone = phone;
        _address = address;
        _square = square;
        _rate = profit;
    }

    
    public static int ObjectCounter
    {
        get { return _increment; }
    }

    public static List<Library> Libraries
    {
        get => libraries;
    }

    
    public static void AddInList(Library library)//добавление в список аэропортов
    {
        libraries.Add(library);
    }
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


    public string Hex(int value)
    {
        return Convert.ToString(value, 16);
    }

    
}