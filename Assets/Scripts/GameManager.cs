using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool isGameOver;
    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //getter
    public bool GameOver()
    {
        return isGameOver;
    }
    //setter
    public void SetGameOver()
    {
        isGameOver = true;
    }
}
