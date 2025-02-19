using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeRoof : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 PlayerPos = Player.transform.position;
        if (PlayerPos.y == pos.y)
        {
             PlayerPos = new Vector2(0,-1);
        }
    }
}
