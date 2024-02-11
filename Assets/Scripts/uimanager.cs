using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class uimanager : MonoBehaviour
{
    // Start is called before the first frame update
    public int p1score = 1;
    public int p2score = 2;
    public TextMeshProUGUI score1text;
    public TextMeshProUGUI score2text;
    public GameObject pausepanel;
    public int lvlwin = 5;
    void Start()
    {
        pausepanel.SetActive(false);
    }
    public void updatep1score(int value)
    {
        score1text.text = (int.Parse(score1text.text) + value).ToString();
     
    }
    public void updatep2score(int value)
    {
        score2text.text = (int.Parse(score2text.text) + value).ToString();
    }
    public void resume()
    {
        pausepanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void home()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pausepanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
