using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    public float speed = -0.01f;

    GameObject player;

    void Start()
    {
        player = GameObject.Find("player");
    }

    void Update()
    {
        transform.Translate(0, -0.01f, 0);
        if(transform.position.y < -6.0f)
        {
            Destroy(gameObject);
        }

        //충돌 판정
        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;

        Vector2 dir = p1 - p2;
        float d = dir.magnitude;

        float r1 = 0.3f;
        float r2 = 1f;

        if(d < r1 + r2)
        {
            //UI를 갱신
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHp();
            //충돌했을 때 
            Destroy(gameObject);
        }
    }
}
