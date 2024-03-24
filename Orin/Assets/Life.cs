using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    int currentLife;
    int maxLife = 3;
    [SerializeField] GameObject[] xX;

    // Start is called before the first frame update
    void Start()
    {
        currentLife = maxLife;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LooseLife()
    {
        currentLife--;
        xX[currentLife].SetActive(true);

        if(currentLife <= 0)
        {
            Invoke("GameOver", 0.2f);
        }
    }

    public void GameOver()
    {
        FindObjectOfType<LevelLoader>().GameOver();
    }
}
