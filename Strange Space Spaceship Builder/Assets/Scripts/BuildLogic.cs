using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BuildLogic : MonoBehaviour
{
    public TMP_Text NameField;
    public string FileName;
    private FileDataHandler handler;
    int currPart;
    public Sprite[] sprites = new Sprite[4];
    public Sprite[] facSprites = new Sprite[2];
    public Sprite facSprite;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.handler = new FileDataHandler(Application.persistentDataPath, FileName);
        if (Globals.currentFaction == "Daicosreyn"){
            facSprite = facSprites[0];
        } else if (Globals.currentFaction == "Rehman Empire"){
            facSprite = facSprites[1];
        }
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
    public Sprite getFacSprite(){
        return facSprite;
    }
    public void SaveShip(){
        
    }
    public void QuittoMain(){
        SceneManager.LoadScene("MainMenuScene");
    }
}
