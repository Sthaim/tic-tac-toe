using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{

    public GameObject Grid;
    public GameObject Launch;
    public GameObject EndTxt;
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
        Grid.gameObject.SetActive(false);
        EndTxt.gameObject.SetActive(false);

    }

    public void displayGrid()
    {
        Grid.gameObject.SetActive(true);
        Launch.gameObject.SetActive(false);
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
        checkVictory();

        Debug.Log("Current turn =>" + Turn);
    }

    void checkVictory()
    {
        //player one
        //diagonale
        if (playerOneChecks.Contains(4) && ((playerOneChecks.Contains(0) && playerOneChecks.Contains(8))|| (playerOneChecks.Contains(2) && playerOneChecks.Contains(6))))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        //ligne

        else if (playerOneChecks.Contains(0) && playerOneChecks.Contains(1) && playerOneChecks.Contains(2))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerOneChecks.Contains(3) && playerOneChecks.Contains(4) && playerOneChecks.Contains(5))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerOneChecks.Contains(6) && playerOneChecks.Contains(7) && playerOneChecks.Contains(8))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        //colonne

        else if (playerOneChecks.Contains(0) && playerOneChecks.Contains(3) && playerOneChecks.Contains(6))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerOneChecks.Contains(1) && playerOneChecks.Contains(4) && playerOneChecks.Contains(7))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerOneChecks.Contains(2) && playerOneChecks.Contains(5) && playerOneChecks.Contains(8))
        {
            Debug.Log("PlayerOne Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        //player two

        else if (playerTwoChecks.Contains(4) && ((playerTwoChecks.Contains(0) && playerTwoChecks.Contains(8)) || (playerTwoChecks.Contains(2) && playerTwoChecks.Contains(6))))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        //ligne

        else if (playerTwoChecks.Contains(0) && playerTwoChecks.Contains(1) && playerTwoChecks.Contains(2))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerTwoChecks.Contains(3) && playerTwoChecks.Contains(4) && playerTwoChecks.Contains(5))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerTwoChecks.Contains(6) && playerTwoChecks.Contains(7) && playerTwoChecks.Contains(8))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        //colonne

        else if (playerTwoChecks.Contains(0) && playerTwoChecks.Contains(3) && playerTwoChecks.Contains(6))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerTwoChecks.Contains(1) && playerTwoChecks.Contains(4) && playerTwoChecks.Contains(7))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }

        else if (playerTwoChecks.Contains(2) && playerTwoChecks.Contains(5) && playerTwoChecks.Contains(8))
        {
            Debug.Log("PlayerTwo Wins");
            Grid.gameObject.SetActive(false);
            EndTxt.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
