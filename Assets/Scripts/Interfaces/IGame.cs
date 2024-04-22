using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CardGame.Interfaces{
    public interface IGame{
        IDealer Dealer{get;}
<<<<<<< Updated upstream
        bool GameEnded{get;}
=======
        bool EndedGame{get;}
        void StartGame();
>>>>>>> Stashed changes
        void StartRound();
        void PlayRound();
        void ShowWinner();
    }
}
