
//������������
public class SingleEffectItem:Item
{
    public override void Do_Item_Function()
    {
        base.Do_Item_Function();
        Destroy(gameObject);
    }
}

public class LongLastingItem : Item //����
{
    public override void Do_Item_Function()
    {
        base.Do_Item_Function();
    }
}

public class RandomItem :Item
{

}

public class ChangeWithTimeItem :Item
{

}


