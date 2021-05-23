using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
        //when another object enters a trigger collider attached to this object
    {
        if(collision.gameObject.tag=="Player")
        {
            CoinCounterScript.coinAmount += 100;
            Destroy(gameObject);
        }
    }
   
}
