using Enum;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Entity
{
    [CreateAssetMenu(fileName = "MapTile",menuName = "Tiles/MapTile")]
    public class MapTile : Tile
    {
        public GridType gridType;
        public int moveCost;

        public override void GetTileData(Vector3Int location, ITilemap tileMap, ref TileData tileData)
        {
            tileData.sprite = sprite;
            tileData.colliderType = colliderType;
            tileData.flags = flags;
            tileData.transform = transform;
            tileData.gameObject = gameObject;
        }
    }
}