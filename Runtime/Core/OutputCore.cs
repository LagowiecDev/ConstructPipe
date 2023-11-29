using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutputCore : MonoBehaviour
{
    public virtual void onOutput(int _channel = 0)
    {
        Debug.Log("onOutput");
    }
}
