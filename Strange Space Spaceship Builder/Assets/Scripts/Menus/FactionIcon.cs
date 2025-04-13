using UnityEngine;

public class FactionIcon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    GameObject mh;
    void Start()
    {
        mh = GameObject.Find("BuildMenuHandler");
    }

    // Update is called once per frame
    void Update()
    {
        print(Globals.currentFaction);
        GetComponent<SpriteRenderer>().sprite = mh.GetComponent<BuildMenuScript>().TransformImage();

    }
}
