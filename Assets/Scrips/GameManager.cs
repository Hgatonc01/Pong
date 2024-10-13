using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject bola;

    public GameObject player1;
    public GameObject player1Goal;

    public GameObject player2;
    public GameObject player2Goal;

    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;

    private int player1Score;
    private int player2Score;


    public void Player1Scored()
    {
        player1Score++;
        player1Text.text = player1Score.ToString();
        if (player1Score>=4)
        {
            CargarEscenaFinal();
        }
        ResetPosition();
    }

    public void Player2Scored()
    {
        player2Score++;
        player2Text.text = player2Score.ToString();
        if (player2Score >= 4)
        {
            CargarEscenaFinal();
        }
        ResetPosition();
    }

    private void CargarEscenaFinal()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void ResetPosition()
    {
        bola.GetComponent<Bola>().Reset();
        player1.GetComponent<Raqueta>().Reset();
        player2.GetComponent<Raqueta>().Reset();
    }

}
