using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour { 

    int cubes = 0;
    [SerializeField] Text cubesText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectables"))
           {
            Destroy(other.gameObject);
            cubes++;
            cubesText.text = "Cubes : " + cubes;
        }

        

    }
}
