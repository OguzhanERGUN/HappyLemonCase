using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static bool gameState;//false is paused, true is running
	[SerializeField] private Transform blocsParentEmpty;
	[SerializeField] private Transform spawnpointsParentEmpty;
	[SerializeField] private GameObject blueBlock;
	[SerializeField] private GameObject redBlock;
	[SerializeField] private GameObject yellowBlock;
	[SerializeField] private GameObject greenBlock;
	[SerializeField] LevelDataStorage LevelDataStorage;

	private void Awake()
	{
		gameState = false;
		CreateSpawnPoints();
	}

	private void Start()
	{
		CreateBlocs();
	}


	private void CreateSpawnPoints()
	{
		for (int i = 0; i < LevelDataStorage.lineCount; i++)
		{
			Vector3 newPosition = new Vector3(0, 0, i * 2);//
			GameObject newline = Instantiate(LevelDataStorage.spawnPositions, newPosition, Quaternion.identity, spawnpointsParentEmpty);
		}
	}

	private void CreateBlocs()
	{
		foreach (var item in LevelDataStorage.blueBlocsData)
		{
			Transform spawnpos = GameObject.Find(item).transform;
			Instantiate(blueBlock, spawnpos.position, Quaternion.identity, blocsParentEmpty);
		}
		foreach (var item in LevelDataStorage.redBlocsData)
		{
			Transform spawnpos = GameObject.Find(item).transform;
			Instantiate(redBlock, spawnpos.position, Quaternion.identity, blocsParentEmpty);
		}
		foreach (var item in LevelDataStorage.yellowBlocsData)
		{
			Transform spawnpos = GameObject.Find(item).transform;
			Instantiate(yellowBlock, spawnpos.position, Quaternion.identity, blocsParentEmpty);
		}
		foreach (var item in LevelDataStorage.greenBlocsData)
		{
			Transform spawnpos = GameObject.Find(item).transform;
			Instantiate(greenBlock, spawnpos.position, Quaternion.identity, blocsParentEmpty);
		}
	}
}
