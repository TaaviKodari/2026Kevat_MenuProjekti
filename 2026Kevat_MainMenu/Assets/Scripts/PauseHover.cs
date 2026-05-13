using UnityEngine;
using UnityEngine.EventSystems;
public class PauseHover : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    public PauseSelector selector;
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
