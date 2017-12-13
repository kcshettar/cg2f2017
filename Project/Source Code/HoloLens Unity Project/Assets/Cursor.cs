using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour {

    private MeshRenderer meshRenderer;

    public GameObject FocusedObject { get; private set; }

    // Use this for initialization
    void Start()
    {
        // Grab the mesh renderer that's on the same object as this script.
        meshRenderer = this.gameObject.GetComponentInChildren<MeshRenderer>();

    }

    // Update is called once per frame 60 times a second
    void Update()
    {
        // Do a raycast into the world based on the user's
        // head position and orientation.
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;

        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            // If the raycast hit a hologram...
            // Display the cursor mesh.
            meshRenderer.enabled = true;

            // Move thecursor to the point where the raycast hit.
            this.transform.position = hitInfo.point;

            // Rotate the cursor to hug the surface of the hologram.
            this.transform.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);

            // Get the newly focused object
            var newFocusedObject = hitInfo.collider.gameObject;

            // If user is gazing at a new object, reset the old one
            if (FocusedObject != null && newFocusedObject != FocusedObject)
            {
                FocusedObject.SendMessage("OnReset");
            }

            // Store the newly focused object and set the "selected" colour
            // Calling OnSelect function
            FocusedObject = newFocusedObject;
            FocusedObject.SendMessage("OnSelect");
        }
        else
        {
            // If the raycast did not hit a hologram, hide the cursor mesh.
            meshRenderer.enabled = false;

            // Reset the colour of the cube
            if (FocusedObject != null)
            {
                FocusedObject.SendMessage("OnReset");
            }
            FocusedObject = null;

        }
    }
}
