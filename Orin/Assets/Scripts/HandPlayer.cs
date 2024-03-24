using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPlayer : MonoBehaviour
{
    bool isActive = false;
    Vector3 newPos;
    float yPos;

    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(isActive)
        {
            newPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            newPos.y = yPos;
            newPos.z = 0;

            transform.position = newPos;
        }
    }

    public void NextSprite(Sprite nextS)
    {
        GetComponent<SpriteRenderer>().sprite = nextS;
    }

    private void OnMouseDown()
    {
        if(!isActive)
        {
            isActive = true;
        }
    }
}
