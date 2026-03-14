using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject titleText;
    public GameObject startPanel;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       Time.timeScale = 0;
        titleText.SetActive(true);
        startPanel.SetActive(true); 
    }

    public void StartGame()
    {
    
        titleText.SetActive(false);
        startPanel.SetActive(false);

        Time.timeScale = 1;

        Debug.Log("Game Started!");
    }


    
    // Update is called once per frame
    void Update()
    {
        
    }
}
