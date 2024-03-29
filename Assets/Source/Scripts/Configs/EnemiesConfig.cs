using UnityEngine;

[CreateAssetMenu(fileName ="Enemies Config", menuName = "Configs/Enemies")]
public class EnemiesConfig : ScriptableObject
{
    [field: SerializeField] public Enemy[] Type { get; private set; }
    [field: SerializeField] public float Health { get; private set; }
    [field: SerializeField] public float HealthPerWaveMultiply { get; private set; }
    [field: SerializeField] public float Speed { get; private set; }
    [field: SerializeField] public float SpeedPerWaveMultiply { get; private set; }
}
