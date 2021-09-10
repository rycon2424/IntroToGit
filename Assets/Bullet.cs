using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 25f;
    public float bulletLife = 5f;

    private void Start()
    {
        Destroy(gameObject, bulletLife);
    }
    
    private void Update()
    {
        transform.Translate(transform.forward * bulletSpeed * Time.deltaTime, Space.World);
        
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.forward, out hitInfo, bulletSpeed * Time.deltaTime))
        {

            var damageable = hitInfo.collider.gameObject.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(1);
                Destroy(hitInfo.collider.gameObject);
            }
        }
    }
}
