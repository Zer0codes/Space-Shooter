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

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Obstacle")) {
            Asteroid asteroid = collision.gameObject.GetComponent<Asteroid>();
            if (asteroid) asteroid.TakeDamage(PhaserWeapon.Instance.damage);
            gameObject.SetActive(false);
        } else if (collision.gameObject.CompareTag("Critter")) {
            gameObject.SetActive(false);
        }

    }
}
