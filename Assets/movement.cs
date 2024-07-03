using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    public Rigidbody2D rigidbody2dvar;
    public KeyCode upkey;
    public KeyCode downkey;
    public float speed = 2;
    public float defaultSpeed;


    // Start is called before the first frame update
    void Start()
    {
        //STARTTT
        //START OF THE EXECUTION
        defaultSpeed = speed;
        rigidbody2dvar = GetComponent<Rigidbody2D>();
     //   print("hello from start");

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(upkey) && transform.position.y < 4) 
        {
            rigidbody2dvar.velocity = Vector2.up * speed;
        }
        else if (Input.GetKey(downkey) && transform.position.y >-4)
        {
            rigidbody2dvar.velocity = Vector2.down * speed;
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
