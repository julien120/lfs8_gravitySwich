using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallCreater : MonoBehaviour
{
    public GameObject wall;
    float timer = 0;
    int interval = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= interval)
        {
            //Instantiate(何を(GameObject型変数)、どこに、角度は);
            Instantiate(wall, transform.position, transform.rotation);
            timer = 0;
        }
        
    }
}
