using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    // INHERITANCE (Entire script)
    private float m_speed = 5;
    // Encapsulation
    public float speed
    {
        get { return m_speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative projectile speed");
            }
            else
            {
                m_speed = value;
            }
        }
    }
    

    // Polymorphism
    public virtual void MoveLeft()
    {
        transform.Translate(Vector3.left * m_speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
