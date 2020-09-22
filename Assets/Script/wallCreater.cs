using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreater : MonoBehaviour
{
    float timer = 0;
    float interval=1;

    public GameObject[] walls = new GameObject[3];
    int randomCount;
    float width;

    bool repeatcheck;

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
        timer +=Time.deltaTime;
     



        if (repeatcheck == false&&timer>=interval) { 
        
        for (int i = 0; i < 1; i++)
        {
            randomCount = Random.Range(0, 3);
            Instantiate(walls[randomCount], new Vector3(playerController.gameObject.transform.position.x+gameObject.transform.position.x, 0, -0.8702888f), Quaternion.identity);

                //width = transform.position.x + walls[0].GetComponent<RectTransform>().sizeDelta.x;

                //widthをinstantiateに入れるとエラー起きる
                //Instantiate(walls[randomCount], width, transform.rotation);
                timer = 0;

        }
        
        }

        if(playerController.scoreStop == true)
        {
            repeatcheck = true;
            Debug.Log("wall生成止まるよ");
        }



    }

}
