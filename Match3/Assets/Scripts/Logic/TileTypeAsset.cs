using UnityEngine;

namespace Logic
{
    [CreateAssetMenu(menuName = "Match 3 Engine/Tile Type Asset")]
    public class TileTypeAsset : ScriptableObject
    {
        public int Id;

        public Sprite Sprite;
    }
}