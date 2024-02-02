using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    [SerializeField] Animator animator;

    // ��/���� ���
    private BaseCharacter targetCharacter;

    public void InitCharacter(SIDE side, int index)
    {
        // ���̺��� �ҷ��ͼ� ���� ĳ���� ���� � ���� �����͸� �����Ѵ�.

        
    }

    public void InitTurnState()
    {
        // ���� ���� ���۵� ���� Ÿ�� ��� ĳ���͸� �ʱ�ȭ�Ѵ�
        targetCharacter = null;

        // �ִϸ��̼� ����
        SetStateAnim(AnimState.Idle);
    }

    // ��븦 ���� Ÿ������ �� �������� CombatManager���� ó���� ���Ѵ�.
    public void InitEnemyTurnState(BaseCharacter target)
    {
        targetCharacter = target;

        // �ִϸ��̼� ����
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
