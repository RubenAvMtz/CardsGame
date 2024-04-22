using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame.Interfaces{
    public interface IGame{
        IDealer Dealer{get;}
        bool GameEnded{get;}
        void StartRound();
        void PlayRound();
        void ShowWinner();
    }
}
