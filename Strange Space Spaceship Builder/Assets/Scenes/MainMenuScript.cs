using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuScript
{
    public Button buildButton;
    private void Start() {
        buildButton.onClick.AddListener(() => OnBuildButtonClick());

    }
    private void OnDestroy(){
        buildButton.onClick.RemoveAllListeners();
    }
    public void OnBuildButtonClick(){
        //SceneManager.LoadScene(sceneName:"BuildMenuScene");
        Debug.Log("Button works");
    }
}
