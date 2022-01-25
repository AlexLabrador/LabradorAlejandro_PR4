using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //velocidad desplazamiento
    float speed;
    Vector3 dir;
    float strafe;
    //characterController
    CharacterController character;
    //Animator
    Animator animator;

    InputActions inputAction;
    Vector2 movePlayer;
    float strafeL;
    float strafeR;
    bool corriendo;

    // Start is called before the first frame update
    private void Awake()
    {
      
        inputAction = new InputActions();
        //joystick izquierdo
        inputAction.Player.Moverse.performed += ctx => movePlayer = ctx.ReadValue<Vector2>();
        inputAction.Player.Moverse.canceled += ctx => movePlayer = Vector2.zero;
        //despl izq
        inputAction.Player.DespLateralizq.performed += ctx => strafeL = ctx.ReadValue<float>();
        inputAction.Player.DespLateralizq.canceled += ctx => strafeL = 0f;
        //correr
        inputAction.Player.Correr.started += _ => StartCorrer();
        inputAction.Player.Correr.canceled += _ => StopCorrer();
    }
    void Start()
    {
       
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        //speed = 2.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Caminar();
        if (corriendo)
        {
            character.SimpleMove(dir * speed);
            
        }
        else
        {
            Caminar();
        }

    }
    void Caminar()
    {
        if (movePlayer.y < 0)
        {
            speed = 0.6f;
        }
        else
        {
            speed = 2.5f;
        }

        dir = transform.TransformDirection(Vector3.forward);
        character.SimpleMove(dir * speed * movePlayer.y);
        animator.SetFloat("caminar", movePlayer.y);


    }
    void Strafe()
    {
        speed = 1.2f;
        dir = transform.TransformDirection(Vector3.right);
        character.SimpleMove(dir * speed);

    }
    void StartCorrer()
    {
        animator.SetBool("Run", true);
        speed = 5f;
        dir = transform.TransformDirection(Vector3.forward);
        character.SimpleMove(dir * speed);
        corriendo = true;

    }
    void StopCorrer()
    {
        animator.SetBool("Run", false);
        speed = 2.5f;
        corriendo = false;

    }
    void Girar()
    {

    }


    private void OnEnable()
    {
        inputAction.Enable();
    }
    private void OnDisable()
    {
        inputAction.Disable();
    }
}
