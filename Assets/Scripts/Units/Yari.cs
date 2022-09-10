using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yari : MonoBehaviour
{
    public int hitPoints = 2000;
    public int prov = 20000;
    public int eatSpeed = 1;
    public bool hungry = false;
    public GameObject moveTile;
    public int mobility = 1;


    public void attackEnemy(GameObject enemy)
    {
        // 敵さんの体力を取得する
        // ダメージ＝(attack * hitPoints/ 5)
        // 反動　＝　敵の攻撃力 * hitPoints/10
        
        //ダメージと反動をUIで表示する
        //ダメージと反動を反映させる
        
        //敵の体力が0以下なら消す
        //相手の兵糧を奪える
        //自分の体力が0以下なら消す
    }
    public void consumeProvi()
    {
        if(hungry == true)
        {
            //飢餓ダメージを受ける
            hitPoints = hitPoints - 5;
        }
        else
        {
        int eat = eatSpeed * hitPoints;
        prov = prov - eat;
        if (prov < 0)
        {
            hitPoints = hitPoints + prov;
        }
        }
    }

    public void MoveRange()
    {
        //表示されているタイルをすべて消す
        tileDelete();
        Vector2 pos = new Vector2(this.transform.position.x, this.transform.position.y);
        //移動したときのタイルを生成する 
        makeMove(pos);

    }
    public void makeMove(Vector2 pos)
    {
        // 移動オブジェクトを検知できれば、ほかのマスをすべて消す
        GameObject Obj;
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(pos.x, Mathf.FloorToInt(pos.y) + i), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(pos.x, Mathf.FloorToInt(pos.y) - i), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        //横移動
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(Mathf.FloorToInt(pos.x) + i, pos.y), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(Mathf.FloorToInt(pos.x) - i, pos.y), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        //斜め
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(Mathf.FloorToInt(pos.x) - i, Mathf.FloorToInt(pos.y) - i), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(Mathf.FloorToInt(pos.x) + i, Mathf.FloorToInt(pos.y) + i), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(Mathf.FloorToInt(pos.x) - i, Mathf.FloorToInt(pos.y) + i), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
        for (int i = 1; i < 1 + mobility; i++)
        {
            Obj = (GameObject)Instantiate(moveTile, new Vector2(Mathf.FloorToInt(pos.x) + i, Mathf.FloorToInt(pos.y) - i), Quaternion.identity);
            Obj.transform.parent = this.transform;
        }
    }

    public void tileDelete()
    {
        GameObject[] tiles = GameObject.FindGameObjectsWithTag("tile");
        for (int i = 0; i < tiles.Length; i++)
        {
            Destroy(tiles[i]);
        }
    }

    private void Awake()
    {
        tileDelete();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
