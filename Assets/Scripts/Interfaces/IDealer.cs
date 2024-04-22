using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CardGame.Interfaces{
    public interface IDealer{
        List <ICard> DealCards(int numberOfCards);
        void CollectCards(List<ICard> cards);
        void ShuffleDeck();
    }
}
