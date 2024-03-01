

#include <iostream>
#include <fstream>
#include <vector>

using namespace std;

int main()
{
    ofstream fout("output.txt");
    string tipoTreno;
    string numero;
    string vettore;
    string provenienza;
    string destinazione;
    string orario;
    string binario;
    string annuncio;
    string annuncio2;
    string tipo;
    string messaggio;
    string fermate;
    int i = 1;
    while(i!=0) {
        cout<<"Inserisci il tipo di annuncio"<<endl;
        cin>>tipo;
        if(tipo=="arrivoTrenoConDestinazione") {
            cout<<"Inserire tipoTreno"<<endl;
            std::cin >>tipoTreno;
            cout<<"Inserisci il numero"<<endl;
            cin>>numero;
            cout<<"Inserisci il vettore"<<endl;
            cin>>vettore;
            cout<<"Inserisci la provenienza"<<endl;
            cin>>provenienza;
            cout<<"inserisci la destinazione"<<endl;
            cin>>destinazione;
            cout<<"Inserisci l'orario"<<endl;
            cin>>orario;
            cout<<"Inserisci il binario"<<endl;
            cin>>binario;
            cout<<"Inserisci le fermate"<<endl;
            cin>>fermate;
            if(fermate==" ") {
                annuncio = "Il_treno%20" + tipoTreno + "," + numero + ",di " + vettore + ",proveniente%20da%20" + provenienza + ",e%20diretto%20a%20" + destinazione + ",delle%20ore%20" + orario + ",%20è%20in%20arrivo%20al%20binario%20" + binario + ",attenzione!%20allontanarsi%20dalla%20linea%20gialla,%20Non%20sono%20previste%20fermate%20intermedie" + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
            }
            else {
                annuncio = "Il_treno%20" + tipoTreno + "," + numero + ",di " + vettore + ",proveniente%20da%20" + provenienza + ",e%20diretto%20a%20" + destinazione + ",delle%20ore%20" + orario + ",%20è%20in%20arrivo%20al%20binario%20" + binario + ",attenzione!%20allontanarsi%20dalla%20linea%20gialla.%20Ferma%20a:" + fermate + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
            }
            annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
            fout<<annuncio2;
        }
        if(tipo=="arrivoTrenoConRitardo") {
            cout<<"Inserire tipoTreno"<<endl;
            std::cin >>tipoTreno;
            cout<<"Inserisci il numero"<<endl;
            cin>>numero;
            cout<<"Inserisci il vettore"<<endl;
            cin>>vettore;
            cout<<"Inserisci la provenienza"<<endl;
            cin>>provenienza;
            cout<<"inserisci la destinazione"<<endl;
            cin>>destinazione;
            cout<<"Inserisci l'orario"<<endl;
            cin>>orario;
            string ritardo;
            cin>>ritardo;
            annuncio = "Annuncio ritardo!%20Il_treno%20" + tipoTreno + "," + numero + ",di " + vettore + ",proveniente%20da%20" + provenienza + ",e%20diretto%20a%20" + destinazione + ",delle%20ore%20" + orario + ",arriverà%20con%20un%20ritardo%20previsto%20di" + ritardo + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
            annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
            fout<<annuncio2;
        }
        if(tipo=="trenoInTransito") {
            cout<<"inserire il binario"<<endl;
            cin>>binario;
            annuncio = "Attenzione!%20Treno%20in%20transito%20al%20binario%20" + binario + "%20.allontanarsi%20dalla%20linea%20gialla" + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
            annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
            fout<<annuncio2;
        }
        if(tipo=="trenoInArrivo") {
            cout<<"inserire il binario"<<endl;
            cin>>binario;
            annuncio = "Attenzione!%20Treno%20in%20arrivo%20al%20binario%20" + binario + "%20.allontanarsi%20dalla%20linea%20gialla" + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
            annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
            fout<<annuncio2;
        }
        if(tipo=="trenoInManovra") {
            cout<<"inserire il binario"<<endl;
            cin>>binario;
            annuncio = "Attenzione!%20Treno%20in%20manovra%20al%20binario%20" + binario + "%20.allontanarsi%20dalla%20linea%20gialla" + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
            annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
            fout<<annuncio2;
        }
        if(tipo=="annuncioInformazioni") {
            cout<<"inserire l'annuncio"<<endl;
            cin>>messaggio;
            annuncio = "attenzione!%20" + messaggio;
            annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
            fout<<annuncio2;
        }
        i=0;
    }

    /*cout<<"Inserire tipoTreno"<<endl;
    std::cin >>tipoTreno;
    cin>>numero;
    cin>>vettore;
    cin>>provenienza;
    cin>>destinazione;
    cin>>orario;
    cin>>binario;
    annuncio = "Il treno " + tipoTreno + "," + numero + ",di " + vettore + ",proveniente da " + provenienza + ",e diretto a " + destinazione + ",delle ore " + orario + ", è in arrivo al binario " + binario + ",attenzione! allontanarsi dalla linea gialla" + "&EXT=mp3&FNAME=&ACC=15679&SceneID=2756153&HTTP_ERR=&cache_flag=3";
    annuncio2 = "https://cache-a.oddcast.com/tts/genB.php?EID=2&LID=7&VID=7&TXT=" + annuncio;
    fout<<annuncio2; */

    return 0;
}
