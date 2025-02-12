using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BulletBehavior : MonoBehaviour
{
    public bool Shot = false;
    public float speed = 10f;
    public GameObject Dave;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 bulletInScreenSpace = Camera.main.WorldToScreenPoint(pos);
        if (Input.GetMouseButtonDown(0) == true)
        {
            Shot = true;
        }
        if (Shot)
        {
            transform.position += transform.right * speed * Time.deltaTime;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (bulletInScreenSpace.x < -1 || bulletInScreenSpace.x > Screen.width)
        {
            Shot = false;
        }
        if (bulletInScreenSpace.y < -1 || bulletInScreenSpace.y > Screen.height)
        {
            Shot = false;
        }
        if (Shot == false)
        {
            transform.position = Dave.transform.position;
            transform.eulerAngles = Dave.transform.eulerAngles;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

    }
}

