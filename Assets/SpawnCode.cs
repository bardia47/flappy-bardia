using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCode : MonoBehaviour
{
    public GameObject pipes;
    public GameObject bird;
    public int cameraLen;
    public float rate ;
    public float decRate ;
    public float decSpeedRate ;
    public float lowestRate;

    public float heightOffset;

    
    private float timer = 0;
    private float lowestPoint;
    private float highestPoint;

    private LogicScript scoreScript;
    public float counterMod = 5;
    public float incCounterMod = 2;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipes, transform.position, transform.rotation);
        lowestPoint  = transform.position.y - heightOffset;
        highestPoint = transform.position.y + heightOffset;
        scoreScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < rate)
            timer += Time.deltaTime;
        else
        {
            int score = scoreScript.playerScore;
                if (score > 0 && score % counterMod == 0 && rate > lowestRate)
                {
                    counterMod += incCounterMod;
                    rate -= decRate;
                    decRate *= decSpeedRate;
                }
                timer = 0;
                Instantiate(pipes, new Vector2(bird.transform.position.x + cameraLen, Random.Range(lowestPoint, highestPoint))
                    , transform.rotation);
            }
        

    }
}
