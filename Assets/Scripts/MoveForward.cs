using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //move enemies/obstacles left if game is not over
        if (!gameManager.GameOver())
            transform.Translate(Vector3.left * Time.deltaTime * 10);
    }
}
