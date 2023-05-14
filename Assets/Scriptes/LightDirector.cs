using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightDirector : MonoBehaviour
{
    float span = 3.0f;
    float delta = 0;
    public int ratio = 5; // �� �����Ӹ��� 50%Ȯ��


    /* �÷��̾ ��ȿ� �ְų� �ٸ� ������ ���� �ð���  �� ������ �ʾҰų� ���� Ų�� �� ������ �ʾҴٸ� ������ �ʱ�
             * �÷��̾ ������ Ÿ�̾� ��ž �����ð��� ������ �����Ѵ�.
             * ���� ��ȣ�� ������ ��ȣ�� ��ġ�Ѵ�. �÷��̾ ����� ���� ��ȣ�� �濡 �ִٸ� ������ Ÿ�̸Ӵ� �����.
             * �÷��̾ ��ȿ� ���ų� �ٸ� �濡 �ִٸ� Ÿ�̳ʴ� �����Ѵ�.
             * ��ȭ ��,�ƾ� ���� ���϶� Ÿ�̸Ӱ� �����.
               */
    public void Start()
    {
      
    }
    void Update()
    {
        GameObject[] light = GameObject.FindGameObjectsWithTag("Light");
        int a = Random.Range(0, light.Length);
        delta += Time.deltaTime;
        if (delta > span)
        {
            int random = Random.Range(0, 10);
            if (ratio > random)
            {
                if (light[a].GetComponent<LightController>().lightOff == 0)
                {
                    light[a].GetComponent<LightController>().lightOff = 1;
                }
            }
            delta = 0;
        }
    }
}
