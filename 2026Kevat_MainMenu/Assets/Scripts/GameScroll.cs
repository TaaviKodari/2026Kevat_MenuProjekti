using UnityEngine;
using UnityEngine.SceneManagement;
public class GameScroll : MonoBehaviour
{
    public GameObject [] games;
    public float gameWidth = 10f;
    private int currentIndex = 0;

    private Vector3 centerPos;
    private Vector3 rightPos;
    private Vector3 leftPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rightPos = new Vector3(gameWidth,0,0);
        leftPos = new Vector3(-gameWidth, 0, 0);
        centerPos = new Vector3(0, 0 , 0);

        for(int i = 0; i < games.Length; i++)
        {
            if(i == 0)
            {
                games[i].transform.position = centerPos;
                games[i].SetActive(true);
            }
            else
            {
                games[i].transform.position = leftPos;
                games[i].SetActive(false);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if(currentIndex == 0)
            {
                SceneManager.LoadScene("Game1");
            }
        }
    }
}
