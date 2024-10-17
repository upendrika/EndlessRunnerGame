using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{
    
    public static int coinCount = 0;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;

    void Start()
    {
        coinCount = 0; // Reset coinCount when the game starts
    }
    
    void Update()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
        coinEndDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
