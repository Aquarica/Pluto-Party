using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
     public GameObject explosion;
     private BlackholeController gameController;
    //This code ended up being USELESS


      void Start()
      {
        /*
          GameObject gameControllerObject = GameObject.FindGameObjectWithTag("BlackholeController");
          if (gameControllerObject != null)
          {
              gameController = gameControllerObject.GetComponent<BlackholeController>();
          }
          if (gameController == null)
          {
              Debug.Log("Cannot find 'BlackholeController' script");
          }
          */

      }

      void OnTriggerEnter2D(Collider other)
      {
          if (other.CompareTag("BH"))
          {
            Instantiate(explosion, transform.position, transform.rotation);
            
          }

          /*if (explosion != null)
          {
              Instantiate(explosion, transform.position, transform.rotation);
          }

          Destroy(other.gameObject);
          Destroy(gameObject);
          */
      }
      
}
