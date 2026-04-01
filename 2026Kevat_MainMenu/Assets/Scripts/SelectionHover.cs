using UnityEngine;
using UnityEngine.EventSystems;
public class SelectionHover : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public Selector selector;
    public int index;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Debug.Log("Cursor Entering " + name + " GameObject");
        selector.SetIndex(index);
    }

     public void OnPointerClick(PointerEventData pointerEventData)
    {
        selector.ActivateItem(index);
    }
}
