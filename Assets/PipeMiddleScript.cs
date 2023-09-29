using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{

    private LogicScript score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.addScore();

    }
}
