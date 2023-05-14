using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Soundmenu : MonoBehaviour
{
    //����� �ͼ�
    public AudioMixer audioMixer;

    //�����̴�
    public Slider BgmSlider;
    public Slider SfxSlider;

    //���� ����
    public void SetBgmVolme()
    {
        //�Ų����� �������� �αװ� ����
        audioMixer.SetFloat("BGM", Mathf.Log10(BgmSlider.value) * 20);
        //�����̴��� �����ϴ� �޼���, �Ķ���Ϳ� ������ ����
    }

    public void SetSfxVolme()
    {
        audioMixer.SetFloat("SFX", Mathf.Log10(SfxSlider.value) * 20);
        // Mathf: ���а� ���õ� �޼��� ����
    }
}
