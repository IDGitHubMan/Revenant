using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public bool canClimb;
    public bool isClibming;
    public bool canLowCover;
    public bool lowCover;
    public bool canStandCover;
    public bool standCover;
    public bool canGrab;
    public bool canMelee;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D>();
        speed = 7.5f;
        canClimb = false;
        canLowCover = false;
        canStandCover = false;
        canGrab = false;
        canMelee = false;
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3 (x*speed,rb.velocity.y,0);
        if (canClimb){
            float y = Input.GetAxis("Vertical");
            rb.velocity = new Vector3 (x*speed,y*speed,0);
        }
        rb.velocity = new Vector3(rb.velocity.x,rb.velocity.y,0);
    }

    void OnCollisionEnter2D(Collision2D col){
        if (col.collider.name=="expBarrel" || col.collider.name=="barrel"){
            canLowCover = true;
            canMelee = true;
        }

        else if (col.collider.name=="ladder"){
            canClimb = true;
        }
        else if (col.collider.name=="slasher" || col.collider.name=="pistol"||col.collider.name=="shotgun"){
            canGrab = true;
            canMelee = true;
        }
        else if (col.collider.name=="doorway"){}
        else{
            canClimb = false;
        }
    }
}
