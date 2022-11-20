using UnityEngine;
using Game.Enemies;

public class NormalState : EnemyState
{
    public override void Enter()
    {
        Debug.Log("Enter Normal");
    }
    public override void UpdateState()
    {
        Debug.Log("UpdateState Normal");
    }
    public override void Exit()
    {
        Debug.Log("Exit Normal");
    }
}
