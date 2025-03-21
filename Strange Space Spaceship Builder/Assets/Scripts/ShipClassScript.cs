using NUnit.Framework.Internal;
using UnityEngine;

public class ShipClassScript
{
    public class Ship{
        public int weight;
        public int height;
        public int length;
        public int width;
        public int decks;
        public Ship(){
            decks = height/4;
        }
    }
}
