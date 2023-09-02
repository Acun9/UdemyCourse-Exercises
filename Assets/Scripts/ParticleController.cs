using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject particleEffect;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(particleEffect, transform.position, Camera.main.transform.rotation);
        }
    }
}
