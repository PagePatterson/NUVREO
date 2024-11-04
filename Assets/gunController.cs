using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
<<<<<<< Updated upstream
    public GameObject bulletPrefab;
=======
    public GameObject bullet;

    public Transform bulletSpawn;

    public float cooldownSeconds;

    private float lastShootTime = 0.0f;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab);
        }
    }
    
=======
        if ((OVRInput.Get(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.Space)) && Time.time - lastShootTime > cooldownSeconds)
        {
            Instantiate(bullet, bulletSpawn);
            lastShootTime = Time.time;
        }
    }
>>>>>>> Stashed changes
}
