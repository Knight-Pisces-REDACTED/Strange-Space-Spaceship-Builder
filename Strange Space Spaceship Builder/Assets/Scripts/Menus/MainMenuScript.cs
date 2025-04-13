using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void Start()
    {
        Globals.currentShip = null;
        Globals.currentFaction = null;
    }
    public void BuildThings(){
        SceneManager.LoadScene("BuildMenu");
        Debug.Log("Entered build menu");
    }
    public void ShootThings(){
        Debug.Log("Out of order");
        //SceneManager.LoadScene("CombatMenu");
    }
    public void CheckThings(){
        Debug.Log("Testing prefab button");
        //SceneManager.LoadScene("PersonalData");
    }
    public void Settings(){
        SceneManager.LoadScene("Settings Screen");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
