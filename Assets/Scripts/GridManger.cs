using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManger : MonoBehaviour
{


    [SerializeField] private int _l�ngde, _h�jde;

    [SerializeField] private Tile _tilePrefab;



    private void Start()
    {


        GenerateGrid();


    }



    void GenerateGrid()
    {
        for (int x = 0; x < _l�ngde; x++)
        {
            for (int y = 0; y < _l�ngde; y++)
            {

                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"tile {x} {y}";
            }



        }


    }



}
