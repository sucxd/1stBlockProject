using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGlow : MonoBehaviour
{
public Material glowingMaterial;

void Start()
{
    glowingMaterial.EnableKeyword("_EMISSION");
}

public void DisableGlowingMat()
{
    glowingMaterial.DisableKeyword("_EMISSION");
    //glowingMaterial.SetColor("_EmissionColor", Color.black);
}
}
