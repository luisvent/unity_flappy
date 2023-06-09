using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieSpawn : MonoBehaviour
{
    public GameObject Pipes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Pipes, transform);
    }
}
