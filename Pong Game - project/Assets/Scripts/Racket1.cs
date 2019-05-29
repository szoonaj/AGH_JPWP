using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket1 : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        
        // zdefiniuj druga zmienna, ktora bedzie odpowiadala za ruch w poziomie 
        // zastosuj ja w ponizszej lini
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed; 
    }
    
}
