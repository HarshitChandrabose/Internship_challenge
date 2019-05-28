using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flow : MonoBehaviour
{
    public float speed;
    public Renderer bg;

    // Update is called once per frame
    void Update()
    {
        bg.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }
}
