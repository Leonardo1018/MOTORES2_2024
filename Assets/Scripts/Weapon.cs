using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform spawnPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
          GameObject newBullet = GameObject.Instantiate(bulletPrefab);
            newBullet.transform.position = spawnPoint.position;
            newBullet.transform.rotation = spawnPoint.rotation;
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 100.0f);
        }
        
    }
}
