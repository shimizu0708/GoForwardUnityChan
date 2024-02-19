using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // �L���[�u�̈ړ����x
    private float speed = -12;
    // ���ňʒu
    private float deadLine = -10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �L���[�u���ړ�������
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����j������
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
    //�L���[�u���n�ʂɐڐG����Ƃ��ƃL���[�u���m���ςݏd�Ȃ�Ƃ��Ɍ��ʉ�������----------------------lesson7 �ۑ�y�L���[�u�̐ڐG���Ɍ��ʉ������悤�z�@�ǋL�@/1
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ground" || other.gameObject.name == "cubePrefab(Clone)")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
