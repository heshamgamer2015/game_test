using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);

            // Aumenta 1 ponto na variável 'pontos' em colis.cs
            colis colisScript = FindObjectOfType<colis>();
            if (colisScript != null)
            {
                colisScript.pontos++;
            }
        }
    }
}
