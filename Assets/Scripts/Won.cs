using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Won : MonoBehaviour
{
    public GameObject won;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        won.SetActive(true);
    }
}
