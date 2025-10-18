using UnityEngine;

public class SpawnPointController : MonoBehaviour
{
	[SerializeField]
	private GameObject[] points;
	private void OnEnable()
	{

		foreach (GameObject p in points)
		{
			p.name = (transform.position.z / 2).ToString() + p.name.Substring(1, 2);// Update all spawn location names as a matrix

		}
	}
}
