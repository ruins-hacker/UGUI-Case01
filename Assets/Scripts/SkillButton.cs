using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillButton : MonoBehaviour
{
    // Start is called before the first frame update
    public float codeTime = 2;
    public KeyCode keyCode;

    private bool isStartTimer = false;
    private Image filledImage;
    private float timer = 0;
    void Start()
    {
        filledImage = transform.Find("FilledImage").GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyCode))
        {
            isStartTimer = true;
            print("start");
        }
        if (isStartTimer)
        {
            timer += Time.deltaTime;
            filledImage.fillAmount = 1 - timer / codeTime;
            if (timer >= codeTime)
            {
                filledImage.fillAmount = 0;
                timer = 0;
                isStartTimer = false;
            }
        }
    }
}
