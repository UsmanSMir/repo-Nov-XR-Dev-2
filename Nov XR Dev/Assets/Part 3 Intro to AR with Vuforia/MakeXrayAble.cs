using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeXrayAble : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<Renderer>().material.renderQueue = 3002;
    }
}
