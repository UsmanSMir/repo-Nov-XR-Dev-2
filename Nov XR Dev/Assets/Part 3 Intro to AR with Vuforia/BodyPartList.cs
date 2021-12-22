using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartList : MonoBehaviour
{
    
    public void ToggleRenderer(Renderer rend)
    {
        rend.enabled = !rend.enabled;
    }
}
