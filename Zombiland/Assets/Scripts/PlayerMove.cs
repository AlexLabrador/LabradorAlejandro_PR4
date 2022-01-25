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

    InputAction inputAction;
    Vector2 movePlayer;

    // Start is called before the first frame update
    private void Awake()
    {
        inputAction = new InputAction();
        inputAction.Player.Moverse.performed += ctx => movePlayer = ctx.ReadValue<Vector2>();

    }
    void Start()
    {
       
        character = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        speed = 2.5f;
        Correr();
    }

    // Update is called once per frame
    void Update()
    {
        
        Correr();
    }
    void Caminar()
    {
        speed = 2.5f;
        dir = transform.TransformDirection(Vector3.forward);
        character.SimpleMove(dir * speed);

        
    }
    void Strafe()
    {
        speed = 1.2f;
        dir = transform.TransformDirection(Vector3.right);
        character.SimpleMove(dir * speed);

    }
    void Correr()
    {
        animator.SetBool("Run", true);
        speed = 5f;
        dir = transform.TransformDirection(Vector3.forward);
        character.SimpleMove(dir * speed);

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
