using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : SingletonMonoBehaviour<CombatManager>
{
    [SerializeField] CommonPoolController allyPool;

    List<BaseCharacter> allyList = new List<BaseCharacter>();
    List<BaseCharacter> enemyList = new List<BaseCharacter>();

    private void Start()
    {
        AllySpawnProcess();

        AllyTurnInitProcess();
    }

    public void InitializeCombat()
    {
        allyList.Clear();
        enemyList.Clear();

    }
    
    public void AllySpawnProcess()
    {
        // 유저가 짠 배치를 가져와서 소환해야한다.

        void TempSpawnProcess()
        {
            for (int i = 0; i < 5; i++)
            {

                BaseCharacter pooledItem = allyPool.GetPoolItem<BaseCharacter>();
                pooledItem.gameObject.SetActive(true);
                pooledItem.transform.SetParent(gameObject.transform);

                allyList.Add(pooledItem);

                pooledItem.InitCharacter(SIDE.ALLY, i);                
            }
        }

        TempSpawnProcess();
    }

    public void AllyTurnInitProcess()
    {
        for (int i = 0; i < allyList.Count; i++)
        {
            allyList[i].InitTurnState();
        }
    }

    public void EnemyTurnInitProcess()
    {
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].InitEnemyTurnState(RandomUtil.GetRandomListItem(allyList));
        }
    }

    public void EnemySpawnProcess()
    {
        // 스테이지 정보를 받아서 무엇을 얼마나 소환할건지 가져와야한다.
    }
}
