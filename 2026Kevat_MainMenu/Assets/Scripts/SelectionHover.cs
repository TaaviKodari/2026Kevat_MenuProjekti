using UnityEngine;
using UnityEngine.EventSystems;
public class SelectionHover : MonoBehaviour, IPointerEnterHandler
{
    public Selector selector;
    public int index;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Debug.Log("Cursor Entering " + name + " GameObject");
        selector.SetIndex(index);
    }
}
