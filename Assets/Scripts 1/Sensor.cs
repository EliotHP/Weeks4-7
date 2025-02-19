using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    public GameObject Player;
    public GameObject SpikeSensor1;
    public GameObject SpikeSensor2;
    public bool Spikes = false;
    public bool Boulder = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player.transform.position.x >= SpikeSensor1.transform.position.x && Player.transform.position.x <= SpikeSensor2.transform.position.x)
        {
            Spikes = true;
        }
        else
        {
            Spikes = false;
        }
    }
}
