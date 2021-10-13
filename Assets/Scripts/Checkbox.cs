using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CheckBox : MonoBehaviour , IPointerClickHandler, IPointerEnterHandler
{
    public Sprite Cross;
    public Sprite Circle;
    public GameController Game;
    public int ID;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("saucisse "+(11+11));
        if (Game.Turn == GameController.TurnState.PlayerOne && GetComponent<Image>().sprite == null)
        {
            GetComponent<Image>().sprite = Cross;
            Game.changeTurn(ID);
        }
        else if (Game.Turn == GameController.TurnState.PlayerTwo && GetComponent<Image>().sprite == null)
        {
            GetComponent<Image>().sprite = Circle;
            Game.changeTurn(ID);
        }


        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("ouille");
    }



    // Start is called before the first frame update
    void Start()
    {
        Game = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
