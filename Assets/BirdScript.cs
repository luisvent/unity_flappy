using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public bool alive = true;
    private LogicScript logicManager;

    // Start is called before the first frame update
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && alive)
        {
            rigidbody.velocity = Vector2.up * 8;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.GameOver();

    }
}
