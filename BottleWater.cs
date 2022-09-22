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

public class BottleWater : Product
{
   
    float MaxLitri { get; } = 1.5F;
    string Wathertype { get; set; }
    string BottleMatherial { get; set; }
    float Liters { get; set; }

    string Origin { get; set; }
    byte PH { get; }

    //costruttore

    public BottleWater(string name, int price, string wathertype, float liters, byte ph, string origin) : base(name, price)
    {
        this.Wathertype = wathertype;
        if (liters < this.MaxLitri)
        {
            this.Liters = liters;
        }
        this.PH = ph;
        this.Origin = origin;
    }

    //metodo bevi(double litriDaBere) che toglie dall’attributo litri una quantità pari a litriDaBere di acqua se presenti.

    public static double Drink(float litersToDrink, float liters)
    {
        double restOfWater; 
        if(litersToDrink < liters)
        {
            restOfWater = liters - litersToDrink;
        }
        else
        {
            restOfWater = liters;
        }

        return (double)restOfWater;
    }


    //metodo riempi(double litri) che riempie la bottiglia di acqua con tot litri di acqua, stando attenti a non riempirla troppo.
    public static double Fill(float restOfWater, float liters)
    {
        double waterToAdd;
        if(restOfWater < liters)
        {
            waterToAdd = liters - restOfWater;
        }
        else
        {
            waterToAdd = -1;
            //imposterò che se ritorna -1 allora non si può fare l'addizione di acqua
        }
            return waterToAdd;
    }

    //metodo svuota() che rimuove tutta l’acqua dalla bottiglia.

    public static void ToEmpty()
    {
        Console.WriteLine("Acqua svuotata completamente!");
    }

    //metodo stampaProdotto() che fa l’override del metodo di base StampaProdotto già dichiarato nella superclasse Prodotto
    //(se non lo avete già fatto dichiaratelo anche nella
    //classe prodotto è si occupa di stampare il “codice - nome”,l lo abbiamo chiamato NomeEsteso),
    //per stampare oltre al codice e al nome dell’acqua,
    //anche la sua sorgente, il ph e i litri contenuti.

    public override string ProductPrinter()
    {

        return base.ProductPrinter() + $" Sorgente : {Origin}; \t Ph: {PH}; \t Litri: {Liters}";
    }

    //un metodo statico convertiInGalloni(double litri) che presa una quantità di litri restituisca
    //la conversione dei litri in galloni, sapendo che 1
    //litro è equivalente a 3,785 galloni (ricordatevi di codificare le costanti come 3.785 nel modo
    //corretto come visto in classe).
    public static double Convert(float liters)
    {
        float gallons = 3.785F;
        double unitCoverted = liters * gallons;
        return (double)unitCoverted;
    }
}



