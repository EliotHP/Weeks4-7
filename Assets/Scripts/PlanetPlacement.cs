using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlanetPlacement : MonoBehaviour
{
    private PlanetSelection planetSelector;

    void Start()
    {
        planetSelector = FindObjectOfType<PlanetSelection>();  
    }
    //Checks for what planet is selected (from Planet Selection script)

    void Update()
    {
        if (Input.GetMouseButtonDown(0))  
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  

            planetSelector.PlacePlanet(mousePosition);  
        }
    }
    //Pretty obvious what this does. If mouse is clicked, place planet on that location
}

