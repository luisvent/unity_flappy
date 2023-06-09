using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawn : MonoBehaviour
{
    public GameObject Pipes;
    public float spawnRate = 5;
    public float yOffset = 3;
    private float timer  = 0;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - yOffset;
        float highestPoint = transform.position.y + yOffset;

        Instantiate(Pipes, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
