using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] float timeToWait = 5f;
    MeshRenderer meshRenderer;
    Rigidbody rb;
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
