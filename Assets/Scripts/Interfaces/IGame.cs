using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame.Interfaces{
    public interface IGame{
        IDealer Dealer{get;}
        void StartGame();
        void StartRound();
        void playRound();
        void ShowWinner();
    }
}
