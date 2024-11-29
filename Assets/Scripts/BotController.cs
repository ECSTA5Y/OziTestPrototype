using System.Collections.Generic;
using UnityEngine;
public class BotController : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] List<Rigidbody> bonesList;
    [SerializeField] int health = 100;
    void Start()
    {
        Initialize();
    }
    void Initialize()
    {
        LevelManager.Instance.aliveBots.Add(this);
        bonesList.AddRange(GetComponentsInChildren<Rigidbody>());
        foreach (var bone in bonesList)
            bone.isKinematic = true;
    }
    public void ApplyDamage(int damageAmount)
    {
        if (health <= 0)
            return;

        health -= damageAmount;
        if (health <= 0)
        {
            Death();
        }
    }
    void Death()
    {
        anim.enabled = false;
        foreach (var b in bonesList)
            b.isKinematic = false;
        LevelManager.Instance.BotDied(this);
    }
}