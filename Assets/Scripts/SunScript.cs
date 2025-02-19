using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SunScript : MonoBehaviour
{
    public float sunGravity = 750f;
    public float destroyDistance = 0f;
    


    // First and foremost, I'm assuming you will start by looking at this script first, in which case, you will see a few commented out
    // parts including debugging and etc. I've decided to leave them so you can see my porgress more clearly
    void Update()
    {
        GameObject[] planets = GameObject.FindGameObjectsWithTag("planet");
      //  Debug.Log("Planets Found: " + planets.Length);

        // searched for objects with tag "planet" this was the easiest way I could find to have the sun interact specifically with each of the 
        // celestial bodies (planets, asteroids, etc)

        foreach (GameObject planet in planets)
        {
            float distance = Vector2.Distance(transform.position, planet.transform.position);
            Planet1Script planetScript = planet.GetComponent<Planet1Script>();
            if (planetScript != null)
            {
             //   Debug.Log("Applying gravity to: " + planet.name);
                gravity(planetScript);
            }
         //  else
         //   {
         //       Debug.LogError("Planet1Script not found on " + planet.name);
         //   }

            //Checks for planet, applies gravity function (shown below) to planet

            if (distance <= destroyDistance)
            {
                Destroy(planet);
            }

            //if planet goes into sun, it will destroy the object. Originally I had this in the "Planet1Script", but this proved finicky
            //so for convenience it was moved here
        }

        void gravity(Planet1Script planetScript)
        {
            Vector3 direction = transform.position - planetScript.transform.position;

            float distance = direction.magnitude;

            if (distance == 0) return;
            // no dividing by 0

            float gravForce = sunGravity / (distance * distance);
            //Gravitational Constant

            Vector3 acceleration = direction.normalized * gravForce;
            //calculates acceleration that the objects will recieve due to gravity

            planetScript.ApplyAcceleration(acceleration);
            //Applies acceleration
        }
        //to explain in simplest terms, this essentially just sets up, and calculates the gravitational constant (simplified because I'm lazy) of
        //Force = gravity / distance^2. This was how I decided to do this project as I realized its actually decently simple to do in unity.
        //This is the one thing I remember from physics class. It has served me well
    }
    public void Slide(float g)
        {
        sunGravity = g;
    }
}// Soul reason for this existing is so that I can make a slider which changes the suns gravity. It will always default to 750, but you can change it with
// the slider 
