using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCloud : MonoBehaviour
{
    public GameObject cloud;
    
    void Start()
    {
        StartCoroutine(Spawn ());   
    }
    
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(5f);
        for (;;)
        {
            Instantiate(cloud, new Vector2(-3.8f, Random.Range(-0.2f, 4.7f)), Quaternion.identity);
            yield return new WaitForSeconds(15f);
        }
    }
}
