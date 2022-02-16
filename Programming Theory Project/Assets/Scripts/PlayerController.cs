using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject hitZone;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    void Parry()
    {
        hitZone.SetActive(true);
    }

    void UnParry()
    {
        hitZone.SetActive(false);
    }
}
