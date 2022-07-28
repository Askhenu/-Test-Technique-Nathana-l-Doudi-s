using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    [Header("JSON Files")]
    public TextAsset dataSet1;
    public TextAsset dataSet2;

    [Header("JSON Porperties")]
    public JSONReader JSONReader;
    public JSONReader.DataList DataList1;
    public JSONReader.DataList DataList2;
    public JSONReader.DataList DataSet;

    [Header("UI Objects")]
    public List<Button> buttonList = new List<Button>();
    public GameObject displayWindows;
    public GameObject contentObject;
    public GameObject buttonPrefab;    
    
    void Start()
    {
        DataList1 = JSONReader.Process(dataSet1);
        DataList2 = JSONReader.Process(dataSet2);
    }
    
    public bool isSetup1;
    public bool isSetup2;
    public void DisplayData(JSONReader.DataList dataList)
    {

        displayWindows.SetActive(true);
        displayWindows.transform.GetChild(0).gameObject.GetComponent<Text>().text = "";
        DataSet = dataList;

        foreach(Button button in buttonList)
        {
            Destroy(button.gameObject);            
        }
        buttonList.Clear();

        for (int i = 0; i < dataList.dataSets.Length; i++)
        {
            GameObject tempButton = Instantiate(buttonPrefab, contentObject.transform);
            buttonList.Add(tempButton.GetComponent<Button>());
        }
        for (int i = 0; i < buttonList.Count; i++)
        {
            buttonList[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = dataList.dataSets[i].title;
        }

    }
    
    void Update()
    {
        
    }

    public void Button1()
    {
        DisplayData(DataList1);
    }
    public void Button2()
    {
        DisplayData(DataList2);
    }
}
