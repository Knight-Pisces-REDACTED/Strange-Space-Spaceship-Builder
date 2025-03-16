using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildMenuScript : MonoBehaviour
{
    public void NewShip(){

    }
    private Ship SelectedShip;
    public void EnterBuilder(){
        SceneManager.LoadScene("Builder");
        ShipInBuilder = SelectedShip;
    }
}
