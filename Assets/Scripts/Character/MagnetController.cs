using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetController : MonoBehaviour
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
            StarMagnetism.magnetActive = true;
            Destroy(gameObject);
            StartCoroutine(FiveSecondsWait());
            
        }
    }

    IEnumerator FiveSecondsWait()
    {
        Debug.Log("basladi");
        yield return new WaitForSeconds(2f);
        Debug.Log("bitti");
        StarMagnetism.magnetActive = false;
        
    }
}
