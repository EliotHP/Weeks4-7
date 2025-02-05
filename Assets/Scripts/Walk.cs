using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Walk : MonoBehaviour

{
    public SpriteRenderer sr;
    public GameObject watermelon;
    public float speed = 5;
  // public float speedX = 5f;
  // public float speedY = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0);

        if (pos.x >= watermelon.transform.position.x -2)
        {
            sr.enabled = true;
        }


        if (pos.x <= watermelon.transform.position.x -2 || pos.x >= watermelon.transform.position.x +2)
        {
            sr.enabled = false;
        }


        //  Vector2 pos = transform.position;
        //  if (Input.GetKey(KeyCode.W))
        //  {
        //     pos.y += speedY * Time.deltaTime;

        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //      pos.x -= speedX * Time.deltaTime;
        //  }
        //  if (Input.GetKey(KeyCode.S))
        //  {
        //      pos.y -= speedY * Time.deltaTime;
        //   }
        //  if (Input.GetKey(KeyCode.D))
        //  {
        //      pos.x += speedX * Time.deltaTime;
        //  }
        //  transform.position = pos;
    }
}
