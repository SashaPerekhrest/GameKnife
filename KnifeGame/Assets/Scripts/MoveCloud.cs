using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCloud : MonoBehaviour
{
    [SerializeField] public float speed = 1f;
    
    void Update()
    {
        if (transform.position.x > 3.5f)
            Destroy(gameObject);
        transform.position -= new Vector3(- speed * Time.deltaTime, 0, 0);
    }
}
