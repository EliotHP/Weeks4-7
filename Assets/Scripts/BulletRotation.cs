using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BulletRotation : MonoBehaviour
{
    public GameObject Dave;
    public bool Shot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) == true)
        {
            Shot = true;
        }
        if (Shot)
        {
            Vector2 direction = transform.position;

        }
        else
        {
            transform.position = Dave.transform.position;
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = mouse - transform.position;

            transform.right = direction;
        }
    }
}
