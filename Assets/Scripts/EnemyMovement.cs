using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    EnemySpawing enemySpawing;
    PlayerMovement playerMovement;
    void Start()
    {
        enemySpawing = GameObject.Find("EnemySpawing").GetComponent<EnemySpawing>();
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.IsGameOver == false)
        {
            transform.Translate(Vector2.left * 3f * Time.deltaTime);
            if (transform.position.x < -20f)
            {
                enemySpawing.BackToStack(gameObject);
            }
        }
    }
}
