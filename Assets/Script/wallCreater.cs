using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreater : MonoBehaviour
{


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

       
    }

    // Update is called once per frame
    void Update()
    {

        if (repeatcheck == false&& Time.frameCount % 180 == 0) { 
        
 
            randomCount = Random.Range(0, 2);
            //new Vector3(playerController.gameObject.transform.position.x + gameObject.transform.position.x, 0, 0)
            Instantiate(walls[randomCount], new Vector3(emptyBox.transform.position.x, 0, 0), Quaternion.identity);


                //Instantiate(walls[randomCount], width, transform.rotation);
               // timer = 0;

        //}
        
        }

        if(PlayerController.scoreStop == true)
        {
            repeatcheck = true;
            Debug.Log("wall生成止まるよ");
        }



    }

}
