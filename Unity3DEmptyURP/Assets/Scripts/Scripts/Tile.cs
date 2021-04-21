using UnityEngine;

public enum TileType
{
    Ground,
    Water
}

[System.Serializable]
public struct Tile
{
    public Vector2Int pos;
    public TileType type;

    //Constructor
    public Tile(Vector2Int pos)
    {
        this.pos = pos;
        this.type = TileType.Ground;
    }
    public Tile(Vector2Int pos, TileType type)
    {
        this.pos = pos;
        this.type = type;
    }
}