using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public enum TurnState
    {
        None = 0,
        PlayerOne=1,
        PlayerTwo=2
    };

    public TurnState Turn;
    public List<int> playerOneChecks;
    public List<int> playerTwoChecks;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        Turn = TurnState.PlayerOne;
        
    }

    public void changeTurn(int _id)
    {
        if (Turn == TurnState.PlayerOne)
        {
            Turn = TurnState.PlayerTwo;
            playerOneChecks.Add(_id);

        }
        else if (Turn == TurnState.PlayerTwo)
        {
            Turn = TurnState.PlayerOne;
            playerTwoChecks.Add(_id);
        }
        checkDiagonals();

        Debug.Log("Current turn =>" + Turn);
    }

    void checkDiagonals()
    {
        if (playerOneChecks.Contains(4) && ((playerOneChecks.Contains(0) && playerOneChecks.Contains(8))|| (playerOneChecks.Contains(2) && playerOneChecks.Contains(6))))
        {
            Debug.Log("PlayerOne Wins");
        }

        if (playerTwoChecks.Contains(4) && ((playerTwoChecks.Contains(0) && playerTwoChecks.Contains(8)) || (playerTwoChecks.Contains(2) && playerTwoChecks.Contains(6))))
        {
            Debug.Log("PlayerTwo Wins");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
