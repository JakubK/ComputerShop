#include <stdio.h>
#include <stdlib.h>

#define Max 100

struct Osoba{
char * pesel;
char * imie;
char * nazwisko;
char ** jezyki[11];
};


void WczytajOsoby(struct Osoba Osoby[Max],int iloscOsob){
    do{
    printf("%s","Podaj ile chcesz wczytac osob (max 100): ");
    scanf("%d",&iloscOsob);
    if(iloscOsob<=100)
        break;
    }while(1==1);

    for(int i = 0;i<iloscOsob;i++){


    }

}

int main()
{
    int iloscOsob;
    struct Osoba Osoby[Max];
    WczytajOsoby(&Osoby,&iloscOsob);

    printf("Hello world!\n");
    return 0;
}
