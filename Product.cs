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
    public Product(string name, int price)
    {
        this.ProductCode = new Random().Next(1, 100);
        this.Name = name;
        this.Price = price;
    }

    //costruttore
    public Product(string name, float price, string descripton) :this()
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
    public double GetTaxedPrice()
    {
        double newPrice = Price + ((Price * iva) / 100);

        return Math.Round(newPrice, 2);

    }

    public string GetFullName()
    {
        return GetAdvancedCode() + "-" + this.Name;
    }



    public string ProductPrinter()
    {
        return $"Nome prodotto: {this.Name};  \t " +
            $"Codice: {GetAdvancedCode()}; \t Prezzo: {this.Price}; \t " +
            $"Descrizione: {this.Descripton}; \t Iva appicata: {this.iva}; \t" +
            $"Prezzo comprensivo di iva: {GetTaxedPrice()}";

    }
}