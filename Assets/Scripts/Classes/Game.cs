using System.Collections;
using System.Collections.Generic;
using CardGame.Classes;
using CardGame.Enumerators;
using CardGame.Interfaces;
using UnityEngine;

public class Game : MonoBehaviour, IGame
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IDealer Dealer => throw new System.NotImplementedException();

    public bool GameEnded => throw new System.NotImplementedException();

    public void playRound()
    {
        throw new System.NotImplementedException();
    }

    public void ShowWinner()
    {
        throw new System.NotImplementedException();
    }

    public void StartGame()
    {
        //Initialize the deck
        Deck deck = new Deck();
        deck.FillDeck();
       
    }

    public void StartRound()
    {
        throw new System.NotImplementedException();
    }
}
