using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] private HeroStackController heroStackController;

    private bool isStack = false;

    private Vector3 direction = Vector3.back;

    private RaycastHit hit;

        
    void Start()
    {
        heroStackController = GameObject.FindObjectOfType<HeroStackController>();
    }



    void FixedUpdate()
    {
        SetCubeRaycast();
    }

    private void SetCubeRaycast()
    {
        if(Physics.BoxCast(transform.position,Vector3.one, direction,  out hit, transform.rotation, 0.2f))
        {
            if (!isStack)
            {
                isStack = true;
                gameObject.tag = "StackedCube";
                heroStackController.IncreaseBlockStack(gameObject);
                SetDirection();
            }

            if (hit.transform.tag == "Obstacle")
            {
                heroStackController.DecreaseBlock(gameObject);
                
            }
        }
    }

    private void SetDirection()
    {
        direction = Vector3.forward;
    }

}
