using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;
	public GameObject Camera;
	public string mod;

	private void Awake()
	{
		instance = this;
	}

}
