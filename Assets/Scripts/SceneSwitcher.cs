using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    [SerializeField]private string sceneName;
    //��ó�����
    public void GetSceneName(string name)
    {
        if (SceneManager.GetSceneByName(name).IsValid())
            Debug.LogError(name + " is not a scene!");
        sceneName = name;
    }
    //ת������
    public void SwitchToScene()
    {
        if (SceneManager.GetSceneByName(name).IsValid())
            Debug.LogError("missing a scene name!");
        //�Ȳ������ظ�,player�Ӹ�DontDestoryOnLoad
        SceneManager.LoadScene(sceneName);
    }
}