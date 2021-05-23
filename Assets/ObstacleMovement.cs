using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;


public class ObstacleMovement : MonoBehaviour
{
    int speedAmt = 5;
    public float x;
    public float y;
    SpriteRenderer EnemyObj;
   
    // Start is called before the first frame update
    void Start()
    {
        EnemyObj = GetComponent<SpriteRenderer>();
        //Sprite Renderer component renders the Sprite and controls
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x <= x)
        {
            speedAmt = 5;
            EnemyObj.flipX = false;
        }
        if (transform.position.x >= y)
        {
            speedAmt = -5;
            EnemyObj.flipX = true ;
        }
        transform.Translate(speedAmt * Time.deltaTime, 0, 0);//time.deltatime updates the timetaken

    }
  
}

