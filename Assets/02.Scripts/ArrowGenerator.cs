using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float spawnTime = 0.3f;
    float deltaTime = 0.0f;
    
    void Update()
    {
        //Time.Tiem : 게임 시작 이후 시간을 초 단위로 변환
        //Tiem.deltaTime : 프레임과 프레임 사이의 걸린 시간
        //Time.fixedDeltaTime : 물리 및 고정 프페임 속도 초단위
        //Time.timeScale : 게임 전체에 대한 시간 
        //Time.realimeSinceStartup : 게임 시작 이후의 시간을 초단위로 반환
        deltaTime += Time.deltaTime;
        if(deltaTime > spawnTime)
        {
            deltaTime = 0f;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-7f, 7f);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
