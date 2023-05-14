using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
   
    GameObject enemy;
    public GameObject enemyPrefab;
    int exist = 0; //enemy �̹� ������ �߰� ���� x
    float AllLightOff =  0; //��� ���� �����ִ��� üũ
    

    void Update()
    {
        
        GameObject[] off = GameObject.FindGameObjectsWithTag("Light");
        float check = 1.0f;
        for (int i = 0; i < off.Length; i++) // ��� ���� ���������� AllLightoff =  1�� �ǵ��� ���� ���
        {
           check *= off[i].GetComponent<LightController>().lightOff;
        }
        AllLightOff += check;

        if (this.exist == 0 && this.AllLightOff == 1.0f)
        {
            this.enemy = Instantiate(enemyPrefab);
            this.exist = 1;
        }
    }
}
