using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float ceiling = 11;

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y > ceiling)
        {
            Destroy(this.gameObject);
        }
    }
}
