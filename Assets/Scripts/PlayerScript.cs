using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public float jump;
    Rigidbody2D rb;
    public bool canClimb;
    public bool lowCover;
    public bool standCover;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        speed = 7.5f;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3 (x*speed,rb.velocity.y,0);
    }
}
