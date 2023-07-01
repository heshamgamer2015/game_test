using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wsdaControl : MonoBehaviour
{
    public float velocidade = 6.0f;
    public float velocidade2 = 4.0f;
    public float jumpForce = 5.0f;
    private Rigidbody rb;
    private Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();        
    }

   
    void Update()
    {
         if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidade);
            anim.SetBool("avancar", true);
        }
          if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidade2);
            anim.SetBool("avancar", true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            jumpForce += 0.5f;
        }
         if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("avancar", false);
            jumpForce -= 0.5f;
        }
    

         if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * velocidade);
            anim.SetBool("voltar", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("voltar", false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.TransformDirection(Vector3.right * Time.deltaTime * velocidade);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.TransformDirection(Vector3.left * Time.deltaTime * velocidade);
        }
    }
}
