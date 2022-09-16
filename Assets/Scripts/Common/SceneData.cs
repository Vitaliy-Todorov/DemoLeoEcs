using Assets.Scripts.Infrastructure;
using UnityEngine;

namespace Assets.Scripts.Common
{
    public class SceneData : MonoBehaviour
	{
		public PrefabFactory Factory = new PrefabFactory();
		public Transform SpawnObstaclePosition;

		// public GameHud Hud;
	}
}