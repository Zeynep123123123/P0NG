using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody2D rigidbody2dvar;

    // Start is called before the first frame update
    void Start()
    {
        //STARTTT
        //START OF THE EXECUTION
        rigidbody2dvar = GetComponent<Rigidbody2D>();
        print("hello from start");

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody2dvar.velocity = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rigidbody2dvar.velocity = Vector2.down;
        }
        else
        {
            rigidbody2dvar.velocity = Vector2.zero;
        }
    }
    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }


    







}
