using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    // Has
    // hitpoints - bigger bubbles tend to have more hitpoints, but are worth less
    public float speed = 1;

    void Update()
    {
        Debug.Log("I'm a bubble!");
        transform.position += transform.up * speed * Time.deltaTime;
    }

    public void SetColor(Color c) {        
        transform.GetComponentInChildren<MeshRenderer>().material.color = c;
    }

    public void SetScale(float f) {
        transform.GetComponentInChildren<Transform>().localScale = new Vector3(f, f, f);
        speed += 1 - f;
    }
}
