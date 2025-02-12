using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCodingGym : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,0,0);
    }
    public void Slide(float s)
    {
        speed = s;
    }
}
