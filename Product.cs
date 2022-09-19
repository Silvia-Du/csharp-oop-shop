// See https://aka.ms/new-console-template for more information

/*
  Creare una classe Prodotto che gestisce i prodotti dello shop.
Un prodotto è caratterizzato da:
codice (numero intero)
nome
descrizione
prezzo
iva
Usate opportunamente i livelli di accesso (public, private):
i costruttori,
i metodi getter e setter
eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri 
(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Buon lavoro!  
*/

//caricare lavatrice: ripropongo il funzionamento della mia lavatrice.caricare panni,
//scaricarli, etc, quando avvio il progr: piccolo menu con funz da poter prendere pensa all'interfaccia.
public class Product
{
    int productCode;
    string name;
    string descripton;
    float price;
    int iva = 25;

    //string key = "password-code";


    //costruttore
    public Product(int productCode, string name, float price, string descripton)
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


    public void SetChangeData(int productCode, string name, float price)
    {
        this.productCode = productCode;
        this.name = name;
        this.price = price;

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
    public float GetTaxedPrice()
    {
        return price + (iva % 100 * price);
    }

    public int getProductCode()
    {
        return this.productCode;
    }

    public string GetProductFullName()
    {
        return this.productCode+ this.name;
    }



    public void getProductData()
    {
        Console.WriteLine($"Nome prodotto: {this.name}," +
            $"Codice prodotto: {this.productCode}," +
            $"Prezzo: {this.price}," +
            $"Descrizione: {this.descripton}," +
            $"Iva applicata: {this.iva}");
    }
    
}