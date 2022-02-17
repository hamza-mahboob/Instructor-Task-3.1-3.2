using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("SpawnEnemy", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        //spawn enemies/obstacles if game is not over
        if (!gameManager.GameOver())
            Instantiate(enemy[Random.Range(0, enemy.Length)]);
    }
}
