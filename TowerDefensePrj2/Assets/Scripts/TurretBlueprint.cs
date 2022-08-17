using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class TurretBlueprint {

	public GameObject prefab;
	public int cost;

	public GameObject upgradedPrefab;
	public int upgradeCost;

	public int GetSellAmount ()
	{
		return cost / 2;
	}

}
