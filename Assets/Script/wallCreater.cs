using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreater : MonoBehaviour
{
    //public GameObject wall;
    float timer = 0;
    float interval = 4.5f;
    public GameObject[] walls = new GameObject[3];
    int randomCount;

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
        

        if(repeatcheck == false) { 
        randomCount = Random.Range(0, 2);
        for (int i = 0; i < 3; i++)
        {
            Instantiate(walls[randomCount], transform.position * Time.deltaTime, transform.rotation);
            Instantiate(walls[randomCount], transform.position * Time.deltaTime, transform.rotation);

        }
        
        }

        if(playerController.scoreStop == false)
        {
            repeatcheck = true;
            Debug.Log("wall生成止まるよ");
        }



    }


    //timer += Time.deltaTime;
    //    if(timer >= interval)
    //    {

    //        //Instantiate(何を(GameObject型変数)、どこに、角度は);
    //        Instantiate(wall, transform.position* Time.deltaTime, transform.rotation);
    //timer = 0;
    //    }
}
