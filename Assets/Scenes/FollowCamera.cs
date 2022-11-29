using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    
    // Update is called once per frame
    void LateUpdate()
    {
        //we put the camera on the car so it follows it around but if we're right on the car then the player won't see anything, so we go back a bit on the z axis
        transform.position = thingToFollow.transform.position + new Vector3 (0, 0, -10);    
    }
}
