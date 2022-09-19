// See https://aka.ms/new-console-template for more information




using System.Runtime.ConstrainedExecution;

public class Product
{
    int productCode;
    string name;
    string descripton;
    float price;
    int iva = 25;

    //string key = "password-code";


    //costruttore
    public Product(string name, float price, string descripton)
    {
        
        this.productCode = new Random().Next(1, 100);
        this.name = name;
        this.price = price;
        this.descripton = descripton;

    }
    //SETTER
    public void SetProductDescription(string descripton)
    {
            this.descripton = descripton;
    }

    public void SetProductName(string name)
    {
        this.name = name.ToLower();
    }

    public void SetProductprice(int price)
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

    public string GetProductDescription()
    {
        return this.descripton;
    }

    public string GetProductName()
    {
        return this.name;
    }

    public float GetProductprice()
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

    public string GetProductFullName()
    {
        return GetAdvancedCode()+"-"+ this.name;
    }



    public void GetProductData()
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