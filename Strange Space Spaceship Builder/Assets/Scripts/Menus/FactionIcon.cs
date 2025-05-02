using System;
using UnityEngine;

public class FactionIcon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject mh;
    [SerializeField] Sprite startSprite;
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = startSprite;
    }

    // Update is called once per frame
    void Update()
    {
        if (mh.name == "BuildMenuHandler"){
            GetComponent<SpriteRenderer>().sprite = mh.GetComponent<BuildMenuScript>().GetFacSprite();
        } else if (mh.name == "BuildLogicer"){
            GetComponent<SpriteRenderer>().sprite = mh.GetComponent<BuildLogic>().getFacSprite();
        }
    }

}
