using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCelindrMod : MonoBehaviour
{
    
    void Update()
    {
        GetComponent<Shape4D>().positionW = FindFirstObjectByType<RaymarchCam>()._wPosition;
    }
}
