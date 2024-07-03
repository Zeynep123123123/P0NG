using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ball : MonoBehaviour
{

    public Rigidbody2D rigidbody2d;
    public Vector2 lastvelocity;
    public movement leftPlayer;
    public movement rightPlayer;
    public UIController uiController;
    private int leftplayerscore;
    private int rightplayerscore;
    // Start is called before the first frame update
    void Start()
    {
        
        rigidbody2d = GetComponent<Rigidbody2D>();

    }
    public void ballleft()
    {
        
    }
    public void ballright()
    {

    }
    public void sendballinrandomdirection()
    {
        rigidbody2d.velocity = Vector3.zero;
        rigidbody2d.isKinematic = true;
        transform.position = Vector3.zero;
        rigidbody2d.isKinematic = false;
        rigidbody2d.velocity =
            new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized *9f;
        lastvelocity=rigidbody2d.velocity;

        leftPlayer.speed = leftPlayer.defaultSpeed;
        rightPlayer.speed = rightPlayer.defaultSpeed;  
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sendballinrandomdirection();
            //leftPlayer.speed = 2;
            //rightPlayer.speed = 2;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        rigidbody2d.velocity = Vector2.Reflect(lastvelocity, collision.contacts[0].normal);
        lastvelocity = rigidbody2d.velocity * 1.1f;
        leftPlayer.speed *= 1.1f;
        rightPlayer.speed *= 1.1f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(transform.position.x >0 )
        {
            leftplayerscore++;
            uiController.setleftplayerscore(leftplayerscore.ToString());
            Debug.Log("left player scored");
        }
        else
        {
            rightplayerscore++;
            uiController.setrightplayerscore(rightplayerscore.ToString());
            Debug.Log("right player scored");
        }
        sendballinrandomdirection();
    }
}
