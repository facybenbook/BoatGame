using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacterMovementTest : MonoBehaviour {

    Rigidbody rb;
    public float speed = 1.0f;
    void Start () {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
  void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = transform.right * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = -transform.right * speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector3(0, 0, 1) * speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector3(0, 0, -1) * speed;
        }
    }
}

//seems to be a worldspace script, so left/right forward/baack movement is occurring along z and x lines - not helpful if the character gets turned around.
//I think transform and new vector are worldspace commands - need to translate to local