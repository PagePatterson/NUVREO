using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunController : MonoBehaviour
{
    public GameObject bullet;

    public Transform bulletSpawn;

    public float cooldownSeconds;

    private float lastShootTime = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((OVRInput.Get(OVRInput.Button.One) || Input.GetKeyDown(KeyCode.Space)) && Time.time - lastShootTime > cooldownSeconds)
        {
            GameObject newBullet = Instantiate(bullet, bulletSpawn);
            newBullet.transform.rotation = Quaternion.Euler(transform.forward);
            newBullet.transform.localScale = new Vector3(10, 10, 10);
            lastShootTime = Time.time;
        }
    }
}
