using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Transform cam;
    void Update()
    {
        transform.position = cam.transform.position;
    }
}
