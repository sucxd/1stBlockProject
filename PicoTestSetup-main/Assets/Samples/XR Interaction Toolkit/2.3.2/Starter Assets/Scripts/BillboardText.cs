using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BillboardText : MonoBehaviour
{
    private Camera mainCamera;

    private void Start()
    { 
        mainCamera = Camera.main;
    }

    private void Update()
    {
        Vector3 toCamera = mainCamera.transform.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(toCamera);

        transform.rotation = lookRotation * Quaternion.Euler(0, 180, 0);
    }
}
