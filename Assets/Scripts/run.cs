using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class run : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float xspeed;
    [SerializeField] float s;
    [SerializeField] float coins;
    [SerializeField] Text textCoins;
    [SerializeField] GameObject coinsound;
    [SerializeField] GameObject gameover;
    [SerializeField] GameObject song;
    bool tr;
    [SerializeField] public float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "coin")
        {
            Instantiate(coinsound,transform.position, Quaternion.identity);
            coins++;
            Destroy(other.gameObject);
        }
    }
    public void Restart()
    {

        Level.Restart();
    }
    // Update is called once per frame
    void Update()
    {
        textCoins.text = "|Coins|:" + coins+":|";
        if (Input.GetAxis("Vertical")==0)
        { transform.Translate(0, 0, Time.deltaTime * speed); }
        else if (Input.GetAxis("Vertical") < 0)
        {
            transform.Translate(0, 0, Time.deltaTime * (speed * 0.6f));
        }else
        {
            transform.Translate(0, 0, Time.deltaTime * (speed * 1.6f));
        }
        if (transform.position.y > 1f*s || transform.position.y < -1f*s)
        {
            gameover.SetActive(true);

            Destroy(song);
        }
        transform.Translate(Time.deltaTime * xspeed*Input.GetAxis("Horizontal"), 0, 0); if (!tr)
        {
            speed += 0.1f;
            StartCoroutine(RIG());
        }
    }
    IEnumerator RIG()
    {
        //Print the time of when the function is first called.
        //  Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //  ScreenCapture.CaptureScreenshot("C:/Unauticna Multiverse/Screenshot" + Random.Range(0, int.MaxValue) + ".png", 1);


        tr = !tr;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(timer);
        tr = !tr;

        //  Debug.Log("Finished Coroutine at timestamp : " + Time.time);

    }
}
