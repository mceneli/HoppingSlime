using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;
    Rigidbody rb;
    public bool isGrounded;

    public AudioClip au_jump;
    public AudioSource au_source;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        au_source.clip = au_jump;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Terrain" && isGrounded == false)
        {
            isGrounded = true;
        }
    }

    private void Update(){
        if (isGrounded)
        {
            if (swipeControls.SwipeLeft)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(-10, 5, 0), ForceMode.Impulse);
                au_source.Play();
            }

            if (swipeControls.SwipeRight)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(10, 5, 0), ForceMode.Impulse);
                au_source.Play();
            }
            if (swipeControls.SwipeUp)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(0, 5, 10), ForceMode.Impulse);
                au_source.Play();
            }
            if (swipeControls.SwipeDown)
            {
                isGrounded = false;
                rb.AddForce(new Vector3(0, 5, -10), ForceMode.Impulse);
                au_source.Play();
            }
        }
    }
}
