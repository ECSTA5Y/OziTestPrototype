using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public static Gun Instance;
    [SerializeField] GameObject[] gunBarrel;
    [SerializeField] Bullet bulletPrefab;
    [SerializeField] float projectileSpeed = 15f;
    [SerializeField] Transform endTransform;
    public int damage = 100;
    [SerializeField] int bulletsPoolSize = 20;
    List<GameObject> bulletsPoolList = new(); // i can implement pooling for bullets to optimize the performance of game but i have been asked to do test quickly so i'd turn in test without pooling the bullets to save time
    void Awake()
    {
        Instance = this;
    }
    private void OnEnable()
    {
        Initialize();
    }
    void Start()
    {
        transform.DOMove(endTransform.position, 5)
    .SetEase(Ease.Linear)
    .SetLoops(-1, LoopType.Yoyo);
    }
    void Initialize()
    {
        GameplayUi.Instance.shootBtn.onClick.RemoveAllListeners();
        GameplayUi.Instance.shootBtn.onClick.AddListener(Shoot);
    }
    public void Shoot()
    {
        foreach (var item in gunBarrel)
        {
            Bullet projectile;
            projectile = Instantiate(bulletPrefab, item.transform.position, Quaternion.identity);
            projectile.InitializeBullet(transform.forward, projectileSpeed, damage);
        }
    }
}
