using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    Material bgMat;
    public float xoffset;
    void Start()
    {
        bgMat = GetComponent<MeshRenderer>().material;
    }
    private void FixedUpdate()
    {
        bgMat.mainTextureOffset = new Vector2(xoffset * Time.time, 0);
    }
}
