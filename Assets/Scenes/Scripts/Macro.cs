/*
 * ����ļ�����洢���ж����еĲ��������֣����������ĺ�
 * animator.SetFloat("move",speed);
 * animator.Set<Variable type>("variable name",variable value)
 * ���е�string�洢�붯������ͬ���ı�����������������д��ע����
*/

public class AxisMacro
{
    public static string HorizontalString = "Horizontal";
    public static string VerticalString = "Vertical";
    
}


public class PlayerAnimatorMacro
{
    //���еĺ궼Ӧ����static��
    public static string idle="idle";//bool
    //����run��һ����ʾ�ƶ��Ķ�����
    public static string move="move";//float
    public static string jump = "jump"; //bool

}

public class CharacterAnimatorMacro
{
    public static string idle="idle";//bool
    public static string move="move";//float

}
//�����enimy����npc���Դ������CharacterAnimatorMacro����