using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class colis : MonoBehaviour
{   
    public int pontos = 0;
    public string ProximaFase ="vencer";

    void OnTriggerEnter(Collider collider) 
    {
        if (pontos == 5){ 
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(ProximaFase);
        }
        }
    }
}
