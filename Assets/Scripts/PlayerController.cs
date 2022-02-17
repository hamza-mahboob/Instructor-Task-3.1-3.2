using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameManager gameManager;
    BoxCollider bgCollider;
    Rigidbody playerRB;
    //Animator anim;
    float speed = 12, y, offset = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        playerRB = GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
        bgCollider = GameObject.Find("BG").GetComponent<BoxCollider>();
        y = bgCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        //check if game is over
        if (!gameManager.GameOver())
        {
            //boundary
            if (transform.position.y > y - offset)
            {
                transform.position = new Vector3(transform.position.x, y - offset, transform.position.z);
                playerRB.velocity = Vector3.zero;
            }
            //player input to push player up
            if (Input.GetKey(KeyCode.Space))
            {
                playerRB.AddForce(Vector3.up * speed, ForceMode.Impulse);
                //anim.SetTrigger("Jump_trig");
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //if enemy was on ground add forces up & right
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Game Over!");
            gameManager.SetGameOver();
            
            playerRB.AddForce(Vector3.up * 100, ForceMode.Impulse);
            playerRB.AddForce(Vector3.right * 300, ForceMode.Impulse);
        }
        //if enemy was in air add forces down & right
        if (collision.gameObject.CompareTag("Enemy2"))
        {
            Debug.Log("Game Over!");
            gameManager.SetGameOver();

            playerRB.AddForce(Vector3.down * 100, ForceMode.Impulse);
            playerRB.AddForce(Vector3.right * 300, ForceMode.Impulse);
        }
    }
}
