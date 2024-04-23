using System.Collections;
using System.Collections.Generic;
using CardGame.Interfaces;
using UnityEngine;

public class Dealer : MonoBehaviour,IDealer
{
    public void CollectCards(List<ICard> cards)
    {
        throw new System.NotImplementedException();
    }

    public List<ICard> DealCards(int numberOfCards)
    {
        throw new System.NotImplementedException();
    }

    public void ShuffleDeck()
    {
        throw new System.NotImplementedException();
    }
}
