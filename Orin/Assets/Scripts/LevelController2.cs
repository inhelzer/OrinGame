using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LevelController2 : MonoBehaviour
{
    
    public float levelSpeed = 0.7f;
    public float levelGravity = 1.5f;

    public GameObject[] foodParts;
    public GameObject[] challange;
    public int currentFood = 0;

    public Sprite challangeGrafic;
    [SerializeField] GameObject uiChallange;

    public Sprite[] nextSprites;

    // Start is called before the first frame update
    void Start()
    {
        
        challange = new GameObject[4];
        CreateChalange();

        uiChallange.GetComponent<SpriteRenderer>().sprite = challangeGrafic;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CreateChalange()
    {
        challange[0] = foodParts[0];
        challange[1] = foodParts[1];
        challange[2] = foodParts[2];
        challange[3] = foodParts[3];
        
        currentFood = 0;
        
    }

    public void ChackFood(string name)
    {
        if (challange[currentFood].gameObject.tag != name)
        {
            FindObjectOfType<Life>().LooseLife();
        }

        if (challange[currentFood].gameObject.tag == name)
        {
            FindObjectOfType<HandPlayer>().NextSprite(nextSprites[currentFood]);
            
            currentFood++;
            
            if (currentFood >= 4)
            {
                //FindObjectOfType<trophys>().CreateGood();
                Invoke("WinLevel", 1f);
            }
        }
    }

    public void WinLevel()
    {
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }
}
