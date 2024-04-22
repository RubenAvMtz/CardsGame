using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame.Interfaces{
    public interface IPlayer{
        void MakeAMove();
        void GetCards(List<ICard> cards);
        ICard ReturnCard(int cardIndex);
        List<ICard> ReturnAllCards();
        List<ICard>ShowCards();
        ICard ShowCard(int CardIndex);

    }
}
