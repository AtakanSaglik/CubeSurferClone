using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStackController : MonoBehaviour
{
    public List<GameObject> blocklist = new List<GameObject>();

    private GameObject lastBlockObject;

    
    
    void Start()
    {
        UpdateLastObject();
    }

    public void IncreaseBlockStack(GameObject _gameObject)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position= new Vector3(lastBlockObject.transform.position.x, lastBlockObject.transform.position.y - 2f, lastBlockObject.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blocklist.Add(_gameObject);
        UpdateLastObject();
    }

    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blocklist.Remove(_gameObject);
        UpdateLastObject();
    }


    private void UpdateLastObject()
    {
        lastBlockObject = blocklist[blocklist.Count-1];
    }

}
