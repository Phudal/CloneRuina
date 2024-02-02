using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    [SerializeField] Animator animator;

    // 합/공격 상대
    private BaseCharacter targetCharacter;

    public void InitCharacter(SIDE side, int index)
    {
        // 테이블에서 불러와서 현재 캐릭터 스탯 등에 대한 데이터를 세팅한다.

        
    }

    public void InitTurnState()
    {
        // 턴이 새로 시작될 때는 타겟 상대 캐릭터를 초기화한다
        targetCharacter = null;

        // 애니메이션 세팅
        SetStateAnim(AnimState.Idle);
    }

    // 상대를 누굴 타겟으로 할 건인지는 CombatManager에서 처음에 정한다.
    public void InitEnemyTurnState(BaseCharacter target)
    {
        targetCharacter = target;

        // 애니메이션 세팅
        SetStateAnim(AnimState.Idle);
    }

    public void SetTargetCharacter(BaseCharacter target)
    {
        targetCharacter = target;
    }

    public void AttackProcess()
    {
        
    }

    private void SetStateAnim(AnimState animState)
    {
        switch (animState)
        {
            case AnimState.Idle:
                animator.SetBool("IsMove", false);
                break;

            case AnimState.Move:
                animator.SetBool("IsMove", true);
                break;

            case AnimState.Attack:
                break;

            case AnimState.Hit:
                break;

            case AnimState.Die:
                break;

            default:
                break;
        }        
    }
}
