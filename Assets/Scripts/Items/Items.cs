using System.Collections.Generic;
using UnityEngine;


/*
 * Item��ΪMOnoBehaviour���ڵ�����ĵ�����
 */

public class Item:MonoBehaviour
{

    public virtual void Do_Item_Function() 
    {
            foreach (ItemFunction curr in itemFunctions) curr.Do_function();
        
    }

    private List<ItemFunction> itemFunctions = new List<ItemFunction>();
}

/*
 * ItemFunction��Ϊ���࣬����ʵ�־��幦�ܵĵ��߼̳������
 */

public class ItemFunction
{
    public virtual void Do_function() { }//����һ��ʵ�־��幦�ܵĺ�������Ѫ��Ѫʲô��������ʵ�֣�ֱ�ӵ�player�ӿڣ��ǵõ��õ�������
}
