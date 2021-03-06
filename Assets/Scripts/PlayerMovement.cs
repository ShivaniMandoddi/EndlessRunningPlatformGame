using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float playerJumpSpeed;
    Rigidbody2D rb;
    public Text scoreText;
    int score;
    float time;
    public bool IsGameOver = false;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGameOver == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector2(0f, playerJumpSpeed), ForceMode2D.Impulse);
            }
            time = time + Time.deltaTime;
            if (time > 2f)
            {
                score = score + 1;
                time = 0f;
                scoreText.text = "Score: " + score;
                //Debug.Log(score);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            Debug.Log("GameOver");
            IsGameOver = true;
        }
    }
}
