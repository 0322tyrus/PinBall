using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //�ŏ��T�C�Y
    private float minimum = 1.0f;
    //�g��k���X�s�[�h
    private float magSpeed = 10.0f;
    //�g�嗦
    private float magnification = 0.07f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�_���g��k��
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
   //Mathf.Sin�̈Ӗ��ASin�֐��H���p�x�����������
   //�@�X�^�[�g����̎���*�g��k���X�s�[�h*�g�嗦�{�����̃T�C�Y
   
   //�g��k���ǂ�����Ă���H��Sin�g�����ƂŖ����ɐL�т鎞�Ԃ̎��𔼌a1�̉~�Ɋ������A�����I������ʒu��m�点��C���[�W�i�P�ʉ~�̍l�����炵���j�A����ɂ���Ɋg��X�s�[�h���|���Ċg�嗦���|���Ă���


    }
}
