using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonBonMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public float fallSpeed = 0.5f;
    private GameObject bon1;
    private GameObject bon2;
    void Start()
    {
        transform.localPosition = new Vector3(0.4f, -0.36f, 0f);
        transform.localRotation = Quaternion.identity;
        transform.localScale = new Vector3(1f,1f,1f);
        bon1 = transform.Find("Cube").gameObject;
        bon2 = transform.Find("Cube1").gameObject;
    }

    private void Update()
    {
        transform.localPosition -= new Vector3(fallSpeed * Time.deltaTime,0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            bon1.GetComponent<Animator>().enabled = true;
            bon2.GetComponent<Animator>().enabled = true;
        }
    }
}
