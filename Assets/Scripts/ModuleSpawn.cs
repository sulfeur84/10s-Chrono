using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModuleSpawn : MonoBehaviour
{
    public List<GameObject> Modules; 
    void Start()
    {
        int i = Random.Range(0, Modules.Count);
        Instantiate(Modules[i], transform.position, transform.rotation);
    }
}
