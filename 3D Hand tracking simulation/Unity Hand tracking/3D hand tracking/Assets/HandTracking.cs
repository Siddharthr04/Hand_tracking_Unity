using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpReceive;
    public GameObject[] handPoints;
    public float grabRange = 0.5f;
    private GameObject heldObject;
    private Vector3 startPosition;
    private float maxDistance;
    public Text maxDistanceText;

    void Start()
    {
        startPosition = handPoints[11].transform.localPosition;
    }

    void Update()
    {
        string data = udpReceive.data;

        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        print(data);
        string[] points = data.Split(',');
        print(points[0]);

        //0        1*3      2*3
        //x1,y1,z1,x2,y2,z2,x3,y3,z3

        for (int i = 0; i < 21; i++)
        {
            float x = 7 - float.Parse(points[i * 3]) / 100;
            float y = float.Parse(points[i * 3 + 1]) / 100;
            float z = float.Parse(points[i * 3 + 2]) / 100;

            handPoints[i].transform.localPosition = new Vector3(x, y, z);
        }

        // Calculate the current distance
        float currentDistance = Vector3.Distance(startPosition, handPoints[11].transform.localPosition);

        // Update the maximum distance if the current distance is greater
        if (currentDistance > maxDistance)
        {
            maxDistance = currentDistance;
        }

        // Display the maximum distance in the console
        Debug.Log("Max Distance: " + maxDistance);

        // Display the maximum distance as text on the screen
        maxDistanceText.text = "Max Distance: " + maxDistance.ToString("F2") + " units";

        // Check if hand is within range of an object and not holding anything
        if (heldObject == null)
        {
            Collider[] colliders = Physics.OverlapSphere(handPoints[11].transform.position, grabRange);
            foreach (Collider collider in colliders)
            {
                if (collider.gameObject.tag == "Grabbable")
                {
                    // Pick up the object
                    heldObject = collider.gameObject;
                    Rigidbody rb = heldObject.GetComponent<Rigidbody>();
                    rb.isKinematic = true;
                    heldObject.transform.position = handPoints[11].transform.position;
                    heldObject.transform.rotation = handPoints[11].transform.rotation;
                    break;
                }
            }
        }
        else // If holding an object, move it with the hand
        {
            heldObject.transform.position = handPoints[11].transform.position;
            heldObject.transform.rotation = handPoints[11].transform.rotation;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the hand is holding an object and collided with a "dropzone"
        if (heldObject != null && collision.gameObject.tag == "Dropzone")
        {
            // Drop the object
            Rigidbody rb = heldObject.GetComponent<Rigidbody>();
            rb.isKinematic = false;
            heldObject = null;
        }
    }
}
