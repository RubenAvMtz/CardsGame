using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame.Interfaces{
    public interface Deck{
        void ShuffleDeck();
        ICard SeeCard(int cardNumber);
        ICard TakeCard(int cardNumber);
        void InsertCard(ICard card);
        void InsertCard(List<ICard> cards);
    }
}
