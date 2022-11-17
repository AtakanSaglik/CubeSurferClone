using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarCollector : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "StackedCube")
        {
            ScoreText.Score+=10;
            Destroy(gameObject);
        }
    }
}
