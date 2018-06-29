using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {
    public int StartingHealth;
    public int CurrentHealth;
    public int AttackDamage;
    public GameObject drop;
    public GameObject effect;




	// Use this for initialization
	void Start () {
        CurrentHealth = StartingHealth;
	}
	
    public void UpdateHealth (int amount) {
        CurrentHealth -= amount;
        if (CurrentHealth <= 0)
        {
            Die();
        }

		
	}

    void Die()
    {
        gameObject.SetActive(false);
        GameObject.Instantiate(drop, transform.position, Quaternion.identity);


    }
}
   