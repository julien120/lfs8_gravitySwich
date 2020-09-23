using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreater : MonoBehaviour
{
   // float timer = 0;
//    float interval=1;

    public GameObject[] walls = new GameObject[2];
    int randomCount;
    float width;

    bool repeatcheck;
    public GameObject emptyBox;

    public GameObject player;
    PlayerController playerController;

    //cs型変数 = GameObject型変数.GetComponent<cs名>();

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<PlayerController>();

        //Destroy(何を,何秒後に);
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
//        timer +=Time.deltaTime;



        //playerが一定距離を進むごとにwallが生成されるようにしたい
        //playerController.transform.position.x %Time.frameCount==0ではない
        //player.x %60==0
        if (repeatcheck == false&& Time.frameCount % 50 == 0) { 
        
        //for (int i = 0; i < 4; i++)
        //{
            randomCount = Random.Range(0, 2);
            //new Vector3(playerController.gameObject.transform.position.x + gameObject.transform.position.x, 0, 0)
            Instantiate(walls[randomCount], new Vector3(emptyBox.transform.position.x, 0, 0), Quaternion.identity);


                //Instantiate(walls[randomCount], width, transform.rotation);
               // timer = 0;

        //}
        
        }

        if(playerController.scoreStop == true)
        {
            repeatcheck = true;
            Debug.Log("wall生成止まるよ");
        }



    }

}
