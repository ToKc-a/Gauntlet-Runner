using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    Renderer renderer;
    float offset;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        //Увеличение смещения в зависимости от времени
        offset += Time.deltaTime * speed;
        //Смещение в диапазоне от 0 до 1
        if (offset > 1)
            offset -= 1;
        //Применение смещения к материалу
        renderer.material.mainTextureOffset = new Vector2(0, offset);
    }
}
