using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour 
{

    private void Update()
    {
        
        if(transform.position.y< -13.50)
        {
            
            Die();
        }       
    }

    void Die()
    {
      
        gameObject.SetActive(false);
    }

}


