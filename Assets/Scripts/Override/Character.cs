using UnityEngine;

namespace Override
{
    //플레이어(...), 몹(슬라임, 좀비, 고블린...)
    //모든 캐릭터의 추상 부모 클래스(캐릭터가 가지고 있는 공통 기능)
    public abstract class Character
    {
        public abstract int GetTotalAttack();

        public int health;
        public int baseAtk;

        //생성자 - 멤버 초기화
        public Character(int hp, int atk)
        {
            this.health = hp;
            this.baseAtk = atk;
        }

        //매개변수로 나에게 데미지 주는 캐릭터 객체를 전달해준다
        public void TakeDamage(Character other)
        {
            health -= other.GetTotalAttack();
        }
    }

    //플레이어
    public class Player : Character
    {
        public Player() : this(100, 10) { }
        public Player(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //장비
            //스킬
            //상성

            return total;
        }
    }

    //몹 : 슬라임, 좀비, 고블린 .....의 부모 클래스
    public class Mob : Character
    {
        //생성자
        public Mob(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }

        //몹 : 슬라임, 좀비, 고블린 ..... 공통 기능 구현
        //...
    }

    //고블린
    public class Goblin : Mob
    {
        //
        public int posX, posY;

        public Goblin(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }

        public void SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }
    }
    //고블린
    public class Zombie : Mob
    {
        //
        public int posX, posY;

        public Zombie(int hp, int atk) : base(hp, atk) { }

        public override int GetTotalAttack()
        {
            int total = 0;
            total += this.baseAtk;
            //스킬
            //상성

            return total;
        }

        public void SetPosition(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }
    }
}
