using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 1000f)] float rotationSpeed;
    [SerializeField] bool clockwise;

    private void Update()
    {
        transform.Rotate(0, 0, (clockwise ? -1 : 1) * rotationSpeed * Time.deltaTime, Space.World);
    }
}
