using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shootablebox : MonoBehaviour
{
    //boxes' health
    public int currentHealth = 1;

    public void Damage(int damageAmount)
    {
        //health counting
        currentHealth -= damageAmount;

        //Check if health more than 0
        if (currentHealth <= 0)
        {
            //if health < 0, delete the box
            gameObject.SetActive(false);
        }
    }
}
