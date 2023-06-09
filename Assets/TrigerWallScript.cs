using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerWallScript : MonoBehaviour
{
    private LogicScript logicManager;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicManager.AddScore();
    }
}
