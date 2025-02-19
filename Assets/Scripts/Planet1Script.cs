using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet1Script : MonoBehaviour
{
    public Vector3 velocity;
    //public GameObject sun;

    void Update()
    {
        Debug.DrawRay(transform.position, velocity * 2, Color.green);
        //Found "DrawRay" online, helps show trajectory of the planets which helped to see if gravity was being applied
        transform.position += velocity * Time.deltaTime; 
        //Starting velocity of planets, without this they just sink into the sun.

       // if (transform.position == sun.transform.position)
       //   {
       //      Destroy(gameObject);
       //  }

        // My original attempt to destroy objects when they go into the sun. Did not work very well
    }

    public void ApplyAcceleration(Vector3 acceleration)
    {
        velocity += acceleration * Time.deltaTime;
        //Applies acceleration (gravity) from the sun to the planets
        Debug.Log(gameObject.name + " New Velocity: " + velocity);
       // Originally I wasn't sure if the gravity was working. Turned out it was and it was just too low for any affect to take place on the planets
       //This debug and the DrawRay debug was how I figured this out.
    }
}

