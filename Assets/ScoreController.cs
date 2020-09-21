using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    float scoreCount;

    PlayerController playerController;
    public GameObject PlayerControllerObject;


    // Start is called before the first frame update
    void Start()
    {
       playerController = PlayerControllerObject.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Playerの座標をScoreに代入しているが、Scoreを時間にし、ゲームオーバーでそのまま泊まる方がいいかも
        //scoreCount += playerController.gameObject.transform.position.x;

        if(playerController.scoreStop == false) { 

        scoreCount += Time.deltaTime;
        scoreText.text = scoreCount.ToString("f0");
        }
    }
}
