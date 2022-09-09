using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private bloon myVariable;

    //public Transform otherObject;

   
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
}