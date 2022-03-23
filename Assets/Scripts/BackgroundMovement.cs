using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<-20f)
        {
            transform.position = new Vector2(30f,transform.position.y);
        }
        transform.transform.Translate(Vector2.left * 3f*Time.deltaTime);
    }
}
