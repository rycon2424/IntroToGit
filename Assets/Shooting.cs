using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    private float refireTime = 0;

    private void Update()
    {
        // Fire gun
        refireTime -= Time.deltaTime;
        if ( Input.GetMouseButton(0) && refireTime <= 0 ) {
            Vector3 mousePosition = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
            var position = transform.position + ( mousePosition - transform.position ).normalized;
            GameObject bulletInstance = GameObject.Instantiate(bullet, position, Quaternion.identity);
            bulletInstance.transform.LookAt(mousePosition);
            mousePosition.y = 0;
        }
    }
}
