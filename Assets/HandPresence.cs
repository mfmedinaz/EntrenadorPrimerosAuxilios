using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("enteredStart");
        List<InputDevice> devices = new List<InputDevice>();

        InputDevices.GetDevices(devices);
        foreach(var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        UnityEngine.XR.InputDevice headDevice = InputDevices.GetDeviceAtXRNode(XRNode.Head);
        string hmdName = headDevice.name;
        Debug.Log(hmdName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
