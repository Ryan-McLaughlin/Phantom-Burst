using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Has
    public GameObject myObject;


    // Does

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy " + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
