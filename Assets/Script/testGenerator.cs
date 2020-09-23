using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGenerator : MonoBehaviour
{
    //public GameObject[] walls = new GameObject[2];
    public GameObject[] tests = new GameObject[2];
    int randomCount;
    float width;
    int count;

    public GameObject dist;

    bool repeatcheck;

    public GameObject item;

    int itemChance;


    public GameObject player;
    PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        //playerController = player.GetComponent<PlayerController>();
        if (PlayerController.scoreStop == false)
        {
            Invoke("createWall", 0.3f);
           

        }



    
}

    // Update is called once per frame
    void Update()
    {
       
    }

    void createWall()
    {
        randomCount = Random.Range(0, 2);
        count = Random.Range(-3, 1);

        Instantiate(tests[randomCount], new Vector3(dist.transform.position.x, count, -0.9f), Quaternion.identity);
        count += Random.Range(2, 5);

        if (itemChance <= 10)
        {
            Instantiate(item, new Vector3(dist.transform.position.x, count, -0.05f), Quaternion.identity);
        }
    }
}
