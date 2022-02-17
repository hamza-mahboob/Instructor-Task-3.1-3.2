using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    GameManager gameManager;
    BoxCollider boxCollider;
    Vector3 startPos;
    float x, speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        boxCollider = GetComponent<BoxCollider>();
        startPos = transform.position;
        x = boxCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //scroll and reset background if game is not over
        if (!gameManager.GameOver())
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < startPos.x - x - 8)
                transform.position = startPos;
        }
    }
}
