using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursor;

    public int life, meteorCount;
    [SerializeField] GameObject lifeFillGameObject;
    [SerializeField] GameObject meteorBarGameObject;
    private Image lifeFill;
    private Image meteorBar;

    private float initTime = 60;
    private float timer;
    public bool gameOver = false;
    [SerializeField] TextMeshProUGUI textTimer;

    [SerializeField] GameObject gameUI;
    [SerializeField] GameObject scoreUI;

    [SerializeField] TextMeshProUGUI textScore;

    [SerializeField] Image imageRating;
    [SerializeField] GameObject[] rating;
    // Start is called before the first frame update
    void Start()
    {
        timer = initTime;

        life = 10;
        lifeFill = lifeFillGameObject.GetComponent<Image>();

        meteorCount = 0;
        meteorBar = meteorBarGameObject.GetComponent<Image>();

        //To set the cursor
        Cursor.SetCursor(cursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    // Update is called once per frame
    void Update()
    {
        lifeFill.fillAmount = life / 10f;
        meteorBar.fillAmount = meteorCount /50f;

        LessCounterTime();

        GameOverUI();
    }

    public void AddTime(float timeAdded)
    {
        timer += timeAdded;
        if (timer > 60f)
        {
            timer = 60f;
        }
    }

    private void LessCounterTime()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            gameOver = true;
        }

        textTimer.text = ((int)timer).ToString();
    }

    private void GameOverUI()
    {
        if (gameOver)
        {
            //Rank
            textScore.text = $"x   {meteorCount}";
            gameUI.SetActive(false);
            scoreUI.SetActive(true);
        }
    }

    public void CheckGameOver()
    {
        if (meteorCount == 50)
        {
            gameOver = true;
        }
    }

    private void Rank()
    {
        if (meteorCount == 50)
        {
            //imageRating.GetComponent<Image>().sprite = rating[0].;
        }
    }
}
