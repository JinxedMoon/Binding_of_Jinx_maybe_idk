using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f;
    public float shiftspeed = 10.0f;
    //public float jumpForce = 10f;
    //private bool isJumping = false;
    //private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, movevertical);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += movement * shiftspeed * Time.deltaTime;
        }
        else
        {
            transform.position += movement * speed * Time.deltaTime;
        }
        //if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
    //    {
    //        isJumping = true;
    //        rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
    //    }
    //}
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("GameController"))
    //    {
    //        isJumping = false;
    //    }
    }
}