using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour
{
    private LevensComponent _healthComponent;
    public float snelheid;

    private void Start()
    {
        _healthComponent = GetComponent<LevensComponent>();
    }

    public LevensComponent GetLevensComponent()
    {
        return _healthComponent;
    }
}
