using UnityEngine;
public class TagDetector : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entered object has a tag assigned
        if (other.CompareTag("Untagged"))
        {
            Debug.Log("Object with an untagged or unknown tag detected.");
        }
        else
        {
            // Get the tag of the entered object and display it
            string detectedTag = other.tag;
            Debug.Log("Object with tag: " + detectedTag + " detected.");
        }
    }
}