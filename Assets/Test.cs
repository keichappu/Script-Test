using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        int[] array = { 20, 15, 47, 30, 17 };

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(array[i]);
        }
        Boss boss = new Boss ();
        for (int i = 0; i < 12; i++)
        {
            boss.Magic();
        }
    }

public class Boss
    {
        private int hp = 100;
        private int power = 25;
        private int mp = 53;

        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            this.hp -= damage;
        }

        public void Magic()
        {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("���@�U���������B�c��MP��" + this.mp);
            }             
            else 
            {
                Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
            }
        }
    }

    void update()
    {

    }
}