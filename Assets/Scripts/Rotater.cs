using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // ga ngerti juga si, Time.deltaTime untuk smooth muternya :v
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
}
