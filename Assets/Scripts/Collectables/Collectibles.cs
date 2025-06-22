using UnityEngine;

public class Collectibles : MonoBehaviour
{
  public enum CollectibleType
  {
    Coin,
    DragonFruit,
    DurianFruit,
    DragonBall,
    Shuriken,
  }

    public CollectibleType type;

 private void OnTriggerEnter(Collider other)
    {
      if (other.CompareTag("Player"))
        {
            int scoreToAdd = GetScoreFromType(type);
            LevelOneGameManager.instance.AddScore(scoreToAdd);
            Destroy(gameObject);
        }
    }

    private int GetScoreFromType(CollectibleType itemType)
    {
        switch (itemType)
        {
            case CollectibleType.Coin: return 500;
            case CollectibleType.DragonFruit: return 3000;
            case CollectibleType.DurianFruit: return 1000;
            case CollectibleType.DragonBall: return 5000;
            case CollectibleType.Shuriken: return 2000;
            default: return 0;
        }
    }
}
