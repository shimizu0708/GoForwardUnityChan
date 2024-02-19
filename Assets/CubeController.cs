using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // キューブの移動速度
    private float speed = -12;
    // 消滅位置
    private float deadLine = -10;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }
    //キューブが地面に接触するときとキューブ同士が積み重なるときに効果音をだす----------------------lesson7 課題【キューブの接触時に効果音をつけよう】　追記①/1
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "ground" || other.gameObject.name == "cubePrefab(Clone)")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
