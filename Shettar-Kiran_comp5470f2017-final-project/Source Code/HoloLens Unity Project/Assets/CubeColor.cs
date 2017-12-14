using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour {

    // Use this for initialization
    private Color originalColour;

    // Cube original position
    private Vector3 originalVector;

    // Use this for initialization
    void Start()
    {
        var newColour = new Color(Random.Range((float)0.0, (float)1.0), Random.Range((float)0.0, (float)1.0), Random.Range((float)0.0, (float)1.0));
        this.GetComponent<Renderer>().material.color = newColour;

        // Store original color
        originalColour = newColour;
        originalVector = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Object being gazed
    // Change the color
    void OnSelect()
    {
        // Get the object gazed at, then store original colour
        var cube = this.GetComponent<Renderer>();

        // Change to highlight colour
        cube.material.color = Color.clear;
    }

    // Object not being gazed
    // Change the color back to original
    void OnReset()
    {
        // Get the object gazed at, then store original colour
        var cube = this.GetComponent<Renderer>();

        // Change to highlight colour
        cube.material.color = originalColour;
    }

    // Set the transform to original vector
    public void OnResetBlock()
    {
        this.transform.position = originalVector;
    }
}
