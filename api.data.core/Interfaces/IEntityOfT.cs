namespace api.data.core.Interfaces
{
  public interface IEntity<T> : IEntity
  {
    new T Id { get; set; }
  }
}
