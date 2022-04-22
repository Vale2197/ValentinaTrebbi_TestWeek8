// See https://aka.ms/new-console-template for more information
using ConsoleAppRubrica.Data.RepoAdo;
using ConsoleAppRubrica.Data.RepoMock;
using ConsoleAppRubrica.Presentation.BusinessLayer;

Console.WriteLine("---RUBRICA---");
//Ogni Contatto è caratterizzato da Nome e Cognome e può avere più indirizzi associati.
//Ogni Indirizzo è caratterizzato da Tipologia (es. “Domicilio” o “Residenza”), via, Città, CAP, Provincia, 
//    Nazione.Un indirizzo può riferirsi ad un solo Contatto.
//Deve essere possibile:
//1.Visualizzare tutti i Contatti.
//2. Aggiungere un nuovo Contatto.
//3. Aggiungere un Indirizzo. In fase di inserimento dell’indirizzo deve essere chiesto
//    all’utente a quale Contatto si deve associare l’indirizzo.
//4. Eliminare un Contatto solo se NON ha un indirizzo associato.
//La PK delle entità deve essere un ID intero auto-incrementante.
//• Realizzare il modello Entità-Relazione.
//• Utilizzare l’architettura a 3 Layer (Presentation, Core e Access Data).Per il Data Access lavorare 
//    inizialmente con la RepositoryMock, quindi utilizzare in un secondo momento ADO per realizzare lo strato di 
//    persistenza dei dati.
//• (Opzionale) Realizzare 1 Test Case(in un progetto di Test dedicato) per la funzionalità “Aggiungi Contatto”
//NOTA:

bool program = true;
int choice;

//BusinessLayer bl = new BusinessLayer(new RepoContatto(), new RepoIndirizzo());
BusinessLayer bl = new BusinessLayer(new ADOContatto(), new ADOIndirizzo());

do
{
    Menu();
    choice = bl.LeggiNum();
    switch (choice)
    {
        case 1:
            bl.GetAllContacts();
            break;

        case 2:
            bl.AddContact();
            break;

        case 3:
            bl.AddAddress();
            break;

        case 4:
            bl.RemoveContact();
            break;

        case 5:
            program = false;
            break;

        case 6:
            if(!bl.GetContactsWithAdress())
            {
                Console.WriteLine("non ci sono contatti con indirizzi assegnati");
            }
            break;

        default:
            Console.WriteLine("scelta non valida");
            break;
    }

} while (program);


void Menu()
{
    Console.WriteLine("1- visualizza tutti i contatti");
    Console.WriteLine("2- aggiungi nuovo contatto");
    Console.WriteLine("3- aggiungi indirizzo");
    Console.WriteLine("4- elimina contatto");
    Console.WriteLine("5- esci");
    Console.WriteLine("6- vedi contatti con indirizzi");
}
