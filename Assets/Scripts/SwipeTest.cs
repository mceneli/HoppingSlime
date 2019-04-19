using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    Rigidbody rb;
    public bool isGrounded;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Terrain" && isGrounded == false)
        {
            isGrounded = true;
        }
    }

    private void Update(){
        if (isGrounded){
            if (swipeControls.SwipeLeft)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(-7, 5, 0), ForceMode.Impulse);
            }

            if (swipeControls.SwipeRight)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(7, 5, 0), ForceMode.Impulse);
            }
            if (swipeControls.SwipeUp)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(0, 5, 7), ForceMode.Impulse);
            }
            if (swipeControls.SwipeDown)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(0, 5, -7), ForceMode.Impulse);
            }
        }
    }
}
