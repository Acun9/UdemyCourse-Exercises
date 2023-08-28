using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    RaycastHit hit;

    private void Update()
    {
        // Not: GameObject.FindGameObjectWithTag("MainCamera") = Camera.main

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.transform.position, transform.forward, out hit, Mathf.Infinity)) // transform.forward yukarý veya aþaðý baksan da yalnýzca kameranýn tam karþý hizasýna atýyor.
            {
                if (hit.collider.gameObject.CompareTag("Enemy"))
                {
                    Destroy(hit.collider.gameObject);
                }
            }
        }
    }
}
