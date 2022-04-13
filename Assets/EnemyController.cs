using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (player.transform.position - transform.position).normalized * speed * Time.deltaTime;
        transform.LookAt(player.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Spiller")
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
