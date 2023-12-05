using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sit : MonoBehaviour
{
    public bool isTest;
    public Transform movePoint;
    public Transform player;

    public void movePlayer()
    {
        Vector3 vet = movePoint.position;
        player.position = new Vector3(vet.x,player.position.y,vet.z);
    }
}
