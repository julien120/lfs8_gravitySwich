using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{

    public GameObject player;
    PlayerController playerController;

    public GameObject emptyBox;

    float timer;
    float interval =2;

    public GameObject item;

    int itemChance;

    // Start is called before the first frame update
    void Start()
    {
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval) {
        itemChance = Random.Range(1, 100);

            if (itemChance <= 90) { 
                 Instantiate(item, emptyBox.transform.position, Quaternion.identity);
            }
        timer = 0;
        }
    }
}
