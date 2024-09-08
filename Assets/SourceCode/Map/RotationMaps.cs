using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMaps : MonoBehaviour
{
    [SerializeField] float speedRotation = 0.05f;
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up, speedRotation);
    }
}
