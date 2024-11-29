using UnityEngine;
public class DamagerReceiver : MonoBehaviour
{
    BotController botController;
    private void OnEnable()
    {
        botController = GetComponentInParent<BotController>();
    }
    public void TakeDamage(int damageAmount)
    {
        if (botController)
            botController.ApplyDamage(damageAmount);
    }
}