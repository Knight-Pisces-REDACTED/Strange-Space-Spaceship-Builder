using System;
using UnityEngine;

public class BuildLogic : MonoBehaviour
{
    int currPart;
    public Sprite[] sprites = new Sprite[4];
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectPart(String part){
        if (part == null){
            currPart = 0;
        }
        else if (part == "gun"){
            currPart = 1;
        }
        else if (part == "thruster"){
            currPart = 2;
        }
        else if (part == "shield"){
            currPart = 3;
        }
        else{
            Debug.Log("You made a spelling mistake");
        }
    }
    public int getCurrentPart(){
        return currPart;
    }
    public Sprite getSpriteFromPart(int part){
        return sprites[part];
    }
}
