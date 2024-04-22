using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CardGame.Enumerators;

namespace CardGame.Interfaces{
    public interface ICard{
        CardFiguresEnum Figure {get;}
        CardValuesEnum Value {get;}
    }
}
