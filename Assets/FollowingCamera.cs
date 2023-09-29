using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public GameObject Player;
    public float followspeed;
    public float distance;
    void Start()
    {
    }

    void Update()
    {

        Vector3 targetPosition = new Vector3(Player.transform.position.x + distance, transform.position.y,transform.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * followspeed);
    }
}
