using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFast : Projectile
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    // Polymorphism
    public override void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * 2 * Time.deltaTime);
    }
}
