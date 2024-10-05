using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateScene : UIBase
{
    // Start is called before the first frame update
    //ѡ��ϸ����ʱ������
    public GameObject newCell;
    void Start()
    {
        OnExit();
    }
    public override void OnEnter()
    {
        Time.timeScale = 0;
        state = UIState.Enter;
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
    }
    public override void OnExit()
    {

        newCell = null;
        state = UIState.Exit;
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
    }
}
