using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstPipeTrigger : InputCore
{

    public enum SignalType
    {
        Enter,
        Exit,
        Both
    };

    public SignalType SelectedSignalType = SignalType.Both;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter Trigger");
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Player Entered");
            if (GetWantedSignal(SignalType.Enter) || GetWantedSignal(SignalType.Both))
            {
                base.RunScript(1);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit Trigger");
        if (other.transform.CompareTag("Player"))
        {
            Debug.Log("Player left");
            if (GetWantedSignal(SignalType.Enter) || GetWantedSignal(SignalType.Both))
            {
                base.RunScript(2);
            }
        }
    }

    private bool GetWantedSignal(SignalType wantedSignal)
    {
        if (SelectedSignalType == wantedSignal)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
