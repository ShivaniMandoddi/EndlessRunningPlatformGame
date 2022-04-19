using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMovement.IsGameOver == false)
        {
            if (transform.position.x < -20f)
            {
                transform.position = new Vector2(30f, transform.position.y);
            }
            transform.Translate(Vector2.left * 3f * Time.deltaTime);
        }
    }
}
