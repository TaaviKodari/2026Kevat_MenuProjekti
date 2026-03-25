using UnityEngine;
using TMPro;

public class Selector : MonoBehaviour
{
    public TMP_Text [] items;
    public Color normalColor = Color.white;
    public Color highlightColor = Color.yellow;
    private int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateColors();
    }

    // Update is called once per frame
    void Update()
    {
        //Ylöspäin
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            index = (index - 1 + items.Length) % items.Length;
            //Debug.Log(index);
            UpdateColors();
        }

        //Alaspäin
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            index = (index +1) % items.Length;
            //Debug.Log(index);
            UpdateColors();
        }

        //Valinta
        if (Input.GetKeyDown(KeyCode.Return))
        {
           ActivateItem(index);
        }
    }

    private void UpdateColors()
    {
        for(int i = 0; i < items.Length; i++)
        {
            items[i].color = (i == index) ? highlightColor : normalColor;
        }
    }

    public void ActivateItem(int i)
    {
        Debug.Log("Selected: " + items[i].text);
    }

    public void SetIndex(int newIndex)
    {
        index = newIndex;
        UpdateColors();
    }

}
