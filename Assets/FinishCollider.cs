using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishCollider : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject exitButton;
    public GameObject mainMenuButton;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "StackedCube")
        {
            Time.timeScale = 0;
            restartButton.SetActive(true);
            exitButton.SetActive(true);
            mainMenuButton.SetActive(true);

        }
    }
}
