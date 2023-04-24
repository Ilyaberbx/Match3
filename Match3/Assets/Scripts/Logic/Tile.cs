using UnityEngine;
using UnityEngine.UI;

namespace Logic
{
	public class Tile : MonoBehaviour
	{
		public int x;
		public int y;

		public Image icon;

		public Button button;

		private TileTypeAsset _type;

		public TileTypeAsset Type
		{
			get => _type;

			set
			{
				if (_type == value) return;

				_type = value;

				icon.sprite = _type.Sprite;
			}
		}

		public TileData Data => new TileData(x, y, _type.Id);
	}
}
