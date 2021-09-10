using UnityEngine;

public class Player : MonoBehaviour
{
    const float playerSpeed = 10f;
    
    void Update()
    {
        // Move player
        transform.Translate( Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed, 0, Input.GetAxis("Vertical") * Time.deltaTime * playerSpeed);
    }
}
