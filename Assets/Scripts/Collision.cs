using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D()
    {
        Debug.Log("Bumped!");
    }

    void OnTriggerEnter2D()
    {
        Debug.Log("You passed through it");
    }
}
