using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //velocidad desplazamiento
    float speed;
    Vector3 dir;
    CharacterController character;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        speed = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        dir = transform.TransformDirection(Vector3.forward);
        character.SimpleMove(dir * speed);
    }
}
