using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
  
    void Start()
    {
        PrintInstruction();
    }

    
    void Update()
    {
        MoveBecu();
    }


    void PrintInstruction()
    {
        Debug.Log("Merhaba Oyunuma Hosgeldin");
        Debug.Log("W-A-S-D tuslari ile hareket et");
        Debug.Log("ve engellere carpmamaya calis...");
    }

    void MoveBecu()
    {   float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
