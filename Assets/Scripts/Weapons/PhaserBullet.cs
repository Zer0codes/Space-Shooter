using UnityEngine;

public class PhaserBullet : MonoBehaviour
{

    void Update() {

        transform.position += new Vector3(PhaserWeapon.Instance.speed * Time.
            deltaTime, 0f);
        if (transform.position.x > 9f) {
            gameObject.SetActive(false);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Obstacle")) {
            gameObject.SetActive(false);
        }

    }
}
