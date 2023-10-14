using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions() {
        Debug.Log("Welcome To The Game!");
        Debug.Log("Try to avoid all the walls and obstacles");
        Debug.Log("Move left and right by using the A and D keys or left and right arrow keys respectively");
        Debug.Log("Move up and down by using the W and S keys or the up and down arrow keys respectively");
    }

    void MovePlayer() {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
