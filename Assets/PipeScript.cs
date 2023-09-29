using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 0.5F;
    // Start is called before the first frame update
    private GameObject bird;
    public float deadLeft = 2.2f;
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        float birdX =  bird.transform.position.x;
        if (transform.position.x < birdX - deadLeft)
             Destroy(gameObject);
    }
}
