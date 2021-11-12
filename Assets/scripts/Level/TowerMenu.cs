using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerMenu : MonoBehaviour
{
    [SerializeField] private RectTransform _menupannel;
    private void Start()
    {
        Show(false);
    }
    public void Show(bool enabeld)
    {
        _menupannel.gameObject.SetActive(enabeld);
    }
}
