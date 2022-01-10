using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
    
{
    public float speed = 10;
    public float turnSpeed = 4;

    public GameObject prefabMusic;

    // Start is called before the first frame update
    void Start()
    {
        var music = GameObject.Find("BgMusic");
        if (music == null)
        {
            var m = Instantiate(prefabMusic, null);
            m.name = "BgMusic";
            DontDestroyOnLoad(m);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
            return;
        }

        float x = Input.GetAxis("Horizontal");
        transform.Translate(x * turnSpeed * Time.deltaTime, 0, speed * Time.deltaTime);

        //屏幕动态旋转效果
        var c = Camera.main.transform;
        Quaternion cur = c.rotation;
        Quaternion target = cur * Quaternion.Euler(0, 0, x * 0.1f);
        Camera.main.transform.rotation = Quaternion.Slerp(cur, target, 0.5f);

        if (transform.position.x < -4 || transform.position.x > 4)
        {
            transform.Translate(0, -10 * Time.deltaTime, 0);
        }
        if (transform.position.y < -20)
        {
            Time.timeScale = 0;
        }
    }
}
