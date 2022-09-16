using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Common
{
    [CreateAssetMenu(menuName = "Config/StaticData", fileName = "StaticData", order = 0)]
    public class StaticData : ScriptableObject
	{
		public GameObject PlayerPrefab;
		public GameObject ObstaclePrefab;
		public Vector3 GlobalGravitation;
		public float SpawnTimer;
		public Vector3 PlayerAddForce;
		public float ClampVelocity = 0.2f;
	}
}