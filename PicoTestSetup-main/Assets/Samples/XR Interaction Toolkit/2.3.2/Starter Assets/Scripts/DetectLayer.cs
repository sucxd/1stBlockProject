using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLayer : MonoBehaviour
{
    private void OnTrigger(Collider other)
    {
        if (other.gameObject.layer != LayerMask.NameToLayer("Default"))
        {
            string layerName= LayerMask.LayerToName(other.gameObject.layer);

            switch ( (layerName))
            {
              case "Layer1":
                Debug.Log("Layer 1 detected");
                break;

              case "Layer2":
                Debug.Log("layer 2 detected.");
                break;

              default:
                Debug.Log("Uknown layer");
                break;
            }
        }
    }
}
