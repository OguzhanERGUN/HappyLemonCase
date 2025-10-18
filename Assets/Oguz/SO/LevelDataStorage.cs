using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLevelData", menuName = "Game/Level Data")]
public class LevelDataStorage : ScriptableObject
{
	public int levelstate;
	public GameObject spawnPositions;
	//How many lines contains level 
	public Dictionary<string, int> matrix; 
	public int lineCount;
	//These Lists Contains which position should spawn
	public List<string> redBlocsData = new List<string>();
	public List<string> greenBlocsData = new List<string>();
	public List<string> yellowBlocsData = new List<string>();
	public List<string> blueBlocsData = new List<string>();
}
