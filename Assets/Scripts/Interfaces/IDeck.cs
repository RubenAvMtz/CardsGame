using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame.Interfaces{
    public interface IDeck{
        void ShuffleDeck();
        ICard SeeCard(int cardIndex);
        ICard TakeCard(int cardIndex);
        void InsertCard(ICard card);
        void InsertCards(List<ICard> cards);
    }
}
