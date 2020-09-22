using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    int[,] levelMap =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 };
    public float tileGap;
    public Vector2 startPosition;

    public GameObject loadPrefab;
    public GameObject generateTile;
    void Start()
    {
        tileGap = 0.4f;
        startPosition = new Vector2(6, 6);
        levelGeneration();

        /*
        for (int i = 0; i < 14; i++)
        {
            //Debug.Log("levelMap["+ i + ", 0]" + levelMap[i, 0]);
            //Debug.Log(levelMap[14, i]);
        }
        */
        
    } 
    void Update()
    {
        
    }

    public void levelGeneration()
    {
        
        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                loadPrefab = Resources.Load("tile_" + levelMap[i, j].ToString()) as GameObject;
                 generateTile = Instantiate(loadPrefab, Vector3.zero, Quaternion.identity);
                 generateTile.transform.position = new Vector3(startPosition.x + (tileGap * j), startPosition.y - (tileGap * (i-1)), 0);
                //Debug.Log("levelMap[" + i + "," + j + " ]" + levelMap[i, j]);
            }
        }
        
        
        for (int i = 14; i >= 0; i--)
        {
            for (int j = 13; j >= 0; j--)
            {
                    loadPrefab = Resources.Load("tile_" + levelMap[i, j].ToString()) as GameObject;
                    generateTile = Instantiate(loadPrefab, Vector3.zero, Quaternion.identity);
                    generateTile.transform.position = new Vector3(startPosition.x + (tileGap * (27 - j)), startPosition.y - (tileGap * (i-1)), 0);
            }
        }

        for (int i = 0; i < 15; i++)
        {
            for (int j = 0; j < 14; j++)
            {
                loadPrefab = Resources.Load("tile_" + levelMap[i, j].ToString()) as GameObject;
                generateTile = Instantiate(loadPrefab, Vector3.zero, Quaternion.identity);
                generateTile.transform.position = new Vector3(startPosition.x + (tileGap * j), startPosition.y - (tileGap * (27 - i)), 0);
            }
        }

        for (int i = 14; i >= 0; i--)
        {
            for (int j = 13; j >= 0; j--)
            {
                loadPrefab = Resources.Load("tile_" + levelMap[i, j].ToString()) as GameObject;
                generateTile = Instantiate(loadPrefab, Vector3.zero, Quaternion.identity);
                generateTile.transform.position = new Vector3(startPosition.x + (tileGap * (27 - j)), startPosition.y - (tileGap * (27 - i)), 0);
            }
        }
    }
}
