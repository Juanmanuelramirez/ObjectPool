using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Esfera : MonoBehaviour, IPoolObj
{
    public float lForce = 3f;

    public void OnObjectSpawn()
    {
        float xForce = Random.Range(-lForce, lForce);
        float zForce = Random.Range(-lForce, lForce);

        Vector3 force = new Vector3(xForce, 40f, zForce);

        GetComponent<Rigidbody>().velocity = force;
    }
}
