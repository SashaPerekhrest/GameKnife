using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class SpawnC : MonoBehaviour
{
    public GameObject chlen;
    public GameObject gondon;
    private int countOfGood;
    
    private void Start()
    {
        StartCoroutine(Spawn ());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(1.5f);
        for (;;)
        {
            var vibor = Random.Range(1, 3);
            if (Game.life)
            {
                if (vibor == 1)
                    Instantiate(chlen, new Vector3(Random.Range(-1.85f, 1.85f), 8f),new Quaternion(180f, 0f, 0f, 0f));
                else
                {
                    Instantiate(gondon, new Vector3(Random.Range(-1.85f, 1.85f), 8f),new Quaternion(180f, 0f, 0f, 0f));
                    countOfGood++;
                }
            }

            if (countOfGood > 10)
            {
                yield return new WaitForSeconds(2f);
                Game.life = false;
                yield break;
            }

            yield return new WaitForSeconds(0.7f);
        }
    }
}

