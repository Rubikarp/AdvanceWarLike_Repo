using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGrid : MonoBehaviour
{    
    public float cellSize;
    public Vector2 gridOffSet;
    [Space(10)]
    public Vector2Int gridSize;
    public Tile[,] tiles;

    public GameObject tileTemplate;
    public bool showDebug;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public Vector3 TilePos(Vector2Int posInGrid)
    {
        //Start at the bottom left border
        Vector3 result = new Vector3(gridOffSet.x - (gridSize.x * 0.5f * cellSize), gridOffSet.y - (gridSize.y * 0.5f * cellSize), 0);

        result += new Vector3(posInGrid.x, posInGrid.y, 0) * cellSize;

        return result;
    }

    private void OnDrawGizmos()
    {
        if (showDebug)
        {
            Vector3 startPos = new Vector3(gridOffSet.x - (gridSize.x * 0.5f * cellSize), gridOffSet.y - (gridSize.y * 0.5f * cellSize), 0);

            float halfCell = cellSize * 0.5f;

            #region center point
            /*
            Gizmos.color = Color.green;
            for (int x = 0; x < gridSize.x; x++)
            {
                for (int y = 0; y < gridSize.y; y++)
                {
                    Gizmos.DrawWireSphere(startPos + new Vector3(x * cellSize, y * cellSize, 0), cellSize * 0.5f * 0.8f);
                }
            }
            */
            #endregion

            //Grid decals
            startPos += new Vector3(-halfCell, -halfCell, 0);

            Gizmos.color = Color.red;
            for (int x = 0; x <= gridSize.x; x++)
            {
                Debug.DrawRay(startPos + new Vector3(cellSize * x, 0, 0), Vector3.up * gridSize.y * cellSize, Color.red);
            }
            for (int y = 0; y <= gridSize.y; y++)
            {
                Debug.DrawRay(startPos + new Vector3(0, cellSize * y, 0), Vector3.right * gridSize.x * cellSize, Color.red);
            }
        }
    }
}
