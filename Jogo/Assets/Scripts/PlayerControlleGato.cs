using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlleGato: MonoBehaviour
{
    public Animator playeranimator;
    float Input_x;
    float Input_y;
    public float velocidade = 1.5f;
    bool corrida = false;

    // Start is called before the first frame update
    void Start()
    {
        corrida = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        Input_x = Input.GetAxisRaw("Horizontal");
        Input_y = Input.GetAxisRaw("Vertical");
        corrida = (Input_x != 0 || Input_y != 0);

        if (corrida) 
        {
            var move = new Vector3(Input_x, Input_y, 0).normalized;
            transform.position += move * velocidade * Time.deltaTime;
        }
    }
}
