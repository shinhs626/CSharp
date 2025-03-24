using UnityEngine;

namespace Override
{
    public class InheritanceDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Player 클래스 인스턴스 생성
            Player player = new Player(100, 30);

            //Mob 클래스 인스턴스 생성
            Goblin goblin = new Goblin(70, 30);

            Zombie zombie = new Zombie(150, 15);

            //전투
            player.TakeDamage(goblin);
            DrawHealth(player);
            player.TakeDamage(zombie);
            DrawHealth(player);
            goblin.TakeDamage(player);
            DrawHealth(goblin);
            zombie.TakeDamage(player);
            DrawHealth(zombie);
        }
        //캐릭터의 health 그리기
        public void DrawHealth(Character ch)
        {
            Debug.Log($"{ch}:{ch.health}");
        }

        /*
        public void DrawPlayerHealth(Player player)
        {
            Debug.Log($"{player.health}");
        }

        public void DrawGoblinHealth(Goblin goblin)
        {
            Debug.Log($"{goblin.health}");
        }
        public void DrawZombieHealth(Zombie zombie)
        {
            Debug.Log($"{zombie.health}");
        }*/
    }

}
