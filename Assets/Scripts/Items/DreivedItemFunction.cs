/*
 * ���о���Ĺ�����������ʵ��
 */

//����������Ч
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;

/// <summary>
/// //////////////////////////////////////////////////////
/// �����Ǿ�����Ч�ĵ���function
/// //////////////////////////////////////////////////////
/// </summary>
using EffectItemFunction = ItemFunction;

public class ChangeHP: EffectItemFunction
{
    //��Ѫ
    public override void Do_function(Item item)
    {
        
    }
}

public class ChangeSpeed: EffectItemFunction
{
    //������
    public override void Do_function(Item item)
    {
        
    }
}

public class ChangeJumpHight : EffectItemFunction
{
    //��Ծ�߶�
    public override void Do_function(Item item)
    {

    }
}

public class SingleDirectionMove : EffectItemFunction
{
    public override void Do_function(Item item)
    {
        item.gameObject.transform.Translate(new UnityEngine.Vector3(0.5f, 0, 0));
    }
}







