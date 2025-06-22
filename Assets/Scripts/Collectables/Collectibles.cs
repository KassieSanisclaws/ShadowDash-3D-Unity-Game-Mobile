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

            // Play the appropriate sound effect based on the collectible type
            PlayPickUpSound(type);

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

    private void PlayPickUpSound(CollectibleType itemType)
    {
      if (SoundManager.instance == null) return;
        switch (itemType)
        {
            case CollectibleType.Coin:
                SoundManager.instance.PlaySFX(SoundManager.instance.coinPickup);
                break;
            case CollectibleType.DragonFruit:
                SoundManager.instance.PlaySFX(SoundManager.instance.dragonFruitPickup);
                break;
            case CollectibleType.DurianFruit:
                SoundManager.instance.PlaySFX(SoundManager.instance.coinPickup); // optional reuse
                break;
            case CollectibleType.DragonBall:
                SoundManager.instance.PlaySFX(SoundManager.instance.gameWin); // or a unique sound
                break;
            case CollectibleType.Shuriken:
                SoundManager.instance.PlaySFX(SoundManager.instance.shurikenPickup);
                break;
          }
       }
    }
