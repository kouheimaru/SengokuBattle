using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//追加↓

public class TileClone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        //親オブジェクトを自分の場所にクローンする
        GameObject parentObj = transform.parent.gameObject;
        Vector2 pos = this.transform.position;

        Instantiate(parentObj, new Vector2(pos.x, pos.y), Quaternion.identity);

        Destroy(parentObj);
    }
}
