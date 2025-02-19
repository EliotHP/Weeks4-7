using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelection : MonoBehaviour
{
    public GameObject[] planetPrefabs; 
    private GameObject selectedPlanet;
    // Creates array for objects

    public void SelectPlanet(int index)
    {
        if (index >= 0 && index < planetPrefabs.Length)
        {
            selectedPlanet = planetPrefabs[index];
        }
    }
    //Found "index" online, from my understanding, it creates a list of options that you can choose to select once the button is pressed.
    //This is how I was able to only use one script for all the buttons. In the editor I linked each individual planet to each button, so it only knows to
    //select that one.


    public void PlacePlanet(Vector2 position)
    {
        if (selectedPlanet != null)
        {
            Instantiate(selectedPlanet, position, Quaternion.identity); 
            selectedPlanet = null;
        }
    }
    //Checks if planet is selected (or rather isn't not)
    //if planet is selected, instantiates it, preparing it for the PlanetPlacement script.
    //The null was put in place specifically because every time I would click on a button, it would spawn a planet behind it
    //Adding this makes it so that once you place a planet, it deselects, making it so you have to click the button again to place a new one

}