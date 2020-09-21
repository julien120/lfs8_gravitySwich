using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public bool scoreStop;
    public GameObject gameOverText;


    ScoreController scoreController;
    public GameObject ScoreControllerObject;
   
    
    // Start is called before the first frame update
    void Start()
    {
        scoreController = ScoreControllerObject.GetComponent<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += new Vector3(0.1f, 0, 0);

        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(0, 200f,0));
        }



        if (scoreStop == true)
        {
            Debug.Log("ロード条件分岐");
            if (Input.GetKey(KeyCode.R))
            {
                Debug.Log("リロードする");
                //Rを押したらゲームをリロードする
                SceneManager.LoadScene("GameMode");
                scoreStop = false;


            }
        }




    }

    private void OnTriggerEnter(Collider coll)
    {
        if(coll.gameObject.CompareTag("wallChecker"))
        {
            Debug.Log("当たった");
            scoreStop = true;
            gameOverText.SetActive(true);

        }


        if (coll.gameObject.CompareTag("Item"))
        {
            scoreController.scoreCount += 300;
            scoreController.scoreText.text = scoreController.scoreCount.ToString("f0");
        }



    }

}
