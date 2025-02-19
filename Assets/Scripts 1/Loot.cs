using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public GameObject Player;
    public bool HasLoot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        if (Player.transform.position.x <= pos.x +5 && Player.transform.position.x >= pos.x - 5)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
                HasLoot = true;
            }
        }
    }
}
