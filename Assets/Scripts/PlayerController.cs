using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private bloon myVariable;

    //public Transform otherObject;

    public AudioClip coinClip;
    public AudioClip hazardClip;
    

    public GameManager gm;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start");

        //Debug.Log(transform.position.x);

        //speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");

        float xMove = Input.GetAxis("Horizontal");

        //Debug.Log("xMove" + xMove);

        transform.Translate(xMove * speed * Time.deltaTime , 0, 0);

        //transform.position= new Vector3(0, 0, 0);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
      //  Debug.Log("Collided");
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hazard") 
        {
            gm.PlaySound(hazardClip);

            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Coin")
        {
            gm.IncrementScore(1);

            gm.PlaySound(coinClip);

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Theme")
        {

            Debug.Log("Switch Theme");
           
        }

        //Debug.Log("Triggered");
    }
}