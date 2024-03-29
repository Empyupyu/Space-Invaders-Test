public interface IDamageble
{
    public float Health { get; }
    public bool IsDeath { get;}

    public void ApplyDamage();
}
public interface IMovable
{
    public float Speed { get;}
    public void Move();
}
