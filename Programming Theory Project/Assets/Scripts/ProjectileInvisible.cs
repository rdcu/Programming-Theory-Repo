using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileInvisible : Projectile
{
    public MeshRenderer mesh;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(BecomeVisible());
        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    IEnumerator BecomeVisible()
    {
        yield return new WaitForSeconds(3);
        mesh.enabled = true;
    }
}
