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

public class FruitsBag : Product
{

    byte MaxPieces { get; } = 5;
    public string FruitType { get; set; }
    bool biologic { get; set; } = false;
    string Origin { get; }
    byte Pieces { get; }

    //costruttore
    public FruitsBag(string name, float price, byte pieces, string origin) : base(name, price)
    {
        this.biologic = biologic;
        this.Origin = origin;
        this.Pieces = pieces;
    }

    public override string ProductPrinter()
    {

        return base.ProductPrinter() + $"\n Origine : {Origin}; \n Pezzi nella confezione: {Pieces}; \n Frutto: {FruitType}";
    }

}



