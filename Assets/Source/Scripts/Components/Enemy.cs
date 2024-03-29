using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class StandartEnemy : Enemy
{

}
public abstract class Enemy : MonoBehaviour
{
    public ReactiveProperty<float> Health { get; private set; }
    public ReactiveProperty<bool> IsDead { get; private set; }

    public float Speed { get; private set; }


    public void Initialize(float health, float speed)
    {
        Health = new ReactiveProperty<float>(health);
        Speed = speed;
    }
}
