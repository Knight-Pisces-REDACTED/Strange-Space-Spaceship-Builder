using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class BuildMenuScript : MonoBehaviour
{
    public void NewShip(){
        Globals.currentShip = new Ship("New Ship", Globals.currentFaction);
    }
    public void LoadShips(){
        SceneManager.LoadScene("Ship Selector");
    }
    public void EnterBuilder(){
        SceneManager.LoadScene("Builder");
    }

}
