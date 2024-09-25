using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] int rotationSpeed;

    void Update()
    {

        if (Input.GetButton("Fire1"))
        {

            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = Camera.main.transform.position.z - transform.position.z;
            if (mousePosition.x > Screen.width / 2)
            {

                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
            else
                transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
    }
}
