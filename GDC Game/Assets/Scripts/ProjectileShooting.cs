using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShooting : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bulletprefab;

    public float bulletforce = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firepoint.position, firepoint.rotation);
        Destroy(bullet, 5f);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
    }
}