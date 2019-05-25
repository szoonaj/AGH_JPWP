using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket2 : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");    // project settings >> input >> definiujemy klawisze dla rakiet

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    }

}
