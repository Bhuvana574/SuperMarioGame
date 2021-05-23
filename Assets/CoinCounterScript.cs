using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounterScript : MonoBehaviour
{
    Text coinText;
    public static int coinAmount;//Static variables are shared across all instances of a class.

    // Start is called before the first frame update
    void Start()
    {

        coinText = GetComponent<Text>();
        //Returns the component of  type if the game object has one attached.


        

    }
    void Update()
    {
        coinText.text = coinAmount.ToString();
        //tostring is used to display the ui text field

    }

}

