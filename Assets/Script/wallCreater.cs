using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreater : MonoBehaviour
{
    public GameObject wall;
    float timer = 0;
    float interval = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(何を,何秒後に);
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            //wall生成を配列とfor文で繰り返し処理を実装する
            //for文はbool変数distance==trueの際に繰り返し行われるようにする
            //instantiateで生成するwall[i]を配列化し、ランダムで有意のインデックスを取り出す。
            //そして行末にdistance==false
            //interval=<float変数でdistance==true化し、update回に繰り返し処理が行われる。


            //Instantiate(何を(GameObject型変数)、どこに、角度は);
            Instantiate(wall, transform.position*Time.deltaTime, transform.rotation);
            timer = 0;
        }
        
    }
}
