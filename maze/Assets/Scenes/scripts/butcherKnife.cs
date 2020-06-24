using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class butcherKnife : MonoBehaviour
{
	float moveSpeed = 10;

	Rigidbody2D rb;

	Player target;
	Vector2 moveDirection;
	public Text loseText;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindObjectOfType<Player>();
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Destroy(other.gameObject);
			loseText.text = "The butcher killed you!\n Game will restart in 10 sek.";
			StartCoroutine("stopGameToRestart");

		}
		if (other.tag == "wall")
		{
			Destroy(this.gameObject);
		}
	}
	IEnumerator stopGameToRestart()
	{
		Time.timeScale = 0;
		float pauseTime = Time.realtimeSinceStartup + 10;
		while (Time.realtimeSinceStartup < pauseTime)
			yield return 0;
		Time.timeScale = 1;
		SceneManager.LoadScene("SampleScene");
	}
}
