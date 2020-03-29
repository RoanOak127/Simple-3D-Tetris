using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBlock : MonoBehaviour
{
    public float speed;
    private Rigidbody block;
    // Start is called before the first frame update
    void Start()
    {
        block = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //z aw
        Vector3 pos = transform.position;

        if (Input.GetKeyDown("w"))
        {
            Debug.Log("Pressed W");
            pos.x = (transform.position.x - 1.0f);
        }
        if (Input.GetKey("s"))
        {
            pos.x = (transform.position.x + 1.0f);
        }
        if (Input.GetKey("d"))
        {
            pos.z = (transform.position.x + 1.0f);
        }
        if (Input.GetKey("a"))
        {
            pos.z = (transform.position.x - 1.0f);
        }
         block.AddForce(pos * speed);
    }
}
