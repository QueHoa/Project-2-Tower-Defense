using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Waypoints : MonoBehaviour {

	public static Transform[] points;

	void Awake ()
	{
		points = new Transform[transform.childCount];
		for (int i = 0; i < points.Length; i++)
		{
			points[i] = transform.GetChild(i);
		}
	}

}
