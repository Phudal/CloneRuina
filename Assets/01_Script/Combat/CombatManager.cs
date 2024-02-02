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
        // ������ § ��ġ�� �����ͼ� ��ȯ�ؾ��Ѵ�.

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
        // �������� ������ �޾Ƽ� ������ �󸶳� ��ȯ�Ұ��� �����;��Ѵ�.
    }
}
