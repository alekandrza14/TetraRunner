using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] GameObject[] Spawns;
    [SerializeField] GameObject[] Spawnscoin;
    bool tr;
    [SerializeField] public float timer;
    bool tr2;
    [SerializeField] float timer2;
    void Update()
    {
        Vector3 v3 = Player.transform.position;
        Vector3 v32 = transform.position;
        Vector3 v33 = new Vector3(v32.x, v32.y, v3.z);
        Vector3 v34 = new Vector3(0, 0, v3.z);
        Vector3 v35 = new Vector3(Random.Range(-3f, 3f), 0, v3.z);
        transform.position = v33;
        if (!tr)
        {
            int r = Random.Range(0, Spawns.Length);
            Instantiate(Spawns[r], Spawns[r].transform.position + v34, Spawns[r].transform.rotation);
            timer = Spawns[r].GetComponent<generateObject>().tics;
            StartCoroutine(RIG());
        }
        if (!tr2)
        {
            int r = Random.Range(0, Spawnscoin.Length);
            Instantiate(Spawnscoin[r], Spawnscoin[r].transform.position + v35, Spawnscoin[r].transform.rotation);
            StartCoroutine(RIG2());
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
    IEnumerator RIG2()
    {
        //Print the time of when the function is first called.
        //  Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //  ScreenCapture.CaptureScreenshot("C:/Unauticna Multiverse/Screenshot" + Random.Range(0, int.MaxValue) + ".png", 1);


        tr2 = !tr2;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(timer2);
        tr2 = !tr2;

        //  Debug.Log("Finished Coroutine at timestamp : " + Time.time);

    }
}
