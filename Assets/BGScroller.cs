using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroller : MonoBehaviour
{
    private MeshRenderer render;
    private float offset;

    public float speed = 0.3f;

    void Start()
    {
        render = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        offset += Time.deltaTime * speed;
        render.material.mainTextureOffset = new Vector2(offset, 0);
 
    }
}
