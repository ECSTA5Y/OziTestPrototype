using System.Collections;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] new Rigidbody rigidbody;
    int _damage;
    public void InitializeBullet(Vector3 direction, float speed, int damage)
    {
        _damage = damage;
        rigidbody.AddForce(direction * speed, ForceMode.VelocityChange);
        StartCoroutine(DespawnBulletAfterTime());
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out DamagerReceiver damagerReceiver))
        {
            damagerReceiver.TakeDamage(_damage);
            GetComponent<Collider>().enabled = false;
        }
        Destroy(gameObject);
    }
    IEnumerator DespawnBulletAfterTime()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}