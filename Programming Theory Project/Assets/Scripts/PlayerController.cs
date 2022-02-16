using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject hitZone;
    private float jumpForce = 7.5f;
    private Rigidbody playerRb;
    private bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Parry();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            UnParry();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    void Parry()
    {
        hitZone.SetActive(true);
    }

    void UnParry()
    {
        hitZone.SetActive(false);
    }

    void Jump()
    {
        {
            if (isOnGround)
            {
                playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isOnGround = false;
            }
        }    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
