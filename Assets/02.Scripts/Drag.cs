using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Transform inventoryTr;

    void Start()
    {
        inventoryTr = GameObject.Find("Inventory").transform;
    }

#region MOUSE_EVENTS
    // 마우스 드래그가 시작될 때 1번 호출
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(inventoryTr);        
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        
    }
#endregion
}
