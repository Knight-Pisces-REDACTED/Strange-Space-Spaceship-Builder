using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class ShipClassScript
{
    public class Ship{
        public int totalWeight;
        public int height;
        public int hullLength;
        public int hullWidth;
        public int wingLength;
        public int wingWidth;
        public int wingCount;
        public int thrusterCount;
        public int decks;
        public Ship(){
            decks = height/4;
        }
        public void Move(){
            

        }
    }
}
