using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, "None"));
        cardList.Add(new Card(1, "Aumento de fecundidade", 3, "Amplie em duas vezes a gera��o de filhotes por casal em sua popula��o durante 2 rodadas."));
        cardList.Add(new Card(2, "Desinteresse", 3, "Interrompa a gera��o de filhotes por casal na popula��o inimiga durante 2 rodadas."));
        
    }
}
