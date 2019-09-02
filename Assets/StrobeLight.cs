using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrobeLight : MonoBehaviour
{
    private bool isOn = false;
    private Light light;
    private bool shouldChangeLight = true;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOn && shouldChangeLight)
        {
            shouldChangeLight = false;
            Invoke("TurnOnStrobe", 0.06f);
        }
        else if (shouldChangeLight)
        {
            Invoke("TurnOffStrobe", 0.06f);
        }
    }

    void TurnOnStrobe()
    {
        light.enabled = true;
        isOn = true;
        shouldChangeLight = true;
    }

    void TurnOffStrobe()
    {
        light.enabled = false;
        isOn = false;
        shouldChangeLight = true;
    }
}
