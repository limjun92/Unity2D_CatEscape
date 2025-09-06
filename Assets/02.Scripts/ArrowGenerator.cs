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
        //Time.Tiem : ���� ���� ���� �ð��� �� ������ ��ȯ
        //Tiem.deltaTime : �����Ӱ� ������ ������ �ɸ� �ð�
        //Time.fixedDeltaTime : ���� �� ���� ������ �ӵ� �ʴ���
        //Time.timeScale : ���� ��ü�� ���� �ð� 
        //Time.realimeSinceStartup : ���� ���� ������ �ð��� �ʴ����� ��ȯ
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
