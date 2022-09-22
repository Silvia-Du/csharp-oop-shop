// See https://aka.ms/new-console-template for more information




using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

public abstract class Product
{
    string Name { get; set; }
    string Brandt { get; set; }
    int ProductCode { get; set; }
    string Descripton { get; set; }
    float Price { get; set; }
    int iva = 25;
    //costruttore
    public Product(string name, float price)
    {
        this.ProductCode = new Random().Next(1, 100);
        this.Name = name;
        this.Price = price;
    }

    //costruttore
    public Product(string name, float price, string descripton) :this(name, price)
    {
        
        this.Descripton = descripton;

    }

    public void SetChangeData(string name, float price)
    {
        this.ProductCode = new Random().Next(1, 100);
        this.Name = name;
        this.Price = price;

    }

    //BONUS
    public string GetAdvancedCode()
    {
        string newCode = ProductCode.ToString();
        int zeroBase = 8 - newCode.Length;
        string zero = null;
        for (int i = 0; i < zeroBase; i++)
        {
            zero += "0";
        }

        return zero + newCode;
    }

    //GETTER
    public double GetTaxedPrice(float price)
    {
        double newPrice = price + ((price * this.iva) / 100);

        return Math.Round(newPrice, 2);

    }

    public string GetFullName()
    {
        return GetAdvancedCode() + "-" + Name;
    }

    public string FullNamePrinter()
    {
        return $"Il prodotto: {GetFullName()}";
    }


    public virtual string ProductPrinter()
    {
        return $"Nome prodotto: {Name}; \n " +
            $"Codice: {GetAdvancedCode()}; \n Prezzo: {Price}; \n " +
            $"\n Iva appicata: {iva}; \n" +
            $" Prezzo comprensivo di iva: {GetTaxedPrice(Price)}";

    }
}