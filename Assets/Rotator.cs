using System.Collections;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] int rotationSpeed;
    private int _rotationDirection = 1; 
    private void Start()
    {
        StartCoroutine(ChangeRotationDirection());
    }

    private IEnumerator ChangeRotationDirection()
    {
        while (true)
        {
           
            int randomValue = Random.Range(0, 2);

           
            _rotationDirection = (randomValue == 0) ? 1 : -1;

            
            yield return new WaitForSeconds(Random.Range(0,5f));
        }
    }

    private void Update()
    {
        transform.Rotate(Vector3.forward, _rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
