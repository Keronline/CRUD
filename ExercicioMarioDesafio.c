#include <stdio.h>
#include <stdlib.h>
#include <cs50.h>

int main(void)
{
    int numDegrais = 0;
    int cont = 0;
    do{
        printf("Quantos degrais a pirâmide possui: \n");
        scanf("%i", &numDegrais);
    }while(numDegrais < 1 || numDegrais > 8);
    char* vetorDegrais = (char*)malloc(sizeof(char)*2*numDegrais);
    for(int i = numDegrais - 1 ; i >= 0; i--){
        vetorDegrais[i] = '#';
        vetorDegrais[numDegrais + cont] = '#';
        for(int j = 0 ; j < numDegrais * 2 ; j++){
            if(j < i || j > cont + numDegrais){
                printf(" ");
            } else {
                if(j == numDegrais) printf(" ");
                printf("%c", vetorDegrais[j]);
            }
        }
        cont += 1;
        printf("\n");
    }
}