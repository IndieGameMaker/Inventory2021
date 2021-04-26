using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    public static GameObject draggingItem = null;
    private Transform inventoryTr;
    private Transform itemListTr;

    void Start()
    {
        inventoryTr = GameObject.Find("Inventory").transform;
        itemListTr  = GameObject.Find("ItemList").transform;
    }

#region MOUSE_EVENTS
    // 마우스 드래그가 시작될 때 1번 호출
    public void OnBeginDrag(PointerEventData eventData)
    {
        draggingItem = this.gameObject;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        transform.SetParent(inventoryTr);        
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        draggingItem = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        if (transform.parent == inventoryTr)
        {
            transform.SetParent(itemListTr);
        }
    }
#endregion
}
