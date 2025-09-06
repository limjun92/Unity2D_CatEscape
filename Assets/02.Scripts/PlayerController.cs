using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        float move = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))   // ¡ç
        {
            move = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))  // ¡æ
        {
            move = 1f;
        }

        //transform.Translate(Vector3.right * move * speed * Time.deltaTime);
        transform.Translate((move * speed)/500, 0, 0);
    }
}
