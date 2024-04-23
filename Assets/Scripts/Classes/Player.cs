using System.Collections;
using System.Collections.Generic;
using CardGame.Interfaces;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public void GetCards(List<ICard> cards)
    {
        throw new System.NotImplementedException();
    }

    public void MakeAMove()
    {
        throw new System.NotImplementedException();
    }

    public List<ICard> ReturnAllCards()
    {
        throw new System.NotImplementedException();
    }

    public ICard ReturnCard(int cardIndex)
    {
        throw new System.NotImplementedException();
    }

    public ICard ShowCard(int CardIndex)
    {
        throw new System.NotImplementedException();
    }

    public List<ICard> ShowCards()
    {
        throw new System.NotImplementedException();
    }
}
