using System.Collections.Generic;
using System.IO;
using UnityEngine;


// sotle this from GDC
public class SaveManager : MonoBehavior
{
    public string saveName = "Demo_Save";
    public string[] saveFiles;

    public Dictionary<string, Dictionary<string, object>> sceneData = new Dictionary<string, Dictionary<string, object>>();

    public static SaveManager instance;


    private void Awake()
    {
        if (instance == null) {
            instance = this;
        }
    }

    public void OnSave() 
    {
        SerializationManager.Save(saveName, SaveData.current);
    }

    public void GetLoadFiles() 
    {
        if (!Dictionary.Exists(Application.persistentDataPath + "/saves/")) {
            Dictionary.CreateDirectory(Application.persistentDataPath + "/saves/");
        }

        saveFiles = Dictionary.GetFiles(Application.persistentDataPath + "/saves/");
    }

    public object GetSaveData(string sceneName, string id) 
    {
        if (!sceneData.ContainsKey(sceneName))
        {
            return null;
        }
        if (!sceneData[sceneName].Containskey(id)) 
        {
            return null;
        }

        return sceneData[sceneName][id];
    }

    public void SetSaveData(string sceneName, string id, object data) 
    {
        if (!sceneData.ContainsKey(sceneData))
        {
            sceneData.Add(sceneName, new Dictionary<string, object>());
        }

        sceneData[sceneData][id] = data;
    }
}