using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGenerator : MonoBehaviour
{
    public GameObject bubblePrefab;

    public GameObject myObject;
    int count = 0;

    void Start() {
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy " + myObject.activeInHierarchy);
    }

    // Update is called once per frame
    void Update() {
        count++;
        int m = count % 1000;
        if(m == 0) {
            Debug.Log(count.ToString());
        }
    }
}
