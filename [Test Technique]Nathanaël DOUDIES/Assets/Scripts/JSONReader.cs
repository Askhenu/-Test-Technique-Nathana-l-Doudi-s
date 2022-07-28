using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{   

    [System.Serializable]
    public class DataSet
    {        
        public int id;
        public string title;
        public string content;
    }

    [System.Serializable]
    public class DataList
    {
        public DataSet[] dataSets;
    }

    public DataList Process(TextAsset dataSet)
    {
        return JsonUtility.FromJson<DataList>("{\"dataSets\":" + dataSet.text + "}");
    }
}