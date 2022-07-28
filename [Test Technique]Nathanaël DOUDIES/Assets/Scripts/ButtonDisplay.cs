using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisplay : MonoBehaviour
{
    public DataManager dataManager;
    public Text textDisplay;

    public int currentIndex;
    
    void Start()
    {
        dataManager = GameObject.Find("Data_Manager").GetComponent<DataManager>();
        textDisplay = GameObject.Find("Text_Display").GetComponent<Text>();
    }
    public void OnClick()
    {
        for (int i=0; i<dataManager.buttonList.Count; i++)
        {
            if (this.gameObject.GetComponent<Button>() == dataManager.buttonList[i])
            {
                currentIndex = i;
                break;
            }
        }
        textDisplay.text = dataManager.DataSet.dataSets[currentIndex].content;
    }
}
