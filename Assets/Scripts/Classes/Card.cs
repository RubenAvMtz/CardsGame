using System.Collections;
using System.Collections.Generic;
using CardGame.Enumerators;
using CardGame.Interfaces;
using Unity.VisualScripting;
using UnityEngine;

namespace CardGame.Classes{
public class Card : MonoBehaviour, ICard
{
    private CardFiguresEnum figure;
    public CardFiguresEnum Figure {
        get{
            return figure;
        }
        private set{
            figure = value;
        }
    }
    private CardValuesEnum cardvalue;
    public CardValuesEnum Value {
        get{
            return cardvalue;
        }
        private set{
            cardvalue = value;
        }
    }

    public Card(CardFiguresEnum figure, CardValuesEnum value){
        Figure = figure;
        Value = value;
    }

}
}
