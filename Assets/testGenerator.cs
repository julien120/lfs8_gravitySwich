using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGenerator : MonoBehaviour
{
    //public GameObject[] walls = new GameObject[2];
    public GameObject[] tests = new GameObject[2];
    int randomCount;
    float width;

    public GameObject dist;

    bool repeatcheck;
    

    public GameObject player;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<PlayerController>();
        if (repeatcheck == false)
        {
            Invoke("createWall", 0.3f);
           

        }

        if (playerController.scoreStop == true)
        {
            repeatcheck = true;
            Debug.Log("wall生成止まるよ");
        }



    
}

    // Update is called once per frame
    void Update()
    {
       
    }

    void createWall()
    {
        randomCount = Random.Range(0, 2);
        Instantiate(tests[randomCount], new Vector3(dist.transform.position.x, Random.Range(-3, 1), -0.9f), Quaternion.identity);
    }
}
