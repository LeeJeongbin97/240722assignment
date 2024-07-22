using System;

namespace assignment
{
    internal class Program
    {
            #region 과제1
        // Character 클래스
        public class Character
        {
            // field(필드)
            public int Level;     // 레벨
            public int HP;        // 체력
            public int Speed;     // 속도
            public int Attack;    // 공격력


            // 캐릭터 객체 초기화
            public Character(int level, int hp, int speed, int attack)
            {
                this.Level = level;
                this.HP = hp;
                this.Speed = speed;
                this.Attack = attack;
            }

            // 캐릭터의 동작
            public void moveForward()
            {
                Console.WriteLine("전진");
            }
            public void moveBackward()
            {
                Console.WriteLine("후진");
            }
            public void turnLeft()
            {
                Console.WriteLine("좌회전");
            }
            public void turnRight()
            {
                Console.WriteLine("우회전");
            }
            public void attack()
            {
                Console.WriteLine("공격함");
            }
            public void takeDamage()
            {
                Console.WriteLine("뚜까 맞음");
            }
            #endregion

            #region 과제2
            // Character 상속 / 몬스터 클래스
            public class Monster : Character
            {
                // 몬스터 객체 초기화
                public Monster(int level, int hp, int speed, int attack) : base(level, hp, speed, attack){}
            }

            // Chgaracter 상속 / 플레이어 캐릭터 클래스
            public class playerCharacter : Character
            {
                // 플레아어 캐릭터 객체 초기화
                public playerCharacter(int level, int hp, int speed, int attack) : base(level, hp, speed, attack){}
            }
            #endregion


            #region 과제3
            // 몬스터, 플레이어캐릭터 관리
            public class CharacterManager
            {
                public Monster monster;           // 몬스터 객체
                public playerCharacter player;    // 플레이어 캐릭터 객체

                // 몬스터, 플레이어 캐릭터 객체 초기화
                public CharacterManager()
                {
                    monster = new Monster(1, 100, 5, 10);             // 레벨1, 체력100, 속도5, 공격력10 인 몬스터
                    player = new playerCharacter(1, 100, 10, 30);     // 레벨1, 체력100, 속도10, 공격력30 인 플레이어 캐릭터
                }

                // 생성된 몬스터 객체 불러오기
                public Monster GetMonster()
                {
                    return monster;
                }

                // 생성된 플레이어 캐릭터 객체 불러오기
                public playerCharacter GetPlayer()
                {
                    return player;
                }
            }
            static void Main(string[] args)
            {
                // CharacterManager 인스턴트 생성
                CharacterManager characterManager = new CharacterManager();

                // 생성된 인스턴트 불러오기
                Monster monster = characterManager.GetMonster();
                playerCharacter player = characterManager.GetPlayer();
            }
        }
            #endregion
    }
}