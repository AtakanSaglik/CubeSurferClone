using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMagnetism : MonoBehaviour
{
    private GameObject myPlayer;
    private Vector3 myPlayerY;
    private float distanceObjects;
    private float smoothness;
    public static bool magnetActive = false;
    
    
    void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("StackedCube");
        
        smoothness = 4f;
    }

    void Update()
    {
        if (magnetActive)
        {
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        myPlayerY = new Vector3(myPlayer.transform.position.x, 2f, myPlayer.transform.position.z);
        distanceObjects = myPlayer.transform.position.z - transform.position.z;
        transform.position = Vector3.Lerp(transform.position, myPlayerY, smoothness * Time.deltaTime);
        
    }

}
