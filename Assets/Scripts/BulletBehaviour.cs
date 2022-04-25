using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{

    public float bulletSpeed { get; } = 10f;

    void Start()
    {
        Debug.Log("New Bullet generated");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected!");
        if (collision.gameObject.name != "Turret")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void Shoot()
    {
        Rigidbody2D bulletRB = GetComponent<Rigidbody2D>();
        transform.Translate(0f, 0.1f, 1.5f);
        bulletRB.AddForce(bulletRB.transform.right * bulletSpeed, ForceMode2D.Impulse);
        Debug.Log(bulletRB.transform.right + " " + bulletRB.velocity);
    }
}
