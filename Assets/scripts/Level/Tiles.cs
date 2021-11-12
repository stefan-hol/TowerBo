using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiles : MonoBehaviour
{
    [SerializeField]

    private bool IsBuildabale;
    public bool GetIsBuildabale()
    {
        return IsBuildabale;
    }
}