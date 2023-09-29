using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigid;
    public float jumpVal;

    private LogicScript logic;

    private GameObject lastCollide;
    public AudioSource wing;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began && birdRigid.velocity.y < 0) { 
        birdRigid.velocity = Vector2.up * jumpVal;
            wing.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Wall") {
            logic.changeLive(3);
        }
        else 
            if (lastCollide==null || collision.gameObject== lastCollide) {
            lastCollide = collision.gameObject;
            logic.changeLive(1);
        }
            
        
    }

  
}
