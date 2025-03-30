using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BuildMenuScript : MonoBehaviour
{
    public void NewShip(){
        
    }
    public void EnterBuilder(){
        SceneManager.LoadScene("Builder");
    }
}
