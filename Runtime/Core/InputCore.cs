using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCore : MonoBehaviour
{
    public OutputCore[] onInput;

    public void RunScript(int _value = 0)
    {
        foreach(OutputCore outputCore in onInput)
        {
            outputCore.onOutput(_value);
        }
    }

}
