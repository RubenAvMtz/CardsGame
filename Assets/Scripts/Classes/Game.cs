using System.Collections;
using System.Collections.Generic;
using CardGame.Classes;
using CardGame.Enumerators;
using CardGame.Interfaces;
using UnityEngine;

public class Game : MonoBehaviour, IGame
{
    private Deck deck;
    private Player player;
    private Dealer dealer;
    // Start is called before the first frame update
    void Start()
    {
        // Initialize the deck
        deck = new Deck();
        deck.FillDeck();

        // Initialize player and dealer
        player = new Player();
        dealer = new Dealer();

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public IDealer Dealer => throw new System.NotImplementedException();

    public bool GameEnded => throw new System.NotImplementedException();

    public void PlayRound()
    {
        throw new System.NotImplementedException();
    }

    public void ShowWinner()
    {
        throw new System.NotImplementedException();
    }

    public void StartRound()
    {
        throw new System.NotImplementedException();
    }
}
