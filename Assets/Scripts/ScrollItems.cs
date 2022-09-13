using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScrollItems : MonoBehaviour,IBeginDragHandler, IEndDragHandler
{

    public float speed = 2;
    public Toggle[] toggles;

    private ScrollRect scrollRect;
    private float posX = 0;
    private float targetPosition = 0;
    private float[] pageIndexArray = new float[] { 0, 0.333333f, 0.666666f, 1 };
    bool isDrag = true;

    // Start is called before the first frame update
    void Start()
    {
        scrollRect = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDrag)
        {
            scrollRect.horizontalNormalizedPosition = Mathf.Lerp(scrollRect.horizontalNormalizedPosition, targetPosition, Time.deltaTime * speed);
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isDrag = true;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        isDrag = false;
        posX = scrollRect.horizontalNormalizedPosition;
        int index = 0;
        float offset = Mathf.Abs(posX - pageIndexArray[index]);
        for (int i = 1; i < pageIndexArray.Length; i++)
        {
            float currentOffset = Mathf.Abs(posX - pageIndexArray[i]);
            if (currentOffset < offset)
            {
                offset = currentOffset;
                index = i;
            }
        }
        targetPosition = pageIndexArray[index];
        toggles[index].isOn = true;
        //scrollRect.horizontalNormalizedPosition = pageIndexArray[index];
    }

    public void skipToPage1(bool isOn)
    {
        if (isOn)
        {

            targetPosition = pageIndexArray[0];
            isDrag = false;
        }
    }

    public void skipToPage2(bool isOn)
    {
        if (isOn)
        {
            targetPosition = pageIndexArray[1];
            isDrag = false;
        }
    }

    public void skipToPage3(bool isOn)
    {
        if (isOn)
        {
            targetPosition = pageIndexArray[2];
            isDrag = false;
        }
    }

    public void skipToPage4(bool isOn)
    {
        if (isOn)
        {
            targetPosition = pageIndexArray[3];
            isDrag = false;
        }
    }
}
