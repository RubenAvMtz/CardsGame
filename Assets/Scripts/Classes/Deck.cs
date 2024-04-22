using System.Collections;
using System.Collections.Generic;
using CardGame.Interfaces;
using UnityEngine;

namespace CardGame.Classes{
    public class Deck : MonoBehaviour, IDeck
    {
        public void InsertCard(ICard card)
        {
            throw new System.NotImplementedException();
        }

        public void InsertCards(List<ICard> cards)
        {
            throw new System.NotImplementedException();
        }

        public ICard SeeCard(int cardIndex)
        {
            throw new System.NotImplementedException();
        }

        public void ShuffleDeck()
        {
            throw new System.NotImplementedException();
        }

        public ICard TakeCard(int cardIndex)
        {
            throw new System.NotImplementedException();
        }
    }
}

