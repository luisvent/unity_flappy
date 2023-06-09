using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesMove : MonoBehaviour
{

    public float moveSpeed = 1;
    private float deadZone = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
