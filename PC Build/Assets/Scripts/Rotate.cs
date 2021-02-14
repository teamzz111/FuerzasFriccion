using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    int velocidade = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.left * velocidade * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.left * velocidade * Time.deltaTime);

        }
    }
}
