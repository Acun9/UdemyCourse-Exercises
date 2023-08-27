using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private bool _isOn;
    public GameObject flashlight;

    private void Start()
    {
        _isOn = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_isOn)
            {
                flashlight.GetComponent<Light>().enabled = false;
                _isOn = false;
            }
            else
            {
                flashlight.GetComponent<Light>().enabled = true;
                _isOn = true;
            }
        }
    }
}
