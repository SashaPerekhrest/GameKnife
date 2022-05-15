using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VigVig : MonoBehaviour
{
    public float fallSpeed = 1f;
    private bool top = true;
    void Update()
    {
        if (top)
        {
            transform.position -= new Vector3(0, fallSpeed * Time.deltaTime, 0);
            if (transform.position.y < -2.9f)
            {
                top = false;
            }
        }
        else
        {
            transform.position -= new Vector3(0, -fallSpeed * Time.deltaTime, 0);
            if (transform.position.y > -1.48f)
            {
                top = true;
            }
        }
    }
}
