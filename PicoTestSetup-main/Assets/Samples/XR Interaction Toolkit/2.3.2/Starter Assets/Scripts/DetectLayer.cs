using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLayer : MonoBehaviour
{
  public string tagToDetect = "Tag1";

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entered object has the specified tag
        if (other.CompareTag(tagToDetect))
        {
            // Display a message based on the detected tag
            switch (tagToDetect)
            {
                case "Tag1":
                    Debug.Log("Tag 1 detected. Do something for Tag 1.");
                    break;

                case "Tag2":
                    Debug.Log("Tag 2 detected. Do something for Tag 2.");
                    break;

                // Add more cases for other tags as needed

                default:
                    Debug.Log("Unknown tag detected.");
                    break;
            }
        }
    }
}
