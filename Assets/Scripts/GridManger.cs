using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridManger : MonoBehaviour
{


    [SerializeField] private int _længde, _højde;

    [SerializeField] private Tile _tilePrefab;



    private void Start()
    {


        GenerateGrid();


    }



    void GenerateGrid()
    {
        for (int x = 0; x < _længde; x++)
        {
            for (int y = 0; y < _længde; y++)
            {

                var spawnedTile = Instantiate(_tilePrefab, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"tile {x} {y}";
            }



        }


    }



}
