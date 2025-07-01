using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace FootballGaussian
{
    public class SpawnFootball : MonoBehaviour
    {
        [SerializeField]
        private GameObject footballPrefab;

        private Transform _resetPoint; 
        private float _resetDelay = 3f;
        
        private void Start()
        {
            _resetPoint = footballPrefab.transform;
        }

        public void OnFootballReleased(SelectExitEventArgs args)
        {
            GameObject releasedFootball = args?.interactableObject?.transform?.gameObject;

            if (releasedFootball != null)
            {
                Debug.Log("Football released. Reset ball");

                StartCoroutine(ResetFootballDelay(releasedFootball));
            }
        }

        private IEnumerator ResetFootballDelay(GameObject football)
        {
            yield return new WaitForSeconds(_resetDelay);

            // Reset position and rotation
            football.transform.position = _resetPoint.position;
            football.transform.rotation = _resetPoint.rotation;

            // Reset physics (clear any leftover velocity)
            Rigidbody rb = football.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            Debug.Log("Football has been reset to init point!");
        }
    }
}

