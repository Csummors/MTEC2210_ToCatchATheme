using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        float i = Random.value;

        if (i > 0.75f)
        {
            speed = Random.Range(10, 15);
        }
        else
        {
            speed = Random.Range(1, 5);
        }

        //speed = Random.Range(3, 15);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0, 0);
    }
}
