using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlasherScript : MonoBehaviour
{
    enum behavioralState{Idle,Confused,Chasing,Panicking,Possessed}
    public float moveSpeed = 2.0f;
    public bool colliding;
    public float x;
    public GameObject homePoint;
    public GameObject player;
    public Vector2 loc;
    public Vector2 playerLoc;
    public Vector2 selfLoc;
    public BoxCollider2D collider;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        collider = gameObject.GetComponent<BoxCollider2D>();
        if (!collider){
            collider = gameObject.AddComponent<BoxCollider2D>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerLoc = new Vector2(player.GetComponent<Transform>().position.x, player.GetComponent<Transform>().position.z);
        selfLoc = new Vector2(this.GetComponent<Transform>().position.x, this.GetComponent<Transform>().position.z);
    }
}
