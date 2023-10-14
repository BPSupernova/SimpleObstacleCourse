using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngleIncrease = 0;
    [SerializeField] float yAngleIncrease = 0;
    [SerializeField] float zAngleIncrease = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngleIncrease,yAngleIncrease,zAngleIncrease);       
    }
}
