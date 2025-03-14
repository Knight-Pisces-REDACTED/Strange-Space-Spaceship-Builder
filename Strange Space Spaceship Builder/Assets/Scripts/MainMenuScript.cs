using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void BuildThings(){
        SceneManager.LoadScene("BuildMenu");
    }
    public void ShootThings(){
        SceneManager.LoadScene("CombatMenu");
    }
    public void CheckThings(){
        SceneManager.LoadScene("PersonalData");
    }
    public void Settings(){
        SceneManager.LoadScene("Settings Screen");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
