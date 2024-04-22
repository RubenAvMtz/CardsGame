using System.Collections;
using System.Collections.Generic;
using CardGame.Interfaces;
using CardGame.Classes;
using CardGame.Enumerators;
using UnityEngine;

namespace CardGame.Classes{
    public class Deck : MonoBehaviour, IDeck
    {
        private List<ICard> cards;
        public Deck(){
            cards = new List<ICard>();
        }

        public void FillDeck(){
             for(int i = 1; i<5; i++){ //Figure
                for(int j = 2; j < 15; j++){ //Value
                    Card card = new Card((CardFiguresEnum)i, (CardValuesEnum)j);
                }
            }
        }
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

