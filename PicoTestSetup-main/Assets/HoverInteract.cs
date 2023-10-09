using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HoverInteract : MonoBehaviour
{
    public GameObject TextToDisable;
   void Start()
   {
        if(1<2)
        {
            Debug.LogFormat("Its WOking");
        }
   }
    public void textPopUp()
    {
        if(TextToDisable.activeSelf == true)
        {
            TextToDisable.SetActive(false);
        }else
        {
            TextToDisable.SetActive(true);
        }
        
    }
    public SelectEnterEvent selectEntered { get; set; }
 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverInteract : MonoBehaviour
{
    public GameObject TextToDisable;
   void Start()
   {
        if(1<2)
        {
            Debug.LogFormat("Its WOking");
        }
   }
    public void textPopUp()
    {
        if(TextToDisable.activeSelf == true)
        {
            TextToDisable.SetActive(false);
        }else
        {
            TextToDisable.SetActive(true);
        }
        
    }
}
