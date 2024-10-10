using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * speed);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<targetController>() != null)
        {
            Destroy(gameObject);
        }
    }
}
