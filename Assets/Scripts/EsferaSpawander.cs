using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaSpawander : MonoBehaviour
{
    public string etiqueta;
    ObjectPool objectPool;

    // Start is called before the first frame update
    void Start()
    {
        objectPool = ObjectPool.Instance;
    }

    private void FixedUpdate()
    {
        Vector3 randonPos = new Vector3(transform.position.x, Random.Range(0.5f, 2), transform.position.z);
        objectPool.SpawnFromPool(etiqueta, randonPos, Quaternion.identity);
    }
}
