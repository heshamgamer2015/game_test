using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidade = 6.0f;
    public float velocidade2 = 4.0f;
    public float rotationSpeed = 300.0f;
    public float jumpForce = 5.0f;
    public int score = 0;
    private Animator anim;
    private bool podePular = true;
    private Rigidbody rb;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            jumpForce += 0.5f;
        }

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
            transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed);
        }

        if (Input.GetKey(KeyCode.Space) && podePular)
        {
            anim.SetBool("pular", true);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            podePular = false;
            Invoke(nameof(PermitirPularNovamente), 1f);
            
        }
         if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("pular", false);
        }
    }

    private void PermitirPularNovamente()
    {
        podePular = true;
    }
}
