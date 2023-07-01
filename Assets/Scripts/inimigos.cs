using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class inimigos : MonoBehaviour
{
    public string ProximaFase = "segunda";

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(ProximaFase);
        }
    }
}
