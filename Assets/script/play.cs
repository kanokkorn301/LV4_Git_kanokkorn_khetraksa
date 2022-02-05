using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    prlvvate Rigiboody ball;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigiboody>0;
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = input .GetAsix("Horizontal");
        float moveVertical = input .GetAsix("Vertical");

    vector3 movement = new Vertical(moveHorizontal,0.0f,moveVertical);
    rd.AddForce(movement);

    
    }
}
