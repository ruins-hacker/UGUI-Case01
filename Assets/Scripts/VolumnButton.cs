using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumnButton : MonoBehaviour
{
    public GameObject offObject;
    public GameObject onObject;
    public bool isOn = true;
    // Start is called before the first frame update
    void Start()
    {
        offObject.SetActive(!this.isOn);
        onObject.SetActive(this.isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void clickButton()
    {
        //print(isOn);
        if (!this.isOn)
        {
            print("´ò¿ª");
            offObject.SetActive(false);
            onObject.SetActive(true);

        }
        else
        {
            print("¹Ø±Õ");
            onObject.SetActive(false);
            offObject.SetActive(true);

        }
        this.isOn = !this.isOn;
    }

}
