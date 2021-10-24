using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeImage : MonoBehaviour
{
    public Image originalTransition;
    public Sprite newCircle;
    public Sprite newSquare;
    public Sprite newTriangle;
    public Sprite newTransition;
    public int randomNumber;
    public float tiempoFigurativo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Transition");
        
    }

    // Update is called once per frame


    //El rango (1, 3) significa que escoge entre 1 y 2 todo el rato.
    void Update()
    {
        

        //Que se cuente hasta 10.
        if (tiempoFigurativo < 10)
        {
            tiempoFigurativo = (tiempoFigurativo + 1 * Time.deltaTime);
        }

        //Cuando llega a 10 se pone la nube.
        if (tiempoFigurativo >= 10)
        {
            
            StartCoroutine("Transition");
            tiempoFigurativo = 0;

        }

    }


    public void Shifting()
    {
        if (randomNumber == 1)
        {
            originalTransition.sprite = newCircle;
        }

        if (randomNumber == 2)
        {
            originalTransition.sprite = newTriangle;
        }

        if (randomNumber == 3)
        {
            originalTransition.sprite = newSquare;
        }

    }

    IEnumerator Transition()
    {
        randomNumber = Random.Range(1, 4);
        originalTransition.sprite = newTransition;
        yield return new WaitForSeconds(2);
        Debug.Log("Fin de la transición");
        Shifting();
    }

}
