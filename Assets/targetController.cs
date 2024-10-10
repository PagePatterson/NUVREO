using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<bulletController>() != null)
        {
            //hit by bullet
            print("i've been hit by a bullet. dying now.");
            Destroy(gameObject);
        }
    }
}
