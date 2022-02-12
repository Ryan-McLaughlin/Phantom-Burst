using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGenerator : MonoBehaviour
{
    public GameObject bubblePrefab;
        

    void Update() {
        // left mouse
        if(Input.GetMouseButtonDown(0)) {
            GenerateBubble();
        }

        // middle mouse
        if(Input.GetMouseButtonDown(2)) {
            Debug.Log("mouse 2");
        }

        // right mouse
        if(Input.GetMouseButtonDown(1)) {
            Debug.Log("mouse 1");
        }
    }

    void GenerateBubble() {
        // bubble location
        float x = Random.Range(-3.5f, 3.5f);
        int y = -4;
        float z = Random.Range(-1.25f, 0);
        Vector3 location = new Vector3(x, y, z);
                
        // generate bubble
        GameObject instance = Instantiate(bubblePrefab, location, Quaternion.identity);
        // make bubble a child item of BubbleGenerator in Hiearchy
        instance.transform.SetParent(this.transform);

        // bubble color
        Color color = new Color();
        color.r = Random.Range(0, 255) / 255f;
        color.b = Random.Range(0, 145) / 255f;
        color.g = Random.Range(150, 255) / 255f;
        instance.GetComponent<Bubble>().SetColor(color);
        
        // bubble scale
        float scale = Random.Range(0.15f, 1);
        instance.GetComponent<Bubble>().SetScale(scale);


    }
}
