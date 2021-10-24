using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnemyFigure : MonoBehaviour
{

    public ChangeImage figuraPlayer;
    
    public Image enemyFigure;
    public Sprite[] badShapes;
    public int randomNumberEnemy;

    // Start is called before the first frame update
    void Start()
    {
        figuraPlayer = GameObject.FindGameObjectWithTag("shift").GetComponent<ChangeImage>();
        randomNumberEnemy = Random.Range(1, 4);
        enemyFigure.sprite = badShapes[randomNumberEnemy];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (figuraPlayer.randomNumber == randomNumberEnemy)
            {
                ScoreManager.scoreManager.RaiseScore(1);
                Destroy(gameObject);
            }

            if (figuraPlayer.originalTransition.sprite == figuraPlayer.newTransition)
            {
                ScoreManager.scoreManager.RaiseScore(1);
                Destroy(gameObject);
            }

            if (figuraPlayer.randomNumber != randomNumberEnemy && figuraPlayer.originalTransition.sprite != figuraPlayer.newTransition)
            {
                Destroy(collision.gameObject);
            }



        }
        
    }

}
