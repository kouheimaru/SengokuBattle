using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 道
    public GameObject river;
    public GameObject forest;
    public GameObject mountain;
    public GameObject plain;
    //スポット
    public GameObject stronghold;
    public GameObject yagura;
    public GameObject field;
    //駒
    public GameObject yari;
    public GameObject horse;
    public GameObject gun;

    //マップの大きさ
    public int width;
    public int height;


    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = new Vector2(0.0f, 0.0f);
        //マップを生成する
        for (int i = -height; i < height; i++)
        {
            pos.y = i;
            for(int j = -width; j< width; j++)
            {
                pos.x = j;
                Instantiate(plain, pos, transform.rotation);
            }
        }

        Instantiate(yari, new Vector2(-4.0f, 2.0f), transform.rotation);
        Instantiate(yari, new Vector2(-4.0f, 1.0f), transform.rotation);
        Instantiate(yari, new Vector2(-4.0f, 0.0f), transform.rotation);
        Instantiate(yari, new Vector2(-4.0f, -1.0f), transform.rotation);
        Instantiate(yari, new Vector2(-4.0f, -2.0f), transform.rotation);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
