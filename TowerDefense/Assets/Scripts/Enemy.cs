﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	public float startSpeed = 10f;

	[HideInInspector]
	public float speed;

	public float startHealth = 100;
	private float health;

	public int worth = 50;

	public GameObject deathEffect;

	[Header("Unity Stuff")]
	public Image healthBar;

	private bool isDead = false;

	void Start ()
	{
		speed = startSpeed;
		health = startHealth;
	}

	public void TakeDamage (float amount)//khi gây damage cho Enemy 
	{
		health -= amount;

		healthBar.fillAmount = health/ startHealth;//thanh hiển thị máu

		if (health <= 0 && !isDead)
		{
			Die();
		}
	}

	public void Slow (float pct)//hàm làm chậm Enemy
	{
		speed = startSpeed * (1f - pct);
	}

	void Die ()//khi Enemy chết
	{
		isDead = true;

		PlayerStats.Money += worth;

		GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(effect, 5f);

		WaveSpawner.EnemiesAlive--;

		Destroy(gameObject);
	}

}
