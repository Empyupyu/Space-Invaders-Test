using EGameSystems;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class EnemySpawner : GameSystem
{
    private EnemiesConfig _enemiesConfig;

    private void Start()
    {
        
    }

    private void SpawnEnemy()
    {
        var enemies = _enemiesConfig.Type;
        for (int i = 0; i < 5; i++)
        {
            var enemy = Instantiate(enemies[Random.Range(0, enemies.Length)], transform.position, Quaternion.identity);
            enemy.Initialize(_enemiesConfig.Health + _enemiesConfig.HealthPerWaveMultiply * gameData.WaveIndex,
                _enemiesConfig.Speed + _enemiesConfig.SpeedPerWaveMultiply * gameData.WaveIndex);
        }
    }


}

public class PlayerMovment : GameSystem
{
    [field: SerializeField] public ReactiveProperty<Joystick> Joystick { get; private set; }
    [field: SerializeField] public ReactiveProperty<Transform> Player { get; private set; }
    [field: SerializeField] public float PlayerSpeed { get; private set; }
    [field: SerializeField] public float PlayerClampMinimumPositionX { get; private set; }
    [field: SerializeField] public float PlayerClampMaximumPositionX { get; private set; }

    void Start()
    {
        Joystick.Value.UpdateAsObservable().Subscribe(x => Move()).AddTo(this);
    }

    private void Move()
    {
        var newPosition = Player.Value.position + new Vector3(Joystick.Value.Direction.x, 0, 0) * PlayerSpeed * Time.deltaTime;
        var clampX = Mathf.Clamp(newPosition.x, PlayerClampMinimumPositionX, PlayerClampMaximumPositionX);
        newPosition.x = clampX;

        Player.Value.position = newPosition;
    }
}
