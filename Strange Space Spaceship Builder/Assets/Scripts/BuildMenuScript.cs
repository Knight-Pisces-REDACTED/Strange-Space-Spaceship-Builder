using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BuildMenuScript : MonoBehaviour
{
    public void NewShip(){

    }
    private ShipClassScript SelectedShip;
    public void EnterBuilder(){
        SceneManager.LoadScene("Builder");
    }
}
