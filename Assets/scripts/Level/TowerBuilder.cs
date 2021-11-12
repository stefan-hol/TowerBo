using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private TowerMenu _buildUI;
    [SerializeField] private LayerMask _layer;
    private Tiles _selectedTile = null;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _selectedTile == null)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, _layer))
            {
                Tiles tile = hit.transform.GetComponent<Tiles>();
                _selectedTile = tile;
                _buildUI.Show(true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _selectedTile != null)
        {
            _buildUI.Show(false);
        }
    }
}
