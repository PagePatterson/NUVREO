using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Target>() != null)
        {
            //send hit message
            //gameController.onTargetHit();
            Destroy(other.gameObject);
            Destroy(this);
        }
    }
}
