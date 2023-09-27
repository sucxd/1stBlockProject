using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverInteract : MonoBehaviour
{
    public GameObject TextToDisable;
   void start()
   {
        ;
   }
    public void textPopUp()
    {
        if(gameObject.Find{'TextBox'})
        {
            TextToDisable.SetActive(false);
        }else
        {
            TextToDisable.SetActive(true);
        }
        
    }
}
