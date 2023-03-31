using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDir = new Vector2(0,0);

        if(Input.GetKey(KeyCode.W)) moveDir.y = +1f;
        if(Input.GetKey(KeyCode.S)) moveDir.y = -1f;
        if(Input.GetKey(KeyCode.A)) moveDir.x = -1f;
        if(Input.GetKey(KeyCode.D)) moveDir.x = +1f;

        float moveSpeed = 3f;
        
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);

    }
}
