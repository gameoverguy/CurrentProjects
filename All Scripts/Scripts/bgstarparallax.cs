using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgstarparallax : MonoBehaviour
{
    [SerializeField] Vector2 movSpeed;
    Vector2 Offset;
    Material Material;

    void Awake()
    {
        Material = GetComponent<SpriteRenderer>().material;
    }


    void Update()
    {
        Offset = movSpeed * Time.deltaTime;
        Material.mainTextureOffset += Offset;
    }
}
