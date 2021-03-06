﻿using UnityEngine;
using Yarn;

/// <summary>
/// This script will get and set values in GlobalState
/// </summary>
public class CustomVariableStorage : Yarn.Unity.VariableStorageBehaviour
{
    [SerializeField]
    private GlobalState globalState = default; 

    public override Value GetValue(string variableName)
    {
        switch (variableName)
        {
            case "$communityApproval":
                return new Yarn.Value(globalState.communityApproval);
            case "$communityReached":
                return new Yarn.Value(globalState.communityReached);
            case "$money":
                return new Yarn.Value(globalState.money);
            case "$NetScore":
                return new Yarn.Value(globalState.NetScore);
            case "$leraScore":
                return new Yarn.Value(globalState.leraScore);
            case "$luisScore":
                return new Yarn.Value(globalState.luisScore);
            case "$buckScore":
                return new Yarn.Value(globalState.buckScore);
            case "$carlaScore":
                return new Yarn.Value(globalState.carlaScore);
            default:
                Debug.LogError("Yarn variable storage tried to access invalid variable " + variableName + ".");
                break;
        }
        return new Yarn.Value();
    }

    public override void ResetToDefaults()
    {
        /*
        for (int i = 0; i < globalState.GetType().GetProperties().Length; i++) //for each property in global variables, set to default
        {
            globalState.GetType().GetProperties()[i].SetValue(globalState, null, null);
        }*/
    }

    public override void SetValue(string variableName, Value value)
    {
        switch (variableName)
        {
            case "$communityApproval":
                globalState.communityApproval = value.AsNumber;
                break;
            case "$communityReached":
                globalState.communityReached = value.AsNumber;
                break;
            case "$money":
                globalState.money = (int)value.AsNumber;
                break;
            default:
                Debug.LogError("Yarn variable storage tried to access invalid variable " + variableName + ".");
                break;
        }
    }

}
