using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //アイテムが一定間隔でランダムに生成される
    //生成:instantiate(item,座標はplayerController.emptyBox.x,0);
    //cs型変数 = GameObject型変数.GetComponent<cs名>();

    wallCreater wallcs;
    public GameObject wall;

    float timer;
    float interval =2;

    public GameObject item;

    int itemChance;

    // Start is called before the first frame update
    void Start()
    {
        wallcs = wall.GetComponent<wallCreater>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval) {
        itemChance = Random.Range(1, 100);

            if (itemChance <= 20) { 
                 Instantiate(item, wallcs.emptyBox.transform.position, Quaternion.identity);
            }
        timer = 0;
        }
    }
}
