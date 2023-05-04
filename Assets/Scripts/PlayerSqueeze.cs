using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerSqueeze : MonoBehaviour
{
    // public
 
    public float maxSize = 0.8f;
    public float minSize = 0.3f;
    public float squeezeOverTime = 1.5f;
    public float unsqueezeOverTime = 1.25f;
    public float currentSize = 0.8f;
 
    public GameObject player;
 
    // private
 
    public bool CanShrink = false;
 
    // void
 
 
    void Update()
    {
 
        if (currentSize > minSize && CanShrink)
        {
            currentSize -= ((currentSize * squeezeOverTime) * Time.deltaTime);
            Apply();
        }
        else if (currentSize < maxSize && !CanShrink)
        {
            currentSize += ((currentSize * unsqueezeOverTime) * Time.deltaTime);
            Apply();
        }
 
        if (Input.GetMouseButton(0))
        {
            CanShrink = true;
        }
        else if (!Input.GetMouseButton(0))
        {
            CanShrink = false;
        }
    }
 
    void Apply()
    {
        player.transform.localScale = new Vector3(currentSize, currentSize, currentSize);
    }
}