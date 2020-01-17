using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
  /*  public GameObject explosion;
    private BlackholeController blackholeController;

    void Start()
    {

        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("BlackholeController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<BlackholeController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'BlackholeController' script");
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickUp"))
        {
            return;
        }

        /*if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        Destroy(other.gameObject);
        Destroy(gameObject);

    }
    */
}