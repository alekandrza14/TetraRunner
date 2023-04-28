using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObject : MonoBehaviour
{
    [SerializeField] public float tics;
   
    void Update()
    {
        run r = FindFirstObjectByType<run>();
      if(r.transform.position.z-50>transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
