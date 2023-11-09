using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Player playerOne;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = new Player();
        playerOne.Name = "Irfan";
        playerOne.Score = 0.0;
        playerOne.Lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Name: " + playerOne.Name + ", Score: " + playerOne.Score + ", Lives: " + playerOne.Lives);
    }
}
