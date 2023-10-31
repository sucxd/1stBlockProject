using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.SqlServer.Server;
using UnityEngine;

public class DetectMultipleTags : MonoBehaviour
{
    public string tagToDetect1 = "Tag1";
    public string tagToDetect2 = "Tag2";
    public string tagToDetect3 = "Tag3";

    public GameObject cube1;
    public GameObject cube2;
    public GameObject cube3;

    bool tag1Inside = false;
    bool tag2Inside = false;
    bool tag3Inside = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(tagToDetect1))
        {
            tag1Inside = true;
        }
         if(other.CompareTag(tagToDetect2))
        {
            tag2Inside = true;
        }
         if(other.CompareTag(tagToDetect3))
        {
            tag3Inside = true;
        }

        CheckTagsAndDoAction();
    }

        private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag(tagToDetect1))
        {
            tag1Inside = false;
            cube1.SetActive(false);
        }
         if(other.CompareTag(tagToDetect2))
        {
            tag2Inside = false;
            cube2.SetActive(false);
        }
         if(other.CompareTag(tagToDetect3))
        {
            tag3Inside = false;
            cube3.SetActive(false);
        }

        CheckTagsAndDoAction();
    }

    private void CheckTagsAndDoAction()
    {

        if(tag1Inside && tag2Inside && tag3Inside)
        {
            cube1.SetActive(true);
            cube2.SetActive(true);
            cube3.SetActive(true);
        }


        // if(tag1Inside && tag2Inside)
        // {
        //     cube1.SetActive(true);

        //     cube2.SetActive(false);
        //     cube3.SetActive(false);
        // }
        // if(tag1Inside && tag3Inside)
        // {
        //     cube2.SetActive(true);

        //     cube3.SetActive(false);
        //     cube1.SetActive(false);
        // }
        // if(tag2Inside && tag3Inside)
        // {
        //     cube3.SetActive(true);

        //     cube1.SetActive(false);
        //     cube2.SetActive(false);
        // }

    }
}
