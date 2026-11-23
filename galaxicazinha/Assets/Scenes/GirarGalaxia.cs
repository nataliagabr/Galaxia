using UnityEngine;

public class GirarGalaxia : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(0f, 0f, 20f * Time.deltaTime, Space.Self);
    }
}