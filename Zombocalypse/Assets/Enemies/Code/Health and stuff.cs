using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;

public class Healthandstuff : MonoBehaviour
{
    public int startingHealth;
    private int currentHealth;
    private Animator animator;
    public bool isDead = false;
    //public Component strength;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startingHealth;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            isDead = true;
            animator.SetBool("IsDead", true);
        }
    }
}
