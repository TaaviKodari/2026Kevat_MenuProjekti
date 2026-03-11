using UnityEngine;
using TMPro;

public class Selector : MonoBehaviour
{
    public TMP_Text [] items;
    
    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ylöspäin
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index = (index - 1 + items.Length) % items.Length;
            Debug.Log(index);
        }

        //Alaspäin
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index = (index +1) % items.Length;
            Debug.Log(index);
        }

        //Valinta
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Indexi on: " + index);
        }
    }
}
