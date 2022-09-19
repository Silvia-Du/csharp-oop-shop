// See https://aka.ms/new-console-template for more information




using System.Runtime.ConstrainedExecution;

public class Product
{
    int productCode;
    string name;
    string descripton;
    float price;
    int iva = 25;



    //costruttore
    public Product(string name, float price, string descripton)
    {
        
        this.productCode = new Random().Next(1, 100);
        this.name = name;
        this.price = price;
        this.descripton = descripton;

    }
    //SETTER
    public void SetDescription(string descripton)
    {
            this.descripton = descripton;
    }

    public void SetName(string name)
    {
        this.name = name.ToLower();
    }

    public void SetPrice(int price)
    {
        this.price = price;
    }


    public void SetChangeData(string name, float price)
    {
        this.productCode = new Random().Next(1, 100);
        this.name = name;
        this.price = price;

    }

    //BONUS

    public string GetAdvancedCode()
    {
        string newCode = productCode.ToString();
        int zeroBase = 8 - newCode.Length;
        string zero = null;
        for(int i = 0; i< zeroBase; i++)
        {
            zero += "0";
        }
        
        return zero+newCode;
    }

    //GETTER

    public string GetDescription()
    {
        return this.descripton;
    }

    public string GetName()
    {
        return this.name;
    }

    public float GetPrice()
    {
        return this.price;
    }
    public double GetTaxedPrice()
    {
        double newPrice = price + ((price * iva) / 100);

        return Math.Round(newPrice, 2);

    }

    public int GetProductCode()
    {
        return this.productCode;
    }

    public string GetFullName()
    {
        return GetAdvancedCode()+"-"+ this.name;
    }



    public void DataPrinter()
    {
        Console.WriteLine($"Nome prodotto: {this.name}");
        Console.WriteLine($"Codice: {this.productCode}");
        Console.WriteLine($"Codice avanzato: {GetAdvancedCode()};");
        Console.WriteLine($"Prezzo: {this.price}");
        Console.WriteLine($"Descrizione: {this.descripton}");
        Console.WriteLine($"Iva appicata: {this.iva}");
        Console.WriteLine($"Prezzo comprensivo di iva: {GetTaxedPrice()}");

    }
    
}