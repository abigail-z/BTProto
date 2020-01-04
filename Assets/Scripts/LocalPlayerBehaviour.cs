using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPlayerBehaviour : MonoBehaviour
{
    public float speed;

    void Update()
    {
        Vector2 pos = transform.position;
        pos += new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * Time.deltaTime * speed;
        transform.position = pos;
    }
}
