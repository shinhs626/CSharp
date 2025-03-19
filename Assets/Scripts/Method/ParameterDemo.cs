using UnityEngine;

namespace Method
{
    public class ParameterDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Monster monster1 = new Monster(100,10);
            Monster.monsterCount++;
            Monster monster2 = new Monster(100, 20);
            Monster.monsterCount++;

            //전투
            //MonsterBatte(monster2, monster1);
            monster1.TakeDamage(monster1, monster2.atack);
            monster2.TakeDamage(monster2, monster1.atack);

            Debug.Log($"monster 1 hp : {monster1.hp}, monster 1 atack : {monster1.atack}");
            Debug.Log($"monster 2 hp : {monster2.hp}, monster 2 atack : {monster2 .atack}");
            Debug.Log($"monster count : {Monster.monsterCount}");

        }

        //몬스터간의 1 : 1 전투 구현
        void MonsterBatte(Monster atackMonster, Monster defMonsters)
        {
            defMonsters.hp -= atackMonster.atack;
        }
    }

    //몬스터를 관리하는 클래스
    public class Monster
    {
        //필드
        //정적 멤버 변수 : 이 프로젝트 내에서 단 하나만 존재하는 값, 공유(share)
        //이 게임에서 생성된 모스터 총 수량을 저장
        public static int monsterCount = 0;

        public int hp;
        public int atack;

        //생성자
        public Monster(int hp, int atack)
        {
            this.hp = hp;
            this.atack = atack;
        }

        //데미지 입는 함수
        public void TakeDamage(Monster _this, int damage)
        {
            _this.hp -= damage;
        }

    }
}

