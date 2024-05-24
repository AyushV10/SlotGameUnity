using UnityEngine;
using System.IO;

public class SlotDataLoader : MonoBehaviour
{
    public SlotGameData slotGameData;
    void awake()
    {
        Debug.Log("slotGameData");
        Start();
    }
    void Start()
    {
        string jsonFilePath = Application.streamingAssetsPath + "/Data.json";
        string jsonData = File.ReadAllText(jsonFilePath);
        slotGameData = JsonUtility.FromJson<SlotGameData>(jsonData);
        Debug.Log("slotGameData:" + slotGameData);
        // Now you can access slotGameData to get your slot game data
    }

}

[System.Serializable]
public class SlotGameData
{
    public SymbolData[] symbols;
    // Add more properties as needed
}

[System.Serializable]
public class SymbolData
{
    public string name;
    public Sprite sprite;
    public int payoutRate;
    // Add more properties as needed
}
