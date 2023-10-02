using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetectLayer : MonoBehaviour
{
  public string tagToDetect = "Tag1";
  public string tagToDetect2 = "Tag2";
  public string tagToDetect3 = "Tag3";


public GameObject cube1;
public GameObject cube2;
public GameObject cube3;
 

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(tagToDetect))
        {
           
            switch (tagToDetect)
            {
                case "Tag1":
                    Debug.Log("Tag 1 detected. Do something for Tag 1.");
                    break;

                case "Tag2":
                    Debug.Log("Tag 2 detected. Do something for Tag 2.");
                    break;

                case "Tag3":
                    Debug.Log("Tag 3 detected");
                    break;

                default:
                    Debug.Log("Unknown tag detected.");
                    break;
            }
            switch (tagToDetect)
            {
                case "Tag1" + "Tag2":
                    Debug.Log("tag 1 and tag2 detected");
                    cube1.SetActive(true);
                    break;

                case "Tag1" + "Tag3":
                    Debug.Log("Tag1 and Tag3 detected");
                    cube2.SetActive(true);
                    break;

                case "Tag2" + "Tag3":
                    Debug.Log("Tag2 and Tag3 detected");
                    cube3.SetActive(true);
                    break;
            }
        }

    }
}
